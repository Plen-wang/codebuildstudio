using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;

namespace ThempEdit.Come
{
    public partial class UcEditMaster : UserControl
    {
        public UcEditMaster()
        {
            InitializeComponent();
            this.Load += new EventHandler(UcEditMaster_Load);
        }

        private void UcEditMaster_Load(object sender, EventArgs e)
        {
            InitRightTools();
        }

        private void InitRightTools()
        {
            Hashtable hashtb = new Command.ReadThempMaster().GetMasterFileList();
            int i = 0;
            foreach (DictionaryEntry entry in hashtb)
            {
                ExplorerBarGroupItem groupitem = new ExplorerBarGroupItem();
                groupitem.BackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
                groupitem.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                groupitem.BackStyle.BorderBottomWidth = 1;
                groupitem.BackStyle.BorderColor = System.Drawing.Color.White;
                groupitem.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
                groupitem.BackStyle.BorderLeftWidth = 1;
                groupitem.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
                groupitem.BackStyle.BorderRightWidth = 1;
                groupitem.Cursor = System.Windows.Forms.Cursors.Default;
                groupitem.ExpandBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
                groupitem.Expanded = true;
                groupitem.ExpandForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
                groupitem.ExpandHotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(195)))), ((int)(((byte)(208)))));
                groupitem.ExpandHotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
                groupitem.Name = "explorerBarGroupItem" + i.ToString();
                groupitem.Text = Path.GetFileName(entry.Key.ToString()) + "(模板示例)";
                groupitem.TitleHotStyle.BackColor = System.Drawing.Color.White;
                groupitem.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
                groupitem.TitleHotStyle.CornerDiameter = 3;
                groupitem.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
                groupitem.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
                groupitem.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
                groupitem.TitleStyle.BackColor = System.Drawing.Color.White;
                groupitem.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
                groupitem.TitleStyle.CornerDiameter = 3;
                groupitem.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
                groupitem.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
                groupitem.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));

                int j = 0;
                foreach (string str in (entry.Value as string[]))
                {
                    ButtonItem bottonitem = new ButtonItem();
                    bottonitem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
                    bottonitem.Cursor = System.Windows.Forms.Cursors.Hand;
                    bottonitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
                    bottonitem.HotFontUnderline = true;
                    bottonitem.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
                    bottonitem.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
                    bottonitem.Name = "buttonItem" + j++.ToString();
                    bottonitem.Text = Path.GetFileName(str);
                    bottonitem.Click += new EventHandler(bottonitem_Click);
                    groupitem.SubItems.Add(bottonitem);
                }
                explorerBar1.Groups.Add(groupitem);
                i++;
            }

        }

        ControlContent control;
        void bottonitem_Click(object sender, EventArgs e)
        {
            if (control == null)
                control =
                    Main.Interface.ComeBaseModule.UnManagerObjectPolling.GetObjectByName<ControlContent>("controlcontent") as ControlContent;

            FrmEditDemo demo = new FrmEditDemo();
            demo.TabText = (sender as ButtonItem).Text + "  .源码参考";
            control.OnShowDemoEvent(new ThempEditArgs<FrmEditDemo>(demo));
        }
    }
}
