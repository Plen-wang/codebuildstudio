using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Main.Interface
{
    /// <summary>
    /// 实时代码交互环境，也叫脚本引擎。
    /// </summary>
    public interface RealTimeCodeSetting : ComeInterfaceBase
    {
        /// <summary>
        /// 异步打开窗口
        /// </summary>
        /// <param name="synccontext">WindowsFormsSynchronizationContext同步上下文</param>
        /// <param name="callback">SendOrPostCallback回调委托</param>
        void SynchInvoke(WindowsFormsSynchronizationContext synccontext, SendOrPostCallback callback);
    }
}
