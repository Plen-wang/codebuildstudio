using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataSourceOpen.Come
{
    public partial class ControlTableView : UserControl
    {
        public string thistbname = string.Empty;
        public string thisconnstring = string.Empty;
        ControlContent thiscontent;
        /// <summary>
        /// 初始化表结构视图
        /// </summary>
        /// <param name="tbname">表的名称</param>
        /// <param name="connstring">数据源连接</param>
        public ControlTableView(string tbname, string connstring, ControlContent c)
        {
            InitializeComponent();
            this.Load += new EventHandler(TableView_Load);
            thistbname = tbname;
            thisconnstring = connstring;
            if (tbname.Length > 20)
                tbname = tbname.Substring(0, 15) + "...";
            Lb_tbname.Text = tbname;
            thiscontent = c;
        }
        Color c;
        void TableView_Load(object sender, EventArgs e)
        {
            List<Module.M_Column> dsmodule = new List<Module.M_Column>();
            if (thiscontent.CurrentSourceType == Main.Interface.DataSourceType.MicrosfotSqlServer)
                dsmodule = Command.DataSourceCommand.GetTableColumnList(thisconnstring, thistbname);
            else if (thiscontent.CurrentSourceType == Main.Interface.DataSourceType.Oracle)
                dsmodule = Command.OracleCommand.DataSourceCommand.GetTableColumnList(thisconnstring, thistbname);
            if (dsmodule == null)
                return;
            dataGridView1.DataSource = dsmodule;
            c = panel1.BackColor;//记录控件的原始颜色
            Tb_count.Text = "共" + dsmodule.Count + "列";
        }

        #region 控件移动事件
        bool ismove = false;
        Point islocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.BringToFront();
            SetActivatedControlColor(c);

            ismove = true;
            islocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismove)
            {
                Point newmove = this.Parent.PointToClient(Control.MousePosition);
                newmove.Offset(islocation);
                if (this.Parent.Width > newmove.X && this.Parent.Height > newmove.Y)
                    this.Location = newmove;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ismove = false;
        }
        #endregion

        #region 控制窗体拖拉事件
        bool issize = false;
        Point sizepoint;
        private void Lb_size_MouseDown(object sender, MouseEventArgs e)
        {
            issize = true;
            sizepoint = new Point(this.Right - MousePosition.X, this.Bottom - MousePosition.Y);
        }

        private void Lb_size_MouseMove(object sender, MouseEventArgs e)
        {
            if (issize)
            {
                Point move = Control.MousePosition;
                this.Size = new Size(move.X + sizepoint.X - this.Left, move.Y + sizepoint.Y - this.Top);
                this.dataGridView1.Columns[0].Width = Size.Width - 3;
            }
        }

        private void Lb_size_MouseUp(object sender, MouseEventArgs e)
        {
            issize = false;
        }
        #endregion

        #region 改变控件的背景颜色事件
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //c = panel1.BackColor;
            //panel1.BackColor = Color.Yellow;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            //panel1.BackColor = c;
        }

        private void Lb_size_MouseEnter(object sender, EventArgs e)
        {
            Lb_size.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Lb_size_MouseLeave(object sender, EventArgs e)
        {
            Lb_size.BorderStyle = BorderStyle.None;
        }
        #endregion

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            this.BringToFront();
            SetActivatedControlColor(c);

            if (e.Button == MouseButtons.Right)
            {
                FrmBuilderSelect frmbuilder = new FrmBuilderSelect(Control.MousePosition, thiscontent);
                frmbuilder.Lb_tbname.Text = this.Lb_tbname.Text;
                if (dataGridView1.Rows.Count == 0)
                    frmbuilder.Enabled = false;
                frmbuilder.Show();
            }
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (thiscontent.CurrentSourceType == Main.Interface.DataSourceType.MicrosfotSqlServer)
            {
                dt = Command.DataSourceCommand.GetTableColumnsInfo(thisconnstring, thistbname);
                FrmTableColumnInfo frminfo = new FrmTableColumnInfo(thiscontent, thistbname);
                frminfo.dataGridView1.DataSource = dt;
                frminfo.Text = "查看" + thistbname + "表各列的具体信息";
                frminfo.ShowDialog();
            }
            else if (thiscontent.CurrentSourceType == Main.Interface.DataSourceType.Oracle)
            {
                dt = Command.OracleCommand.DataSourceCommand.GetTableColumnsInfo(thisconnstring, thistbname);
                FrmOracleTableColumnInfo frminfo = new FrmOracleTableColumnInfo(thiscontent, thistbname);
                frminfo.dataGridView1.DataSource = dt;
                frminfo.Text = "查看" + thistbname + "表各列的具体信息";
                frminfo.ShowDialog();
            }


        }
        #region 公共方法
        /// <summary>
        /// 设置激活控件的背景颜色
        /// </summary>
        /// <param name="c">全局默认颜色</param>
        private void SetActivatedControlColor(Color c)
        {
            Control parentfrm = this.Parent;
            foreach (Control child in parentfrm.Controls)
            {
                if (child is ControlTableView)
                {
                    foreach (Control panel in child.Controls)
                    {
                        if (panel.Name == "panel1")
                        {
                            panel.BackColor = c;
                        }
                    }
                }
            }
            panel1.BackColor = Color.LightSteelBlue;//激活状态颜色
            ((Parent as Panel).Parent as FrmTableViewContainer).ActivatedView = this;
        }
        #endregion
    }
}
