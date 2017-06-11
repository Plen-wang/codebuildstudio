using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;

namespace OpenProject.Come
{
    public partial class FrmCodePage : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FrmCodePage(string name, string code)
        {
            InitializeComponent();
            this.Text = Path.GetFileName(name);
            this.uccodeview.CodeText = code;
            this.uccodeview.P_Tools_save_Click += new EventHandler(uccodeview_P_Tools_save_Click);
            filepath = name;
        }
        private string filepath;
        void uccodeview_P_Tools_save_Click(object sender, EventArgs e)
        {
            if (filepath == null)
                return;
            if (filepath == string.Empty)
                return;
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Refresh();
            using (FileStream filestream = File.OpenWrite(filepath))
            {
                byte[] strbyte = Encoding.UTF8.GetBytes(this.uccodeview.SaveCodeText);
                filestream.SetLength(0L);
                filestream.Write(strbyte, 0, strbyte.Length);
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void Tools_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
