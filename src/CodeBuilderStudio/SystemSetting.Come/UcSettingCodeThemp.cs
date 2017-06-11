﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Xml;

namespace SystemSetting.Come
{
    public partial class UcSettingCodeThemp : UserControl
    {
        ControlContent control;

        public UcSettingCodeThemp()
        {
            InitializeComponent();
            control =
                (Main.Interface.ComeBaseModule.UnManagerObjectPolling.GetObjectByName<ControlContent>("systemsettingobject") as ControlContent);
            this.Load += new EventHandler(UcSettingCodeThemp_Load);
        }

        void UcSettingCodeThemp_Load(object sender, EventArgs e)
        {
            Tb_path.Text = ConfigurationManager.AppSettings["CodeThempPath"];
        }

        private void Btn_browser_Click(object sender, EventArgs e)
        {
            control.CallBackCodeThempPath += new Main.Interface.SystemSettingHanlder<string>(control_CallBackCodeThempPath);
            control.OnGetCodeThempPath();
        }

        void control_CallBackCodeThempPath(string t)
        {
            Tb_path.Text = t;
        }

        private void Btn_setting_Click(object sender, EventArgs e)
        {
            ComeCommonMethod.XmlFunction.SetNodeValueByAttribute(
            Application.StartupPath + "\\FastExpress.net.exe.config", @"appSettings/add[@key='CodeThempPath']", "value", Tb_path.Text);
            MessageBox.Show(this, "设置成功，当前的设置需要在下次启动时才能生效。", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
