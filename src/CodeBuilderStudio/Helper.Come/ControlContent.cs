using System;
using System.Collections.Generic;
using System.Text;
using Main.Interface.ComeBaseModule;
using WeifenLuo.WinFormsUI.Docking;

namespace Helper.Come
{
    /// <summary>
    /// 继承构件基类，没有完全实现构件，继续向下传递实现；
    /// </summary>
    [Main.Interface.Attribute.WheTherNextTransfer(IfNextTransfer = false, ChildAssembly = "Helper.Come.Child1",
        ChildInterface = "Helper.Interface.NextComeInterface")]
    public class ControlContent : Main.Interface.ComeBaseModule.BaseCome, Main.Interface.Helper
    {
        public ControlContent() { }
        /// <summary>
        /// 重载构造函数，初始化构件的基本属性
        /// </summary>
        /// <param name="comename">构件名称</param>
        /// <param name="loadpath">构件的加载路径</param>
        /// <param name="time">装载时间</param>
        public ControlContent(string comename, string loadpath, DateTime time)
            : base(comename, loadpath, time) { }

        public override void StartCome() { }

        public override void Dispose() { }

        #region Helper 成员

        public void ShowHelperFrm(out WeifenLuo.WinFormsUI.Docking.IDockContent content)
        {
            content = new FrmThempSystemObject();
        }

        #endregion
    }
}
