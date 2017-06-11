/*
 *author:南京.王清培
 *coding time:2011.10.19
 *copyright:快捷速递
 *function:数据库字段的对应关系编辑类
 */
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
    /// Microsoft SqlServer 数据类型编辑
    /// </summary>
    public class MsSqlServerDataTypeEdit : BaseDataTypeEdit
    {
        public MsSqlServerDataTypeEdit()
            : base(@"DataBaseTypeRef\MsSqlServer\SqlServerDataType.xml") { }

        IFormatter formatter = new BinaryFormatter();
        public override void Save()
        {
            if (File.Exists(@"DataBaseTypeRef\MsSqlServer\UnManagerType.Glory"))
                File.Delete(@"DataBaseTypeRef\MsSqlServer\UnManagerType.Glory");
            using (Stream stream = new FileStream(@"DataBaseTypeRef\MsSqlServer\UnManagerType.Glory", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, this.RefColumns);
            }
        }
        public override DataTable GetRef()
        {
            if (!File.Exists(@"DataBaseTypeRef\MsSqlServer\UnManagerType.Glory"))
            {
                this.RefColumns = new DataType_UnManagetType();
                return RefColumns._refdatatable;
            }
            using (Stream stream = new FileStream(@"DataBaseTypeRef\MsSqlServer\UnManagerType.Glory", FileMode.Open, FileAccess.Read))
            {
                this.RefColumns = (formatter.Deserialize(stream) as DataType_UnManagetType);
                return RefColumns._refdatatable;
            }
        }
    }
}
