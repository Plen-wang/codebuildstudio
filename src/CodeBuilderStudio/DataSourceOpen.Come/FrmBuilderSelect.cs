using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataSourceOpen.Come
{
    public partial class FrmBuilderSelect : Form
    {
        #region 类变量及构造函数
        ControlContent content;
        public FrmBuilderSelect(Point location, ControlContent c)
        {
            InitializeComponent();
            this.Location = location;
            content = c;
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

        private void Btn_buildersele_Click(object sender, EventArgs e)
        {
            this.Deactivate -= FrmLookUp_Deactivate;//将关闭方法从委托链中移除
            if (content.CurrentSourceType == Main.Interface.DataSourceType.MicrosfotSqlServer)
                content.OnOpenSingleBuilderViewEvent(
                    Command.DataSourceCommand.GetTableColumnsInfo(content.ConnectionString.ToString(), Lb_tbname.Text));
            else
                content.OnOpenSingleBuilderViewEvent(
                   Command.OracleCommand.DataSourceCommand.GetTableColumnsInfo(content.ConnectionString.ToString(), Lb_tbname.Text));
            this.Close();
        }
    }
}
