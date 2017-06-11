using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace UnManagerCodeEngine.Command
{
    /// <summary>
    /// 数据库类型文件编辑接口
    /// </summary>
    public interface IDataBaseTypeEdit
    {
        /// <summary>
        /// 添加数据类型
        /// </summary>
        /// <param name="name">类型名称</param>
        void Add(string name);
        /// <summary>
        /// 获取数据对应关系
        /// </summary>
        /// <returns></returns>
        DataTable GetRef();
        /// <summary>
        /// 集中更新数据源
        /// </summary>
        void Update();
        /// <summary>
        /// 获取对应关系，托管类型
        /// </summary>
        /// <param name="datatype"></param>
        /// <returns></returns>
        string GetUnManagerType(string datatype);
        /// <summary>
        /// 保存
        /// </summary>
        void Save();
    }
}
