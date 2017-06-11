using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ThempEdit.Come
{
    public partial class FrmThempEditView : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        /// <summary>
        /// 打开源代码委托
        /// </summary>
        /// <param name="source"></param>
        public delegate void ReadSourceHander(ThempEditArgs<string> source);
        /// <summary>
        /// 打开源代码事件
        /// </summary>
        public event ReadSourceHander ReadSourceEvent;
        public ControlContent content;
        public FrmThempEditView(ControlContent con)
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmThempEditView_Load);
            this.ucCodeView1.P_Tools_save_Click += new EventHandler(ucCodeView1_P_Tools_save_Click);
            content = con;
        }

        private void ucCodeView1_P_Tools_save_Click(object sender, EventArgs e)
        {

        }
        Module.M_EditDomCollection coll;
        void FrmThempEditView_Load(object sender, EventArgs e)
        {
            try
            {
                Command.ReadThemp reader =
                    new ThempEdit.Come.Command.ReadThemp(System.Configuration.ConfigurationManager.AppSettings["CodeThempPath"]);
                coll = reader.GetEditFileList();
                Tools_filelist.Items.AddRange(coll.GetList);

                Tools_filelist.SelectedIndexChanged += new EventHandler(Tools_filelist_SelectedIndexChanged);

                UcEditMaster marster = new UcEditMaster();
                marster.Dock = DockStyle.Fill;
            }
            catch (Main.Interface.ComeBaseModule.ComeRestException err)
            {
                content.OnComeExceptionEvent(err);
            }
        }
        string filepath;
        void Tools_filelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThempEditArgs<string> args = new ThempEditArgs<string>(coll[Tools_filelist.SelectedIndex].filepath);
            ReadSourceEvent(args);//让主程序看见打开的文件目录
            //读取模板文件进行编辑

            string filename = Tools_filelist.SelectedItem.ToString() + ".vm";
            filepath = Path.Combine(System.Configuration.ConfigurationManager.AppSettings["CodeThempPath"] + "\\", filename);
            this.toolStripStatusLabel2.Text = filepath;//显示模板的读取路径
            using (FileStream filestream = File.Open(filepath, FileMode.Open, FileAccess.Read))//单独打开，不影响其他程序的操作
            {
                byte[] filebyte = new byte[filestream.Length];
                filestream.Read(filebyte, 0, filebyte.Length);
                StringBuilder code = new StringBuilder(Encoding.UTF8.GetString(filebyte));
                this.ucCodeView1.CodeText = code.ToString();
            }
        }
        //保存编辑的文件
        private void Tools_save_Click(object sender, EventArgs e)
        {
            if (filepath == null)
                return;
            if (filepath == string.Empty)
                return;
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Refresh();
            File.Delete(filepath);
            using (FileStream filestream = File.Open(filepath, FileMode.Create, FileAccess.Write))//单独打开，不影响其他程序的操作
            {
                byte[] strbyte = Encoding.UTF8.GetBytes(this.ucCodeView1.SaveCodeText);
                filestream.Write(strbyte, 0, strbyte.Length);
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void FrmThempEditView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                Tools_save_Click(null, null);
            }
        }

        private void Tools_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
