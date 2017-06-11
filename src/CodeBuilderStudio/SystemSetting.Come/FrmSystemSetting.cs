using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SystemSetting.Come
{
    public partial class FrmSystemSetting : Form
    {
        ControlContent control;
        public FrmSystemSetting()
        {
            InitializeComponent();
            control =
                (Main.Interface.ComeBaseModule.UnManagerObjectPolling.GetObjectByName<ControlContent>("systemsettingobject") as ControlContent);
        }

        private void Tv_settting_DoubleClick(object sender, EventArgs e)
        {
            Lb_setname.Text = Tv_settting.SelectedNode.Text;
            if (Tv_settting.SelectedNode.Name == "codethemp")
                OverSettingView(1);
            else if (Tv_settting.SelectedNode.Name == "consult")
                OverSettingView(2);
            else if (Tv_settting.SelectedNode.Name == "columns")
                OverSettingView(3);
            else if (Tv_settting.SelectedNode.Name == "default")
                OverSettingView(4);
            else if (Tv_settting.SelectedNode.Name == "store")
                OverSettingView(5);
        }
        private void OverSettingView(int type)
        {
            UserControl usercontrol;
            if (type == 1)
                usercontrol = new UcSettingCodeThemp();
            else if (type == 2)
                usercontrol = new UcSettingConsultThemp();
            else if (type == 4)
                usercontrol = new UnManagerCodeEngine.UcSettingSystemDefault();
            else if (type == 5)
                usercontrol = new UnManagerCodeEngine.UcStoreProcedureEdit();
            else
                usercontrol = new UnManagerCodeEngine.UcTbColumnsEdit();
            usercontrol.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(usercontrol);
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
