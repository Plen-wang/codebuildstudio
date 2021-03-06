﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace UnManagerCodeEngine
{
    public partial class UcTbColumnsEdit : UserControl
    {
        public UcTbColumnsEdit()
        {
            InitializeComponent();
            this.Load += new EventHandler(UcTbColumnsEdit_Load);
        }

        private void UcTbColumnsEdit_Load(object sender, EventArgs e)
        {

        }
        Command.IDataBaseTypeEdit IDataBaseEdit;
        private void Cb_dbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_dbtype.SelectedIndex == 0)//SqlServer数据库
            {
                IDataBaseEdit = new Command.MsSqlServerDataTypeEdit();
                Gv_info.DataSource = (IDataBaseEdit as Command.BaseDataTypeEdit).GetColumnList();
                Gv_setinfo.DataSource = IDataBaseEdit.GetRef();
            }
            else if (Cb_dbtype.SelectedIndex == 1)
            {
                IDataBaseEdit = new Command.OracleDataTypeEdit();
                Gv_info.DataSource = (IDataBaseEdit as Command.BaseDataTypeEdit).GetColumnList();
                Gv_setinfo.DataSource = IDataBaseEdit.GetRef();
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (Cb_dbtype.SelectedIndex == 0)
            {
                try
                {
                    IDataBaseEdit.Save();
                    MessageBox.Show(this, "保存成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { }
            }
            else if (Cb_dbtype.SelectedIndex == 1)
            {
                try
                {
                    IDataBaseEdit.Save();
                    MessageBox.Show(this, "保存成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { }
            }
        }
    }
}
