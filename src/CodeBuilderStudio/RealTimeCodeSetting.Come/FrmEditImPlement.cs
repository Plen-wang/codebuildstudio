using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RealTimeCodeSetting.Come
{
    public partial class FrmEditImPlement : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FrmEditImPlement()
        {
            InitializeComponent();
            this.ucCodeView1.CodeText = @"using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;";
        }

        private void Tools_ref_Click(object sender, EventArgs e)
        {
            ScriptEngineKernel.FrmGacBrowser frmbrowsergac = new ScriptEngineKernel.FrmGacBrowser();
            frmbrowsergac.ShowDialog();
        }
    }
}
