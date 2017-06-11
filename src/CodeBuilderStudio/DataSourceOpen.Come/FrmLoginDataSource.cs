using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataSourceOpen.Come
{
    public partial class FrmLoginDataSource : Form
    {
        #region 类变量及构造函数
        ControlContent runcome;
        /// <summary>
        /// 重载构造函数，获取数据源中的表集合
        /// </summary>
        public FrmLoginDataSource(ControlContent come)
        {
            InitializeComponent();
            this.Shown += new EventHandler(FrmLoginDb_Shown);
            this.FormClosed += new FormClosedEventHandler(FrmLoginDb_FormClosed);
            runcome = come;
        }
        #endregion

        #region 窗体事件
        private void Rb_sqlserver_CheckedChanged(object sender, EventArgs e)
        {
            P_logninfo.Enabled = Rb_sqlserver.Checked;
        }
        private void FrmLoginDb_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Cb_savepwd.Checked)
            {
                CenterConfig.Default.username = Tb_user.Text;
                CenterConfig.Default.password = Tb_pwd.Text;
                CenterConfig.Default.issave = true;
                CenterConfig.Default.checkindex = Rb_window.Checked == true ? 1 : 2;
                CenterConfig.Default.Save();
            }
            else
            {
                CenterConfig.Default.username = "";
                CenterConfig.Default.password = "";
                CenterConfig.Default.issave = false;
                CenterConfig.Default.checkindex = 0;
                CenterConfig.Default.Save();
            }
            if (Cb_savefromdata.Checked)
            {
                CenterConfig.Default.servername = Tb_dbserver.Text;
                CenterConfig.Default.databasename = Tb_dbname.Text;
                CenterConfig.Default.issavefromdata = true;
                CenterConfig.Default.Save();
            }
            else
            {
                CenterConfig.Default.servername = "";
                CenterConfig.Default.databasename = "";
                CenterConfig.Default.issavefromdata = false;
                CenterConfig.Default.Save();
            }
        }
        private void FrmLoginDb_Shown(object sender, EventArgs e)
        {
            if (CenterConfig.Default.issave)
            {
                Tb_user.Text = CenterConfig.Default.username;
                Tb_pwd.Text = CenterConfig.Default.password;
                switch (CenterConfig.Default.checkindex)
                {
                    case 1: Rb_window.Checked = true; break;
                    case 2: Rb_sqlserver.Checked = true; break;
                }
                Cb_savepwd.Checked = true;
            }
            if (CenterConfig.Default.issavefromdata)
            {
                Tb_dbserver.Text = CenterConfig.Default.servername;
                Tb_dbname.Text = CenterConfig.Default.databasename;
                Cb_savefromdata.Checked = true;
            }
        }
        #endregion

        System.Text.StringBuilder connstr = new StringBuilder();
        bool isconn = false;
        private void Bt_acceptconn_Click(object sender, EventArgs e)
        {
            InitConnectionstring(connstr);
            if (Command.DataSourceCommand.CheckConn(connstr))
            {
                MessageBox.Show(this, "连接成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isconn = true;
            }
            else
            {
                MessageBox.Show(this, "用户名密码错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_enter_Click(object sender, EventArgs e)
        {
            if (connstr.Length <= 0)
                InitConnectionstring(connstr);
            if (isconn)//已经进行过验证测试
            {
                List<string> result = Command.DataSourceCommand.GetTableColl(connstr.ToString());//所有表名称
                result.AddRange(Command.DataSourceCommand.GetViewList(connstr.ToString()));//所有试图名称

                runcome.ConnectionString = connstr;
                runcome.OnPassDataEvent(result, connstr.ToString(), Tb_dbname.Text.Trim());
                this.Close();
            }
            else//未经过验证测试
            {
                if (Command.DataSourceCommand.CheckConn(connstr))//先验证
                {
                    List<string> result = Command.DataSourceCommand.GetTableColl(connstr.ToString());
                    result.AddRange(Command.DataSourceCommand.GetViewList(connstr.ToString()));
                    runcome.ConnectionString = connstr;
                    runcome.OnPassDataEvent(result, connstr.ToString(), Tb_dbname.Text.Trim());
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "用户名密码错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region 类公共方法
        private void InitConnectionstring(System.Text.StringBuilder conn)
        {
            if (conn.Length > 0)
                conn.Remove(0, conn.Length);
            if (Rb_window.Checked)
            {
                conn.AppendFormat("data source={0};database={1};Connect Timeout=3;Trusted_Connection=Yes;", Tb_dbserver.Text.Trim(), Tb_dbname.Text.Trim());
                return;
            }
            conn.AppendFormat("data source={0};database={1};uid={2};pwd={3};Connect Timeout=3;",
                   Tb_dbserver.Text.Trim(), Tb_dbname.Text.Trim(), Tb_user.Text.Trim(), Tb_pwd.Text.Trim());
        }
        #endregion
    }
}
