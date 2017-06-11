using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CodeBuilderStudio.Main
{
    public partial class FrmStartPage : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private static FrmStartPage _thisfrm;
        public static FrmStartPage _Currentfrm
        {
            get
            {
                if (_thisfrm == null)
                    _thisfrm = new FrmStartPage();
                return _thisfrm;
            }
        }
        private FrmStartPage()
        {
            InitializeComponent();
            _thisfrm = this;
        }

        private void Tools_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer", "http://www.cnblogs.com/wangiqngpei557/");
        }
    }
}
