using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SingleBuilder.Come
{
    public partial class FrmSingleBuilderView : Form
    {
        DataTable builderdt;
        public FrmSingleBuilderView(DataTable dt)
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmSingleBuilderView_Load);
            this.FormClosed += new FormClosedEventHandler(FrmSingleBuilderView_FormClosed);
            this.ucCodeView1.P_Tools_save_Click += new EventHandler(ucCodeView1_P_Tools_save_Click);
            builderdt = dt;
        }

        void FrmSingleBuilderView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (controlcontent != null)
                controlcontent.BrowserSaveDirectoryCallBackEvent -= controlcontent_BrowserSaveDirectoryCallBackEvent;//避免循环引用
        }
        ControlContent controlcontent;
        void ucCodeView1_P_Tools_save_Click(object sender, EventArgs e)
        {
            controlcontent =
               Main.Interface.ComeBaseModule.UnManagerObjectPolling.GetObjectByName<ControlContent>("controlcontent") as ControlContent;
            Main.Interface.ComeBaseModule.UnManagerObjectPolling.DeleteObejct("controlcontent");//从池中删除对象的引用关系
            controlcontent.BrowserSaveDirectoryCallBackEvent +=
                new Main.Interface.BrowserSaveDirectoryHandler<Main.Interface.BrowserActivateType, string>(controlcontent_BrowserSaveDirectoryCallBackEvent);
            controlcontent.OnBrowserSaveDirectoryFrontEvent(null);
        }

        void controlcontent_BrowserSaveDirectoryCallBackEvent(string u)
        {
            if (File.Exists(u + "\\" + builderdt.TableName + ".cs"))
                File.Delete(u + "\\" + builderdt.TableName + ".cs");
            using (FileStream stream = File.Open(u + "\\" + builderdt.TableName + ".cs", FileMode.Create, FileAccess.Write))
            {
                byte[] builbyte = Encoding.UTF8.GetBytes(ucCodeView1.SaveCodeText);
                stream.Write(builbyte, 0, builbyte.Length);
                MessageBox.Show(this, "保存成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        Command.ReaderThemp readerthemp = new SingleBuilder.Come.Command.ReaderThemp();
        void FrmSingleBuilderView_Load(object sender, EventArgs e)
        {
            string[] themplist = readerthemp.GetThempList();
            foreach (string str in themplist)
            {
                lv_themplist.Items.Add(Path.GetFileNameWithoutExtension(str));
            }
        }

        private void lv_themplist_DoubleClick(object sender, EventArgs e)
        {
            if (lv_themplist.SelectedItems.Count <= 0)
                return;
            FrmStartUnManager frmstart = new FrmStartUnManager(
                Control.MousePosition, builderdt, lv_themplist.SelectedItems[0].Text + ".vm");
            frmstart.OnBuilderEvent += new EventHandler(frmstart_OnBuilderEvent);
            frmstart.Show();
        }

        void frmstart_OnBuilderEvent(object sender, EventArgs e)
        {
            ucCodeView1.CodeText = (sender as string);
        }

    }
}
