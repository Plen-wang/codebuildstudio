/*
 *author:南京.王清培
 *coding time:2011.10.19
 *copyright:快捷速递
 *function:数据库字段的对应关系编辑类的抽象类
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;

namespace UnManagerCodeEngine.Command
{
    /// <summary>
    /// IDataBaseTypeEidt接口部分实现，用来完成数据库对应的基类实现。
    /// </summary>
    public abstract class BaseDataTypeEdit : IDataBaseTypeEdit
    {
        public BaseDataTypeEdit(string Xmlpath)
        {
            XmlNodeList list = ComeCommonMethod.XmlFunction.GetElementList(Xmlpath, "DataTypeName/Name");
            for (int i = 0; i < list.Count; i++)
            {
                ElementList.Add(new DataBaseTypeElement() { ColumnName = list[i].InnerText });
            }
        }
        /// <summary>
        /// 表示数据库中的字段类型实体
        /// </summary>
        public class DataBaseTypeElement
        {
            public string ColumnName { get; set; }
        }
        List<DataBaseTypeElement> ElementList = new List<DataBaseTypeElement>();
        /// <summary>
        /// 获取指定数据类型的字段集合
        /// </summary>
        /// <returns></returns>
        public List<DataBaseTypeElement> GetColumnList()
        {
            return ElementList;
        }
        /// <summary>
        /// 数据库对象与托管对象的对应实体
        /// </summary>
        [Serializable]
        public class DataType_UnManagetType
        {
            public DataTable _refdatatable = new DataTable();
            public DataType_UnManagetType()
            {
                _refdatatable.Columns.Add("DataType", typeof(string));
                _refdatatable.Columns.Add("UnmanagerType", typeof(string));
                _refdatatable.Columns.Add("Remark", typeof(string));
            }
        }

        protected DataType_UnManagetType RefColumns;

        public virtual void Add(string name) { }

        public abstract DataTable GetRef();

        public virtual void Update() { }

        public virtual string GetUnManagerType(string datatype)
        {
            if (RefColumns != null)
            {
                foreach (DataRow row in RefColumns._refdatatable.Rows)
                {
                    if (row["DataType"].ToString() == datatype)
                        return row["UnmanagerType"].ToString();
                }
            }
            return "object";//返回通用数据类型
        }

        public virtual void Save() { }

    }
}
