using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataSourceOpen.Come.OracleDataSource
{
    public partial class FrmLogin : Form
    {
        ControlContent runcome;
        StringBuilder connstring = new StringBuilder();
        public FrmLogin(ControlContent come)
        {
            InitializeComponent();
            this.Shown += new EventHandler(FrmLoginDb_Shown);
            this.FormClosed += new FormClosedEventHandler(FrmLoginDb_FormClosed);
            runcome = come;
        }
        public FrmLogin()
        {
            InitializeComponent();
            this.Shown += new EventHandler(FrmLoginDb_Shown);
            this.FormClosed += new FormClosedEventHandler(FrmLoginDb_FormClosed);
        }

        private void FrmLoginDb_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Cb_savepwd.Checked)
            {
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.username = Tb_user.Text;
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.password = Tb_pwd.Text;
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.issave = true;
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.Save();
            }
            else
            {
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.username = "";
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.password = "";
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.issave = false;
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.Save();
            }
            if (Cb_savefromdata.Checked)
            {
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.servername = Tb_dbserver.Text;
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.databasename = Tb_dbname.Text;
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.issavefromdata = true;
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.Save();
            }
            else
            {
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.servername = "";
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.databasename = "";
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.issavefromdata = false;
                DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.Save();
            }
        }
        private void FrmLoginDb_Shown(object sender, EventArgs e)
        {
            if (CenterConfig.Default.issave)
            {
                Tb_user.Text = DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.username;
                Tb_pwd.Text = DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.password;
                Cb_savepwd.Checked = true;
            }
            if (DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.issavefromdata)
            {
                Tb_dbserver.Text = DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.servername;
                Tb_dbname.Text = DataSourceOpen.Come.OracleDataSource.OracleSetring.Default.databasename;
                Cb_savefromdata.Checked = true;
            }
        }
        private void Tb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_enter_Click(object sender, EventArgs e)
        {
            Action<string> alertaction = (string msg) =>
            {
                MessageBox.Show(this, msg, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            if (Tb_dbserver.Text.Trim().Length <= 0)
            {
                alertaction("请填写服务器地"); return;
            }
            if (Tb_dbname.Text.Trim().Length <= 0)
            {
                alertaction("请填写数据库名称"); return;
            }

            connstring.AppendFormat(@"Data Source={0}/{1};User ID={2};Unicode=True;Password={3};Enlist=true;Pooling=true;Max Pool Size=300;Min Pool Size=0;Connection Lifetime=300;",
                Tb_dbserver.Text, Tb_dbname.Text, Tb_user.Text, Tb_pwd.Text);

            List<string> result = Command.OracleCommand.DataSourceCommand.GetTableColl(connstring.ToString());//所有表名称
            result.AddRange(Command.OracleCommand.DataSourceCommand.GetViewList(connstring.ToString()));//所有试图名称

            runcome.ConnectionString = connstring;
            runcome.OnPassDataEvent(result, connstring.ToString(), Tb_dbname.Text.Trim());
            this.Close();
        }
    }
}
