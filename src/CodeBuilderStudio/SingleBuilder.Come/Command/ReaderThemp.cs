using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;

namespace SingleBuilder.Come.Command
{
    /// <summary>
    /// 读取模板文件
    /// </summary>
    public class ReaderThemp
    {
        public ReaderThemp() { }
        /// <summary>
        /// 模板文件列表
        /// </summary>
        private string themppath = string.Empty;
        /// <summary>
        /// 获取模板文件根目录
        /// </summary>
        public string ThempPath
        {
            get { return themppath; }
        }
        /// <summary>
        /// 获取模板文件列表
        /// </summary>
        /// <returns>文件列表</returns>
        public string[] GetThempList()
        {
            themppath = System.Configuration.ConfigurationManager.AppSettings["CodeThempPath"];
            if (!Directory.Exists(themppath))
                throw new Main.Interface.ComeBaseModule.ComeRestException("模板路径字符串不存在", "模板编辑构件:SingleBuilder.Come.dll");
            string[] themlist = Directory.GetFiles(themppath, "*.vm");
            return themlist;
        }
    }
}
