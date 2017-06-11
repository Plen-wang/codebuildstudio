/*
 *author:南京.王清培
 *coding time:2011.8.13
 *copyright:快捷速递
 *function:生成代码构件，实现Main.Interface.SingleBuilder接口
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;

namespace ThempEdit.Come
{
    /// <summary>
    /// 继承构件基类，没有完全实现构件，继续向下传递实现；
    /// </summary>
    [Main.Interface.Attribute.WheTherNextTransfer(IfNextTransfer = true, ChildAssembly = "SingleBuilder.Come.Childe1",
        ChildInterface = "SingleBuilder.Interface.NextComeInterface")]
    public class ControlContent : Main.Interface.ComeBaseModule.BaseCome, Main.Interface.ThempEdit, Main.Interface.ComeBaseModule.OutInputInterface
    {
        public ControlContent() { }
        /// <summary>
        /// 重载构造函数，初始化构件的基本属性
        /// </summary>
        /// <param name="comename">构件名称</param>
        /// <param name="loadpath">构件的加载路径</param>
        /// <param name="time">装载时间</param>
        public ControlContent(string comename, string loadpath, DateTime time) : base(comename, loadpath, time) { }

        #region BaseCome成员
        public override void StartCome() { }

        public override void Dispose() { }
        #endregion

        #region ThempEdit 成员
        private Main.Interface.ParameterHander<Main.Interface.ThempEdit, Main.Interface.ComeBaseModule.PlugEventArgs> _openeditviewevent;
        public event Main.Interface.ParameterHander<Main.Interface.ThempEdit, Main.Interface.ComeBaseModule.PlugEventArgs> OpenEditViewEvent
        {
            add
            {
                if (_openeditviewevent == null)
                    _openeditviewevent += value;
            }
            remove
            {
                if (_openeditviewevent != null)
                    _openeditviewevent -= value;
            }
        }

        private Main.Interface.ParameterHander<Main.Interface.ThempEdit, Main.Interface.ComeBaseModule.PlugEventArgs> _openeditcondeevent;
        public event Main.Interface.ParameterHander<Main.Interface.ThempEdit, Main.Interface.ComeBaseModule.PlugEventArgs> OpenEditCodeEvent
        {
            add
            {
                if (_openeditcondeevent == null)
                    _openeditcondeevent += value;
            }
            remove
            {
                if (_openeditcondeevent != null)
                    _openeditcondeevent -= value;
            }
        }

        private Main.Interface.ParameterHander<Main.Interface.ThempEdit, Main.Interface.ComeBaseModule.PlugEventArgs> _showdemoevent;
        public event Main.Interface.ParameterHander<Main.Interface.ThempEdit, Main.Interface.ComeBaseModule.PlugEventArgs> ShowDemoEvent
        {
            add
            {
                if (_showdemoevent == null)
                    _showdemoevent += value;
            }
            remove
            {
                if (_showdemoevent != null)
                    _showdemoevent -= value;
            }
        }

        private object OpenEdieView()
        {
            try
            {
                Main.Interface.ComeBaseModule.UnManagerObjectPolling.AddObject("controlcontent", this, true);
                FrmThempEditView editview = new FrmThempEditView(this);
                editview.FormClosed += new System.Windows.Forms.FormClosedEventHandler(editview_FormClosed);
                editview.ReadSourceEvent += new FrmThempEditView.ReadSourceHander(editview_ReadSourceEvent);
                ThempEditArgs<WeifenLuo.WinFormsUI.Docking.DockContent> args = new ThempEditArgs<WeifenLuo.WinFormsUI.Docking.DockContent>(editview);
                return args;
            }
            catch (Main.Interface.ComeBaseModule.ComeRestException err)
            {
                base.OnComeExceptionEvent(err);//统一记录构件内部处理错误
                return null;
            }
        }
        void editview_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Main.Interface.ComeBaseModule.UnManagerObjectPolling.DeleteObejct("controlcontent");
        }

        public void OnShowDemoEvent(Main.Interface.ComeBaseModule.PlugEventArgs arg)
        {
            _showdemoevent(null, arg);
        }

        void editview_ReadSourceEvent(ThempEditArgs<string> source)
        {
            _openeditcondeevent(this, source);
        }

        void Main.Interface.ThempEdit.SynchInvoke(WindowsFormsSynchronizationContext winformcontext, SendOrPostCallback callbackmethod)
        {
            object result = OpenEdieView();
            //客户端可以通过捕获事件来拿到对象，消除调用和设置之间的耦合
            _openeditviewevent(this, (result as Main.Interface.ComeBaseModule.PlugEventArgs));
            winformcontext.Post(callbackmethod, null);
        }
        #endregion

        #region ISynchronizeInvoke 成员
        public delegate object OpenEditViewHandle();
        public OpenEditViewHandle OpenEditDelegate;

        public Delegate RemotingMethodDelegate;
        public IAsyncResult BeginInvoke(Delegate method, object[] args)
        {
            OpenEditDelegate = new OpenEditViewHandle(OpenEdieView);
            RemotingMethodDelegate = method;//回调委托
            return OpenEditDelegate.BeginInvoke(new AsyncCallback(CallBackMethod), null);
        }

        public object EndInvoke(IAsyncResult result)
        {
            result.AsyncWaitHandle.WaitOne();
            return ((result as AsyncResult).AsyncDelegate as OpenEditViewHandle).EndInvoke(result);
        }

        public object Invoke(Delegate method, object[] args)
        {
            object result = OpenEdieView();
            RemotingMethodDelegate = method;
            //客户端可以通过捕获事件来拿到对象，消除调用和设置之间的耦合
            _openeditviewevent(this, (result as Main.Interface.ComeBaseModule.PlugEventArgs));
            return result;
        }

        public bool InvokeRequired//可以提供Invoke同步调用
        {
            get { return false; }
        }
        public void CallBackMethod(IAsyncResult IAsyncObejct)
        {
            object callbackresult = ((IAsyncObejct as AsyncResult).AsyncDelegate as OpenEditViewHandle).EndInvoke(IAsyncObejct);
            RemotingMethodDelegate.DynamicInvoke(IAsyncObejct, callbackresult);//动态调用后期绑定的派生委托
        }
        #endregion

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
    }
}
