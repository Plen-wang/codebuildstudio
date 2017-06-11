using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Main.Interface;
using Main.Interface.ComeBaseModule;
using Main.Interface.ComeStartInterface;

namespace UiBuilder.Come
{
    /// <summary>
    /// UI生成构件入口控制点
    /// </summary>
    public class ControlContent : BaseCome, Main.Interface.UiBuilder
    {
        public ControlContent() { }
        public ControlContent(string comename, string loadpath, DateTime time)
            : base(comename, loadpath, time) { }

        #region BaseCome 成员
        public override void StartCome()
        {
            FrmUiBuilder uifrm = new FrmUiBuilder();
            if (_startUiBuilderFormDontent != null)
                _startUiBuilderFormDontent(uifrm);
        }
        public override void Dispose() { }
        #endregion

        #region UiBuilder 成员
        private OnExceptionHandler<WeifenLuo.WinFormsUI.Docking.IDockContent> _startUiBuilderFormDontent;
        public event OnExceptionHandler<WeifenLuo.WinFormsUI.Docking.IDockContent> StartUiBuilderFormDontent
        {
            add
            {
                if (_startUiBuilderFormDontent == null)
                    _startUiBuilderFormDontent += value;
            }
            remove
            {
                if (_startUiBuilderFormDontent != null)
                    _startUiBuilderFormDontent -= value;
            }
        }

        #endregion
    }
}
