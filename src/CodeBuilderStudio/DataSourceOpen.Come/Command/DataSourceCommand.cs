/*
 *author:南京.王清培
 *coding time:2011.7.2
 *copyright:快捷速递
 *function:数据库操作类
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataSourceOpen.Come.Command
{
    /// <summary>
    /// 数据源命令类，操作所有的数据源。先这么用，后面在提取不同的数据库类型操作。
    /// </summary>
    public class DataSourceCommand
    {
        /// <summary>
        /// 测试SQL服务连接
        /// </summary>
        /// <param name="datasource">服务器地址</param>
        /// <returns>是否成功</returns>
        public static bool CheckConn(StringBuilder datasource)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(datasource.ToString()))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception err) { return false; }

        }
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
                using (SqlConnection conn = new SqlConnection(datasource))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand command = new SqlCommand("select Name from sysobjects where xtype='u' and status>=0", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["name"].ToString());
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
        /// 检索指定SQL服务器中的所有试图名称
        /// </summary>
        /// <param name="datasource">服务器地址</param>
        /// <returns>泛型集合，试图名称集合</returns>
        public static List<string> GetViewList(string datasource)
        {
            try
            {
                List<string> list = new List<string>();
                using (SqlConnection conn = new SqlConnection(datasource))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand command = new SqlCommand("select Name from sysobjects where xtype='v' and status>=0", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["name"].ToString());
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
                StringBuilder sql = new StringBuilder("select * from ");
                sql.Append(tablename + " where 1<>1");
                List<Module.M_Column> result = new List<DataSourceOpen.Come.Module.M_Column>();
                using (SqlConnection conn = new SqlConnection(datasource))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), conn);
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
            sqlstring.AppendFormat(@"select syscolumns.name as '列名',SysTypes.name as '数据类型',
            SysColumns.Length as '数据长度',sys.extended_properties.value as '说明' ,
            case when idl.column_id is not null then 1 else 0 end '主键'
            from syscolumns inner join sysobjects on syscolumns.id=sysobjects.id 
            inner join SysTypes on Syscolumns.XType=SysTypes.XType 
            and syscolumns.xusertype = systypes.xusertype
            left join sys.indexes idx on idx.object_id = sysobjects.id 
            and idx.is_primary_key = 1
            LEFT join sys.index_columns idl on idl.object_id = syscolumns.id
            and idl.index_id = idx.index_id
            and idl.column_id = syscolumns.colid
            LEFT OUTER JOIN sys.extended_properties on
            ( sys.extended_properties.minor_id = syscolumns.colid 
            AND sys.extended_properties.major_id = syscolumns.id) 
            where SysTypes.Name!='sysname' and sysobjects.name='{0}'  order by syscolumns.id", tablename);

            using (SqlConnection conn = new SqlConnection(datasource))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlstring.ToString(), conn);
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
            sqlstring.AppendFormat(@"select tbl.name 表名, pks.name 主键名, col.name 列名
            from sys.objects tbl join sys.objects pks 
            on pks.parent_object_id = tbl.object_id
            join sys.indexes idx on idx.object_id = tbl.object_id
            and is_primary_key = 1
            join sys.index_columns idl on idl.object_id = tbl.object_id
            and idl.index_id = idx.index_id
            join sys.columns  col on col.object_id = tbl.object_id
            and col.column_id = idl.column_id
            where tbl.type = 'U' and  pks.type='PK'
            order by tbl.name , pks.name, index_column_id");
            #endregion

            using (SqlConnection conn = new SqlConnection(datasource))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlstring.ToString(), conn);
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
            string sqlstring = string.Format(@"--查询存储过程
            select * from sys.objects where sys.objects.type='p'");
            List<string> list = new List<string>();
            using (SqlConnection conn = new SqlConnection(datasource))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand command = new SqlCommand(sqlstring, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader["name"].ToString());
                }
                command.Dispose();
                conn.Close();
                conn.Dispose();
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
            string sqlstring = string.Format(@"--查询存储过程接口参数
            select pt.name ParamName, pt.parameter_id ,
		            tp.name TypeName, pt.max_length ParamLength,
		            tp.precision, tp.scale,
		            tp.is_nullable, tp.is_user_defined,pt.is_output
            from sys.parameters pt join sys.types tp 
	            on pt.system_type_id = tp.system_type_id
	            and pt.user_type_id = tp.user_type_id
            where object_id = OBJECT_ID('{0}')", prname);
            using (SqlConnection conn = new SqlConnection(datasource))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlstring.ToString(), conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, prname);
                return ds.Tables[prname];
            }
        }
    }
}