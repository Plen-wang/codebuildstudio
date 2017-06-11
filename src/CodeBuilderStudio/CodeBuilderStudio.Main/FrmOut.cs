using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CodeBuilderStudio.Main
{
    public partial class FrmOut : DockContent
    {
        private static FrmOut _thisfrm;
        public static FrmOut _Currentfrm
        {
            get
            {
                if (_thisfrm == null)
                    _thisfrm = new FrmOut();
                return _thisfrm;
            }
        }
        private FrmOut()
        {
            InitializeComponent();
            WinFrmLifecycleEvent.OutFromShowInfo += new SingleParameterHandler<string>(WinFrmLifecycleEvent_OutFromShowInfo);
            _thisfrm = this;
        }

        void WinFrmLifecycleEvent_OutFromShowInfo(string t)
        {
            Action<string> writeinfo = (string info) =>
            {
                this.Activate();
                if (richTextBox1.Text.Trim().Length <= 0)
                    richTextBox1.AppendText("\n" + info);
                else
                    richTextBox1.AppendText(info);
            };
            this.Invoke(writeinfo, t);
        }
    }
}
