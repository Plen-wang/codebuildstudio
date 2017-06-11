using System;
using System.Collections.Generic;
using System.Text;

namespace RealTimeCodeSetting.Come
{
    public class PlugArg : Main.Interface.ComeBaseModule.PlugEventArgs
    {
        public PlugArg(WeifenLuo.WinFormsUI.Docking.DockContent dock)
        {
            dockcontent = dock;
        }
        private WeifenLuo.WinFormsUI.Docking.DockContent dockcontent;
        public override object GetArgs()
        {
            return dockcontent;
        }
    }
}
