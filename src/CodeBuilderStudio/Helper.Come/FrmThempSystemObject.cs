using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Helper.Come
{
    public partial class FrmThempSystemObject : DockContent
    {
        public FrmThempSystemObject()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Node.Name == "CurrentDayTime")
                    this.ucCodeView1.CodeText = SystemHelperInfo.Default.CurrentDayTime;
                else if (e.Node.Name == "DefaultNameSpace")
                    this.ucCodeView1.CodeText = SystemHelperInfo.Default.DefaultNameSpace;
            }
        }
    }
}
