using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Interface.ComeBaseModule
{
    /// <summary>
    /// 构件输出接口
    /// </summary>
    public interface OutInputInterface
    {
        /// <summary>
        /// 输出事件
        /// </summary>
        event Action<PlugEventArgs> OutHandler;
        /// <summary>
        /// 异常事件
        /// </summary>
        event Action<PlugEventArgs> ErrHandler;
    }
}
