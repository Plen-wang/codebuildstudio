using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEngineKernel
{
    public partial class FrmGacBrowser : Form
    {
        public FrmGacBrowser()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmGacBrowser_Load);
        }

        void FrmGacBrowser_Load(object sender, EventArgs e)
        {
            DotNetAssemblyInfoCollection assemblylist = DotNetAssemblyInfoCollection.GacAssemblyInfoCollection;
            if (assemblylist == null)
                return;

        }
    }
}
