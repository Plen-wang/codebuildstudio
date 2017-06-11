using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Text;

namespace DataSourceOpen.Come.Command.OracleCommand
{
    public class DataSourceCommand
    {
        /// <summary>
        /// 检索指定SQL服务器中的所有表名称
        /// </summary>
        /// <param name="datasource">服务器地址</param>
        /// <returns>泛型集合,表名称集合</returns>
        public static List<string> GetTableColl(string datasource)
        {
            try
            {
                List<string> list = new List<string>();
                using (OracleConnection conn = new OracleConnection(datasource))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    global::System.Data.OracleClient.OracleCommand command =
                        new global::System.Data.OracleClient.OracleCommand("select TABLE_NAME , TABLESPACE_NAME from user_tables", conn);
                    OracleDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["TABLE_NAME"].ToString());
                    }
                    command.Dispose();
                    conn.Close();
                    conn.Dispose();
                    return list;
                }
            }
            catch { return new List<string>(); }
        }
        /// <summary>
        /// 检索指定SQL服务器中的所有视图名称
        /// </summary>
        /// <param name="datasource">服务器地址</param>
        /// <returns>泛型集合，试图名称集合</returns>
        public static List<string> GetViewList(string datasource)
        {
            try
            {
                List<string> list = new List<string>();
                using (OracleConnection conn = new OracleConnection(datasource))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    global::System.Data.OracleClient.OracleCommand command =
                        new global::System.Data.OracleClient.OracleCommand("select VIEW_NAME from user_views", conn);
                    OracleDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["VIEW_NAME"].ToString());
                    }
                    command.Dispose();
                    conn.Close();
                    conn.Dispose();
                    return list;
                }
            }
            catch { return new List<string>(); }
        }
        /// <summary>
        /// 获取指定数据源的表的列集合
        /// </summary>
        /// <param name="datasource">数据源字符串</param>
        /// <param name="tablename">表名称</param>
        /// <returns>列集合</returns>
        public static List<Module.M_Column> GetTableColumnList(string datasource, string tablename)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendFormat(@"SELECT * from {0} where 1<>1", tablename);

                List<Module.M_Column> result = new List<DataSourceOpen.Come.Module.M_Column>();
                using (OracleConnection conn = new OracleConnection(datasource))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    OracleDataAdapter adapter = new OracleDataAdapter(sql.ToString(), conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table");
                    for (int i = 0; i < ds.Tables["table"].Columns.Count; i++)
                    {
                        Module.M_Column m = new DataSourceOpen.Come.Module.M_Column();
                        m.tbcolumname = ds.Tables["table"].Columns[i].ColumnName;
                        result.Add(m);
                    }
                }
                return result;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 获取指定表的各列具体信息
        /// </summary>
        /// <param name="datasource">数据源连接字符串</param>
        /// <param name="tablename">表名称</param>
        /// <returns>DataTable</returns>
        public static DataTable GetTableColumnsInfo(string datasource, string tablename)
        {
            StringBuilder sqlstring = new StringBuilder();
            sqlstring.AppendFormat(@"SELECT
           COLUMN_NAME, -- 列名
           DATA_TYPE, -- 列类型
           DATA_LENGTH, -- 列长度
           DATA_PRECISION, -- 数值长度
           DATA_SCALE, -- 小数点位数
           NULLABLE, -- 是否允许空 'Y' for Yes OR 'N' for No
           COLUMN_ID,  -- 列序号
           DATA_DEFAULT -- 缺省值
           FROM USER_TAB_COLS where TABLE_NAME='{0}'", tablename);

            using (OracleConnection conn = new OracleConnection(datasource))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(sqlstring.ToString(), conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, tablename);
                return ds.Tables[tablename];
            }
        }
        /// <summary>
        /// 查询数据源中的所有表主键信息。
        /// 专门用来查询主键信息。
        /// </summary>
        /// <param name="datasource">数据源连接字符串</param>
        /// <param name="tablename">表名称</param>
        /// <returns>主键信息DataTable</returns>
        public static DataTable GetTableColumns(string datasource, string tablename)
        {
            #region
            StringBuilder sqlstring = new StringBuilder();
            sqlstring.AppendFormat(@"SELECT * FROM USER_CONSTRAINTS");
            #endregion

            using (OracleConnection conn = new OracleConnection(datasource))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(sqlstring.ToString(), conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, tablename);
                return ds.Tables[tablename];
            }
        }
        /// <summary>
        /// 获取存储过程
        /// </summary>
        /// <param name="datasource"></param>
        /// <returns></returns>
        public static List<string> GetProcedure(string datasource)
        {
            string sqlstring = string.Format(@"SELECT * FROM USER_PROCEDURES");
            List<string> list = new List<string>();
            using (OracleConnection conn = new OracleConnection(datasource))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                OracleDataAdapter adapter = new OracleDataAdapter(sqlstring, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(row["OBJECT_NAME"].ToString());
                }
                return list;
            }
        }
        /// <summary>
        /// 获取存储过程参数
        /// </summary>
        /// <param name="datasource"></param>
        /// <param name="prname"></param>
        /// <returns></returns>
        public static DataTable GetParameter(string datasource, string prname)
        {
            string sqlstring = string.Format(@"SELECT OBJECT_NAME , --对象名
            PACKAGE_NAME, -- PACKAGE名
            ARGUMENT_NAME, -- 参数名
            DATA_TYPE,     --参数类型
            DEFAULT_VALUE, --默认值
            IN_OUT        -- IN、OUT 、IN/OUT
            FROM USER_ARGUMENTS a where OBJECT_NAME='{0}' ", prname);
            using (OracleConnection conn = new OracleConnection(datasource))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(sqlstring.ToString(), conn);
                DataTable dt = new DataTable();
                dt.TableName = prname;
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
