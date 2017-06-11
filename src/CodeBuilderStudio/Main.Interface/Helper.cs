using System;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace Main.Interface
{
    /// <summary>
    /// 系统帮助
    /// </summary>
    public interface Helper
    {
        /// <summary>
        /// 打开帮助窗口
        /// </summary>
        /// <param name="content">IDockContent对象</param>
        void ShowHelperFrm(out IDockContent content);
    }
}
