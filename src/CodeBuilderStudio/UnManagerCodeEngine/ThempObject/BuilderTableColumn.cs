/*
 *author:南京.王清培
 *coding time:2011.9.5
 *copyright:快捷速递
 *function:对物理表的字段抽象。
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;

namespace UnManagerCodeEngine
{
    /// <summary>
    /// 物理表的字段抽象
    /// </summary>
    [Serializable]
    public class BuilderTableColumn : IDeserializationCallback, ISerializable
    {
        /// <summary>
        /// 列的名称
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        /// 列的数据类型
        /// </summary>
        public string ColumnType { get; set; }
        /// <summary>
        /// 列的备注说明信息
        /// </summary>
        public string ColumnRemark { get; set; }
        /// <summary>
        /// 是否是主键
        /// </summary>
        public bool IsPrimary { get; set; }

        #region ISerializable 成员
        /// <summary>
        /// 自定义序列化字段值
        /// </summary>
        /// <param name="info">上下文存储值</param>
        /// <param name="context">SerializationInfo的内部真正存储的上下文</param>
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ColumnName", ColumnName);
            info.AddValue("ColumnType", ColumnType);
            info.AddValue("ColumnRemark", ColumnRemark);
        }
        /// <summary>
        /// 反序列化构造函数
        /// </summary>
        /// <param name="info">上下文存储值</param>
        /// <param name="context">SerializationInfo的内部真正存储的上下文</param>
        protected void BuilderTabseColumn(SerializationInfo info, StreamingContext context)
        {
            ColumnName = info.GetValue("ColumnName", typeof(string)) as string;
            ColumnType = info.GetValue("ColumnType", typeof(string)) as string;
            ColumnRemark = info.GetValue("ColumnRemark", typeof(string)) as string;
        }
        #endregion

        #region IDeserializationCallback 成员

        public void OnDeserialization(object sender)
        {
            //
        }

        #endregion
    }
}