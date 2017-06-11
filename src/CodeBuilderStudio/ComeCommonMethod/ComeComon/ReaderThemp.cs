using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;

namespace ComeCommonMethod.ComeComon
{
    public class ReaderThemp
    {
        public ReaderThemp() { }
        /// <summary>
        /// 重载构造函数，使用bool类型确定是否需要完整路径，还是仅是文件名称。
        /// </summary>
        /// <param name="ispath">true:完整路径，false文件名</param>
        public ReaderThemp(bool ispath) { _ispathfile = ispath; }
        private bool _ispathfile = true;
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
            if (!_ispathfile)
            {
                for (int i = 0; i < themlist.Length; i++)
                {
                    themlist[i] = Path.GetFileNameWithoutExtension(themlist[i]);
                }
            }
            return themlist;
        }
    }
}
