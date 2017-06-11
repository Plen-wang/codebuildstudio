/*
 *author:南京.王清培
 *coding time:2011.9.10
 *copyright:江苏华招网信息技术有限公司
 *function:关于构件
 */
using System;
using System.Collections.Generic;
using System.Text;
using Main.Interface.ComeBaseModule;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace About.Come
{
    /// <summary>
    /// 继承构件基类，没有完全实现构件，继续向下传递实现；
    /// </summary>
    [Main.Interface.Attribute.WheTherNextTransfer(IfNextTransfer = true, ChildAssembly = "OpenProject.Come.Childe1",
        ChildInterface = "OpenProject.Interface.NextComeInterface")]
    public class ControlContent : BaseCome, Main.Interface.About
    {
        public ControlContent() { }
        /// <summary>
        /// 重载构造函数，初始化构件的基本属性
        /// </summary>
        /// <param name="comename">构件名称</param>
        /// <param name="loadpath">构件的加载路径</param>
        /// <param name="time">装载时间</param>
        public ControlContent(string comename, string loadpath, DateTime time) : base(comename, loadpath, time) { }

        public override void StartCome() { }

        public override void Dispose() { }

        #region About 成员

        public void ShowAboutFrm()
        {
            FrmAbout frmabout = new FrmAbout();
            frmabout.ShowDialog();
        }

        #endregion
    }
}
