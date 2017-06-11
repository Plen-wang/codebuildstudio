using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Data;
using System.IO;

namespace UnManagerCodeEngine.Command
{
    /// <summary>
    /// Oracle数据库类型映射
    /// </summary>
    public class StoreOracleDataTypeEdit : BaseDataTypeEdit
    {
        public StoreOracleDataTypeEdit()
            : base(@"StoreTypeRef\Oracle\OracleDataType.xml") { }

        IFormatter formatter = new BinaryFormatter();
        public override void Save()
        {
            if (File.Exists(@"StoreTypeRef\Oracle\OracleDataType.Glory"))
                File.Delete(@"StoreTypeRef\Oracle\OracleDataType.Glory");
            using (Stream stream = new FileStream(@"StoreTypeRef\Oracle\OracleDataType.Glory", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, this.RefColumns);
            }
        }
        public override DataTable GetRef()
        {
            if (!File.Exists(@"StoreTypeRef\Oracle\OracleDataType.Glory"))
            {
                this.RefColumns = new DataType_UnManagetType();
                return RefColumns._refdatatable;
            }
            using (Stream stream = new FileStream(@"StoreTypeRef\Oracle\OracleDataType.Glory", FileMode.Open, FileAccess.Read))
            {
                this.RefColumns = (formatter.Deserialize(stream) as DataType_UnManagetType);
                return RefColumns._refdatatable;
            }
        }
        public override string GetUnManagerType(string datatype)
        {
            if (RefColumns != null)
            {
                foreach (DataRow row in RefColumns._refdatatable.Rows)
                {
                    if (row["DataType"].ToString() == datatype)
                        return row["UnmanagerType"].ToString();
                }
            }
            return "DbType.Object";//返回通用数据类型
        }
    }
}
