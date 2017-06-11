using System;
using System.Collections.Generic;
using System.Text;

namespace ThempEdit.Come
{
    /// <summary>
    /// 构件事件参数对象
    /// </summary>
    public class ThempEditArgs<T> : Main.Interface.ComeBaseModule.PlugEventArgs
    {
        private T thiscontent;
        public ThempEditArgs(T content)
        {
            thiscontent = content;
        }
        public override object GetArgs()
        {
            return thiscontent;
        }
    }
}