/*
 *author:南京.王清培
 *coding time:2011.9.8
 *copyright:快捷速递
 *function:托管代码生成。
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;

using NVelocity;
using NVelocity.App;
using NVelocity.Context;
using NVelocity.Exception;
using NVelocity.Runtime;
using NVelocity.Tool;
using NVelocity.Util;
using Commons.Collections;

namespace UnManagerCodeEngine
{
    /// <summary>
    /// 根据VM模板，生成委托代码。
    /// </summary>
    public static class UnManager
    {
        /// <summary>
        /// 为了消耦，避免使用Main.Interface中的数据源类型做判断
        /// </summary>
        public enum DataSourceType
        {
            MsSqlServer,
            Oracle
        }
        /// <summary>
        /// 生成代码的类型
        /// </summary>
        public enum BuilderCodeType
        {
            /// <summary>
            /// 表代码
            /// </summary>
            Table,
            /// <summary>
            /// 存储过程代码
            /// </summary>
            Store
        }
        static UnManager() { }
        /// <summary>
        /// 开始生成托管代码过程
        /// </summary>
        /// <param name="vmfilename">模板文件路径</param>
        /// <param name="dt">要生成的表数据</param>
        /// <param name="dtysource">生成代码的数据源类型</param>
        /// <param name="codetype">生成代码的类型</param>
        /// <returns>生成后的托管代码</returns>
        public static string ProcessUnManager(string vmfilename, DataTable dt, DataSourceType dtysource, BuilderCodeType codetype)
        {
            if (codetype == BuilderCodeType.Table)
            {
                if (dtysource == DataSourceType.MsSqlServer)
                    idatabasetype = new Command.MsSqlServerDataTypeEdit();
                else if (dtysource == DataSourceType.Oracle)
                    idatabasetype = new Command.OracleDataTypeEdit();
            }
            else if (codetype == BuilderCodeType.Store)
            {
                if (dtysource == DataSourceType.MsSqlServer)
                    idatabasetype = new Command.StoreMsSqlServerDataTypeEdit();
                else if (dtysource == DataSourceType.Oracle)
                    idatabasetype = new Command.StoreOracleDataTypeEdit();
            }

            idatabasetype.GetRef();
            //模板引擎对象初始化(设置模板引擎读取模板的虚拟目录位置)
            NVelocityManager.SetNVelociryProperty += new NVelocityManager.OnSetNVelocityPropertyHander(NVelocityManager_SetNVelociryProperty);
            NVelocityManager.SetProperty(System.Configuration.ConfigurationManager.AppSettings["CodeThempPath"]);

            //获取模板引擎核心处理对象对象
            VelocityEngine engine = NVelocityManager.GetEngIne;

            //读取模板文件VM
            Template engtemplate = engine.GetTemplate(vmfilename);

            //设置模板引擎核心对象处理的标记与托管对象的映射生成
            IContext tagcontent = new VelocityContext();

            #region 填充模板托管对象
            ObjectDictionary.SystemObject sysobject = new ObjectDictionary.SystemObject();//系统常用属性对象
            tagcontent.Put("System", sysobject);//将系统常用对象插入到模板引擎中

            if (codetype == BuilderCodeType.Table)
            {
                BuilderTableBase tableobject;
                if (dtysource == DataSourceType.MsSqlServer)
                    tableobject = GetBuilderObject(dt);//获取物理表的逻辑抽象对象
                else
                    tableobject = GetBuilderObjectOracle(dt);
                tagcontent.Put("Table", tableobject);//将表的信息插入到模板引擎中
            }
            //存储过程
            else
            {
                BuilderStore store;
                if (dtysource == DataSourceType.MsSqlServer)
                    store = GetParameterObject(dt);
                else
                    store = GetParameterObjectOracle(dt);
                tagcontent.Put("StoreProcedure", store);
            }
            #endregion

            StringWriter strwriter = new StringWriter();
            engtemplate.Merge(tagcontent, strwriter);

            string str = strwriter.ToString();
            return str;
        }
        private static void NVelocityManager_SetNVelociryProperty(DateTime ondatetime, string onpath)
        {
            //可以记录生成日志
        }
        /// <summary>
        /// 根据DataTable获取物理表的抽象逻辑表，利用它来生成托管代码
        /// </summary>
        /// <param name="dt">DataTable对象</param>
        /// <returns>UnManagerCodeEngine.BuilderTableBase集合对象</returns>
        private static BuilderTableBase GetBuilderObject(DataTable dt)
        {
            BuilderTableBase table = new BuilderTableBase(dt.TableName, "");
            foreach (DataRow row in dt.Rows)
            {
                BuilderTableColumn colum = new BuilderTableColumn();
                colum.ColumnName = row[0].ToString();//列名称
                if (row[3] != null)
                    colum.ColumnRemark = row[3].ToString();//备注信息
                colum.ColumnType = ConvertType(row[1].ToString());//数据类型
                colum.IsPrimary = int.Parse(row[4].ToString()) == 1 ? true : false;//是否是主键
                table.Add(colum);//添加列到表集合
            }
            return table;
        }
        /// <summary>
        /// 根据DataTable生成模板使用的对象
        /// </summary>
        /// <param name="dt">存储过程的数据集合</param>
        /// <returns>模板使用的对象</returns>
        public static BuilderStore GetParameterObject(DataTable dt)
        {
            BuilderStore store = new BuilderStore();
            store.StoreProcedureName = dt.TableName;

            List<BuilderParameter> parameter = new List<BuilderParameter>();
            foreach (DataRow row in dt.Rows)
            {
                BuilderParameter param = new BuilderParameter();
                param.ParamName = row["ParamName"].ToString().Replace("@", string.Empty);
                param.TypeName = ConvertType(row["TypeName"].ToString());
                param.ParamLeng = int.Parse(row["ParamLength"].ToString());
                param.isoutput = row["is_output"].ToString().ToUpper() == "TRUE" ? 1 : 0;
                parameter.Add(param);
            }
            store.AddParameterList(parameter);
            return store;
        }
        /// <summary>
        /// 数据源字段对应文件编辑接口
        /// </summary>
        private static Command.IDataBaseTypeEdit idatabasetype;
        /// <summary>
        /// 类型转换，将数据表的类型转换成托管类型
        /// </summary>
        /// <param name="columnstype">数据表类型</param>
        /// <returns>托管类型</returns>
        private static string ConvertType(string columnstype)
        {
            return (idatabasetype as Command.BaseDataTypeEdit).GetUnManagerType(columnstype);
        }

        #region Oracle
        private static BuilderTableBase GetBuilderObjectOracle(DataTable dt)
        {
            BuilderTableBase table = new BuilderTableBase(dt.TableName, "");
            foreach (DataRow row in dt.Rows)
            {
                BuilderTableColumn colum = new BuilderTableColumn();
                colum.ColumnName = row["COLUMN_NAME"].ToString();//列名称

                colum.ColumnType = ConvertType(row["DATA_TYPE"].ToString());//数据类型
                colum.IsPrimary = false;//是否是主键
                table.Add(colum);//添加列到表集合
            }
            return table;

        }
        private static BuilderStore GetParameterObjectOracle(DataTable dt)
        {
            BuilderStore store = new BuilderStore();
            store.StoreProcedureName = dt.TableName;

            List<BuilderParameter> parameter = new List<BuilderParameter>();
            foreach (DataRow row in dt.Rows)
            {
                BuilderParameter param = new BuilderParameter();
                param.ParamName = row["ARGUMENT_NAME"].ToString();
                param.TypeName = ConvertType(row["DATA_TYPE"].ToString());
                param.isoutput = row["IN_OUT"].ToString().ToUpper() == "IN" ? 1 : 0;
                parameter.Add(param);
            }
            store.AddParameterList(parameter);
            return store;

        }
        #endregion
    }
}
