using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Interface.ComeBaseModule
{
    /// <summary>
    /// 事件参数抽象类
    /// </summary>
    public abstract class PlugEventArgs : System.EventArgs
    {
        /// <summary>
        /// 获取构件传递的参数
        /// </summary>
        /// <returns>T</returns>
        public abstract object GetArgs();
    }
}
