using System;
using System.Collections.Generic;
using System.Text;

namespace RealTimeCodeSetting.Come
{
    public class ControlContent : Main.Interface.ComeBaseModule.BaseCome, Main.Interface.RealTimeCodeSetting
    {
        public ControlContent() { }
        /// <summary>
        /// 重载构造函数，初始化构件的基本属性
        /// </summary>
        /// <param name="comename">构件名称</param>
        /// <param name="loadpath">构件的加载路径</param>
        /// <param name="time">装载时间</param>
        public ControlContent(string comename, string loadpath, DateTime time) : base(comename, loadpath, time) { }

        //同步方法
        public override void StartCome()
        {
            FrmEditImPlement frm = new FrmEditImPlement();
            PlugArg arg = new PlugArg(frm);
            _showfrmevent(arg);//送往前台展现
        }

        public override void Dispose() { }

        #region ComeInterfaceBase 成员
        private Main.Interface.OpenHandler<string> _openfiledialog;
        public event Main.Interface.OpenHandler<string> OpenFileDialog
        {
            add
            {
                if (_openfiledialog == null)
                    _openfiledialog += value;
            }
            remove
            {
                if (_openfiledialog != null)
                    _openfiledialog -= value;
            }
        }
        private Main.Interface.OpenHandler<string> _sendfiledialog;
        public event Main.Interface.OpenHandler<string> SendFileDialog
        {
            add
            {
                if (_sendfiledialog == null)
                    _sendfiledialog += value;
            }
            remove
            {
                if (_sendfiledialog != null)
                    _sendfiledialog -= value;
            }
        }
        private Main.Interface.ShowFrmHandler<Main.Interface.ComeBaseModule.PlugEventArgs> _showfrmevent;
        public event Main.Interface.ShowFrmHandler<Main.Interface.ComeBaseModule.PlugEventArgs> ShowFrmEvent
        {
            add
            {
                if (_showfrmevent == null)
                    _showfrmevent += value;
            }
            remove
            {
                if (_showfrmevent != null)
                    _showfrmevent -= value;
            }
        }

        public void OnSendFileDialog(string sendstring)
        {

        }

        public void OnOpenFileDialog()
        {

        }

        #endregion

        #region RealTimeCodeSetting 成员
        //异步方法
        public void SynchInvoke(System.Windows.Forms.WindowsFormsSynchronizationContext synccontext, System.Threading.SendOrPostCallback callback)
        {
            FrmEditImPlement frm = new FrmEditImPlement();
            PlugArg arg = new PlugArg(frm);
            _showfrmevent(arg);//送往前台展现
            synccontext.Post(callback, null);
        }

        #endregion
    }
}
