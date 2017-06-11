using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeBuilderStudio.Main
{
    public partial class FrmPropertyInfo : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private static FrmPropertyInfo _thisfrm;
        public static FrmPropertyInfo _Currentfrm
        {
            get
            {
                if (_thisfrm == null)
                    _thisfrm = new FrmPropertyInfo();
                return _thisfrm;
            }
        }
        private FrmPropertyInfo()
        {
            InitializeComponent();
            _thisfrm = this;
            WinFrmLifecycleEvent.DispalyProjectInfoEvent += new DisplayProjectInfoHandler(WinFrmLifecycleEvent_DispalyProjectInfoEvent);
        }

        void WinFrmLifecycleEvent_DispalyProjectInfoEvent(object displayobject)
        {
            this.propertyGrid1.SelectedObject = displayobject;
        }
    }
}
