using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SingleBuilder.Come
{
    public partial class FrmStartUnManager : Form
    {
        #region 类变量及构造函数
        /// <summary>
        /// 生成成功事件
        /// </summary>
        public event EventHandler OnBuilderEvent;
        DataTable startdt;
        string filename;
        /// <summary>
        /// 重载构造函数，实现对主程序的表集合里表进行查找
        /// </summary>
        public FrmStartUnManager(Point location, DataTable dt, string vmname)
        {
            InitializeComponent();
            this.Location = location;
            startdt = dt;
            filename = vmname;//模板文件名称
        }
        #endregion

        #region 窗体事件
        private void FrmLookUp_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        bool ismove = false;
        Point islocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ismove = true;
            islocation = new Point(-e.X, -e.Y);
        }
        private void Btn_start_Click(object sender, EventArgs e)
        {
            this.Deactivate -= FrmLookUp_Deactivate;
            ControlContent isinglebuilder =
                 Main.Interface.ComeBaseModule.UnManagerObjectPolling.GetObjectByName<ControlContent>("controlcontent") as ControlContent;
            UnManagerCodeEngine.UnManager.DataSourceType datasource;
            if (isinglebuilder.BuilderSourceType == Main.Interface.DataSourceType.MicrosfotSqlServer)
                datasource = UnManagerCodeEngine.UnManager.DataSourceType.MsSqlServer;
            else
                datasource = UnManagerCodeEngine.UnManager.DataSourceType.Oracle;

            UnManagerCodeEngine.UnManager.BuilderCodeType codetype;
            if (comboBox1.SelectedIndex == 0)
                codetype = UnManagerCodeEngine.UnManager.BuilderCodeType.Table;
            else if (comboBox1.SelectedIndex == 1)
                codetype = UnManagerCodeEngine.UnManager.BuilderCodeType.Table;
            else
                codetype = UnManagerCodeEngine.UnManager.BuilderCodeType.Store;

            string codestr = UnManagerCodeEngine.UnManager.ProcessUnManager(filename, startdt, datasource, codetype);
            if (OnBuilderEvent != null)
                OnBuilderEvent(codestr, null);
            this.Close();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismove)
            {
                Point move = Control.MousePosition;
                move.Offset(islocation);
                this.Location = move;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ismove = false;
        }
        private void Lb_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Lb_close_MouseEnter(object sender, EventArgs e)
        {
            Lb_close.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Lb_close_MouseLeave(object sender, EventArgs e)
        {
            Lb_close.BorderStyle = BorderStyle.None;
        }
        #endregion


    }
}
