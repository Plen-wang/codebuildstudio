/*
 *author:南京.王清培
 *coding time:2011.9.5
 *copyright:快捷速递
 *function:对物理表的抽象，利用模板生成代码时需要将表的各种信息插入进去。
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
    /// 物理表的抽象
    /// </summary>
    [Serializable]
    public class BuilderTableBase : IDeserializationCallback, ISerializable
    {
        /// <summary>
        /// 表的名称
        /// </summary>
        public string TbName { get; set; }
        /// <summary>
        /// 表的备注信息
        /// </summary>
        public string TbRemark { get; set; }
        /// <summary>
        /// 列字段
        /// </summary>
        public IList<BuilderTableColumn> _columns;
        public IList<BuilderTableColumn> Columns
        {
            get { return _columns; }
        }
        /// <summary>
        /// 利用表的名称、说明信息构造抽象对象
        /// </summary>
        /// <param name="name">表的名称</param>
        /// <param name="remark">备注信息</param>
        public BuilderTableBase(string name, string remark)
        {
            TbName = name;
            TbRemark = remark;
            _columns = new List<BuilderTableColumn>();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="column">UnManagerCodeEngine.BuilderTableColumn物理表抽象</param>
        public void Add(BuilderTableColumn column)
        {
            Columns.Add(column);
        }

        #region ISerializable 成员
        /// <summary>
        /// 自定义序列化字段值
        /// </summary>
        /// <param name="info">上下文存储值</param>
        /// <param name="context">SerializationInfo的内部真正存储的上下文</param>
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("TbName", TbName);
            info.AddValue("TbRemark", TbRemark);
        }
        /// <summary>
        /// 反序列化构造函数
        /// </summary>
        /// <param name="info">上下文存储值</param>
        /// <param name="context">SerializationInfo的内部真正存储的上下文</param>
        protected BuilderTableBase(SerializationInfo info, StreamingContext context)
        {
            TbName = info.GetValue("TbName", typeof(string)) as string;
            TbRemark = info.GetValue("TbRemark", typeof(string)) as string;
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
