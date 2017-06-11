using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeBuilderStudio.Main
{
    public partial class FrmError : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private static FrmError _thisfrm;
        public static FrmError _Currentfrm
        {
            get
            {
                if (_thisfrm == null)
                    _thisfrm = new FrmError();
                return _thisfrm;
            }
        }
        private FrmError()
        {
            InitializeComponent();
            WinFrmLifecycleEvent.ErrFromShowInfo += new SingleParameterHandler<string>(WinFrmLifecycleEvent_ErrFromShowInfo);
            _thisfrm = this;
        }

        void WinFrmLifecycleEvent_ErrFromShowInfo(string t)
        {
            Action<string> writeinfo = (string info) =>
            {
                this.Activate();
                richTextBox1.AppendText("\n" + info);
            };
            this.Invoke(writeinfo, t);
        }
    }
}
