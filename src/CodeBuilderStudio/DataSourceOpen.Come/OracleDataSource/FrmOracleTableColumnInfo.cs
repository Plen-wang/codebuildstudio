using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataSourceOpen.Come
{
    public partial class FrmOracleTableColumnInfo : Form
    {
        ControlContent content;
        string tbname;
        public FrmOracleTableColumnInfo(ControlContent con, string tablename)
        {
            InitializeComponent();
            //系统帮助
            this.helpProvider1.SetShowHelp(this, true);
            this.helpProvider1.SetHelpString(this.Btn_builder, "生成代码片段");
            content = con;
            tbname = tablename;
        }

        private void Btn_builder_Click(object sender, EventArgs e)
        {
            content.OnOpenSingleBuilderViewEvent(
                Command.OracleCommand.DataSourceCommand.GetTableColumnsInfo(content.ConnectionString.ToString(), tbname));
            this.Close();
        }
    }
}
