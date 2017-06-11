using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ThempEdit.Come.Module
{
    /// <summary>
    /// 模板文件对象
    /// </summary>
    public class M_EditDom
    {
        /// <summary>
        /// 模板文件的名称
        /// </summary>
        public string filename { get; set; }
        /// <summary>
        /// 模板文件的路径
        /// </summary>
        public string filepath { get; set; }
        /// <summary>
        /// 打开该对象引用的模板文件
        /// </summary>
        /// <returns>读取的内容</returns>
        public StringBuilder OpenFile()
        {
            return null;
        }

    }
}
