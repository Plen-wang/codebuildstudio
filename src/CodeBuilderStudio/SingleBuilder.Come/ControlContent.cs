/*
 *author:南京.王清培
 *coding time:2011.8.1
 *copyright:快捷速递
 *function:生成代码构件，实现Main.Interface.SingleBuilder接口
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SingleBuilder.Come
{
    /// <summary>
    /// 继承构件基类，没有完全实现构件，继续向下传递实现；
    /// </summary>
    [Main.Interface.Attribute.WheTherNextTransfer(IfNextTransfer = true, ChildAssembly = "SingleBuilder.Come.Childe1",
        ChildInterface = "SingleBuilder.Interface.NextComeInterface")]
    public class ControlContent : Main.Interface.ComeBaseModule.BaseCome, Main.Interface.SingleBuilder, Main.Interface.ComeInterfaceBase
    {
        public ControlContent() { }
        /// <summary>
        /// 重载构造函数，初始化构件的基本属性
        /// </summary>
        /// <param name="comename">构件名称</param>
        /// <param name="loadpath">构件的加载路径</param>
        /// <param name="time">装载时间</param>
        public ControlContent(string comename, string loadpath, DateTime time)
            : base(comename, loadpath, time)
        {
            this.SendFileDialog += new Main.Interface.OpenHandler<string>(ControlContent_SendFileDialog);
        }

        private void ControlContent_SendFileDialog(string t) { }

        #region SingleBuilder 成员
        private Main.Interface.BrowserSaveDirectoryHandler<Main.Interface.BrowserActivateType, object> DirectoryFrontEvent;
        public event Main.Interface.BrowserSaveDirectoryHandler<Main.Interface.BrowserActivateType, object> BrowserSaveDirectoryFrontEvent
        {
            add
            {
                if (DirectoryFrontEvent == null)
                    DirectoryFrontEvent += value;
            }
            remove
            {
                if (DirectoryFrontEvent != null)
                    DirectoryFrontEvent -= value;
            }
        }

        private Main.Interface.BrowserSaveDirectoryHandler<Main.Interface.BrowserActivateType, string> CallBackEvent;
        public event Main.Interface.BrowserSaveDirectoryHandler<Main.Interface.BrowserActivateType, string> BrowserSaveDirectoryCallBackEvent
        {
            add
            {
                if (CallBackEvent == null)
                    CallBackEvent += value;
            }
            remove
            {
                if (CallBackEvent != null)
                    CallBackEvent -= value;
            }
        }

        public Main.Interface.DataSourceType BuilderSourceType { get; set; }

        public void OpenSingleBuilderView(DataTable dt)
        {
            //方法的参数dt是要生成的表的列集合
            Main.Interface.ComeBaseModule.UnManagerObjectPolling.UnManagerObjectPollingTimeSpanEvent += new Main.Interface.ComeBaseModule.UnManagerObjectPollingHandler(UnManagerObjectPolling_UnManagerObjectPollingTimeSpanEvent);
            Main.Interface.ComeBaseModule.UnManagerObjectPolling.AddObject("controlcontent", this);//放入对象池
            FrmSingleBuilderView view = new FrmSingleBuilderView(dt);
            view.ShowDialog();
        }

        void UnManagerObjectPolling_UnManagerObjectPollingTimeSpanEvent(Dictionary<string, object> PrivateObjectPolling)
        {
            PrivateObjectPolling.Remove("controlcontent");
            PrivateObjectPolling.Add("controlcontent", this);
        }
        public void OnBrowserSaveDirectoryFrontEvent(object o)
        {
            if (DirectoryFrontEvent != null)
                DirectoryFrontEvent(o);
        }
        public void OnBrowserSaveDirectoryCallBackEvent(string path)
        {
            CallBackEvent(path);
        }
        #endregion

        #region BaseCome成员
        public override void StartCome() { }

        public override void Dispose() { }
        #endregion

        #region ComeInterfaceBase 成员

        private Main.Interface.OpenHandler<string> _openfiledialoghandler;

        public event Main.Interface.OpenHandler<string> OpenFileDialog
        {
            add
            {
                if (_openfiledialoghandler == null)
                    _openfiledialoghandler += value;
            }
            remove
            {
                if (_openfiledialoghandler != null)
                    _openfiledialoghandler -= value;
            }
        }

        public event Main.Interface.OpenHandler<string> SendFileDialog;

        public void OnOpenFileDialog()
        {
            if (_openfiledialoghandler != null)
                if (_openfiledialoghandler.GetInvocationList().Length == 1)
                    _openfiledialoghandler.Invoke(string.Empty);
        }
        public void OnSendFileDialog(string sendstring)
        {
            SendFileDialog(sendstring);
        }

        #endregion

        #region ComeInterfaceBase 成员
        public event Main.Interface.ShowFrmHandler<Main.Interface.ComeBaseModule.PlugEventArgs> ShowFrmEvent;

        #endregion

        #region SingleBuilder 成员
        public List<string> CurrentDataTableSource { get; set; }
        public void OpenMuilterSingleBuilderFrm()
        {
            FrmMuilterSingleBuilder frmbuilder = new FrmMuilterSingleBuilder();
            if (CurrentDataTableSource == null)
            {
                frmbuilder.ShowDialog();
                return;
            }
            else
                frmbuilder = new FrmMuilterSingleBuilder(CurrentDataTableSource, this);
            frmbuilder.ShowDialog();
        }
        #endregion

        #region SingleBuilder 成员
        public event Main.Interface.BrowserSaveDirectoryHandler<Main.Interface.BrowserActivateType, StringBuilder> BrowserSaveFolder;
        public Main.Interface.DataSourceOpen CurrentDataSource { get; set; }
        public void OpenFolderBrowserDialog(StringBuilder path)
        {
            BrowserSaveFolder(path);
        }

        #endregion

        #region ComeBaseModule.OutInputInterface接口
        private Action<Main.Interface.ComeBaseModule.PlugEventArgs> _outhandler;
        public event Action<Main.Interface.ComeBaseModule.PlugEventArgs> OutHandler
        {
            add
            {
                if (_outhandler == null)
                    _outhandler += value;
            }
            remove
            {
                if (_outhandler != null)
                    _outhandler -= value;
            }
        }
        public void OnOutHandler(string outinfo)
        {
            _outhandler(new ComePlugEventArgs() { EventArgs = outinfo });//传递参数到控制中心
        }

        private Action<Main.Interface.ComeBaseModule.PlugEventArgs> _errhandler;
        public event Action<Main.Interface.ComeBaseModule.PlugEventArgs> ErrHandler
        {
            add
            {
                if (_errhandler == null)
                    _errhandler += value;
            }
            remove
            {
                if (_errhandler != null)
                    _errhandler -= value;
            }
        }
        public void OnErrHandler(string errinfo)
        {
            _errhandler(new ComePlugEventArgs() { EventArgs = errinfo });
        }
        #endregion
    }
    public class ComePlugEventArgs : Main.Interface.ComeBaseModule.PlugEventArgs
    {
        public string EventArgs { get; set; }
        public override object GetArgs()
        {
            return EventArgs;
        }
    }
}
