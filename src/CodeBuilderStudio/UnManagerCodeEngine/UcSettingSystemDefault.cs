using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnManagerCodeEngine
{
    public partial class UcSettingSystemDefault : UserControl
    {
        public UcSettingSystemDefault()
        {
            InitializeComponent();
            this.Load += new EventHandler(UcSettingSystemDefault_Load);
        }

        void UcSettingSystemDefault_Load(object sender, EventArgs e)
        {
            Tb_namespace.Text = SystemDefault.Default.DefaultNameSpace;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            Action<string> savefun = _ =>
            {
                SystemDefault.Default.DefaultNameSpace = Tb_namespace.Text.Trim();
                SystemDefault.Default.Save();
            };
            Action<string> alertfun = _ =>
            {
                MessageBox.Show(this, "保存成功!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            if (Tb_namespace.Text.Trim().Length <= 0)
            {
                if (MessageBox.Show(this, "如果未输入命名空间，在生成代码的时候将显示为空白!", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    savefun(string.Empty);
                    alertfun(string.Empty);
                    return;
                }
            }
            savefun(string.Empty);
            alertfun(string.Empty);
        }
    }
}
