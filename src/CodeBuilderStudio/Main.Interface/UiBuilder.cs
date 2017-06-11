using System;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace Main.Interface
{
    /// <summary>
    /// UI界面生成构件的实现接口
    /// </summary>
    public interface UiBuilder
    {
        /// <summary>
        /// 构件启动事件，将构件内部的IDockContent对象封送到UI主界面中。
        /// </summary>
        event ComeBaseModule.OnExceptionHandler<IDockContent> StartUiBuilderFormDontent;
    }
}
