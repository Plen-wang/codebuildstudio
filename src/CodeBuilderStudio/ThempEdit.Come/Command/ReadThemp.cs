using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ThempEdit.Come.Command
{
    /// <summary>
    /// 读取模板目录中的所有模板文件vm，并形成模板对象列表
    /// </summary>
    public class ReadThemp
    {
        /// <summary>
        /// 模板文件的路径字符串
        /// </summary>
        private string dirpath = string.Empty;
        /// <summary>
        /// 重载构造函数，通过模板文件路径构造所有模板文件对象
        /// </summary>
        /// <param name="editpath">模板文件路径</param>
        public ReadThemp(string editpath)
        {
            if (!Directory.Exists(editpath))
                //抛出构件内部异常，让PlugManager构件管理中心记录下来
                throw new Main.Interface.ComeBaseModule.ComeRestException("模板路径字符串不存在。", "模板编辑构件:ThempEdit.Come.dll");
            dirpath = editpath;
        }
        /// <summary>
        /// 获取模板文件列表
        /// </summary>
        /// <returns>模板文件列表对象</returns>
        public Module.M_EditDomCollection GetEditFileList()
        {
            Module.M_EditDomCollection filecollection = new ThempEdit.Come.Module.M_EditDomCollection();
            string[] files = Directory.GetFiles(dirpath, "*.vm", SearchOption.AllDirectories);
            foreach (string str in files)
            {
                Module.M_EditDom dom = new ThempEdit.Come.Module.M_EditDom();
                dom.filename = Path.GetFileNameWithoutExtension(str);
                dom.filepath = str;
                filecollection.Add(dom);
            }
            return filecollection;
        }
    }
}
