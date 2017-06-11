namespace SystemSetting.Come
{
    partial class FrmSystemSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("模板路径配置", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("数据字段编辑", 3, 3);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("系统常量编辑", 4, 4);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("存储过程编辑");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("系统运行时设置", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSystemSetting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lb_setname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Tv_settting = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(635, 49);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.Lb_setname);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 41);
            this.panel3.TabIndex = 2;
            // 
            // Lb_setname
            // 
            this.Lb_setname.AutoSize = true;
            this.Lb_setname.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_setname.Location = new System.Drawing.Point(21, 8);
            this.Lb_setname.Name = "Lb_setname";
            this.Lb_setname.Size = new System.Drawing.Size(119, 14);
            this.Lb_setname.TabIndex = 0;
            this.Lb_setname.Text = "SettingNameSpace";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(632, 348);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Tv_settting);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Btn_close);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(796, 430);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 2;
            // 
            // Tv_settting
            // 
            this.Tv_settting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tv_settting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tv_settting.ImageIndex = 0;
            this.Tv_settting.ImageList = this.imageList1;
            this.Tv_settting.Location = new System.Drawing.Point(0, 0);
            this.Tv_settting.Name = "Tv_settting";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "codethemp";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "模板路径配置";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "columns";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "数据字段编辑";
            treeNode3.ImageIndex = 4;
            treeNode3.Name = "default";
            treeNode3.SelectedImageIndex = 4;
            treeNode3.Text = "系统常量编辑";
            treeNode4.Name = "store";
            treeNode4.Text = "存储过程编辑";
            treeNode5.Name = "节点0";
            treeNode5.Text = "系统运行时设置";
            this.Tv_settting.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.Tv_settting.SelectedImageIndex = 0;
            this.Tv_settting.Size = new System.Drawing.Size(157, 430);
            this.Tv_settting.TabIndex = 0;
            this.Tv_settting.DoubleClick += new System.EventHandler(this.Tv_settting_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "root.png");
            this.imageList1.Images.SetKeyName(1, "0.png");
            this.imageList1.Images.SetKeyName(2, "1.png");
            this.imageList1.Images.SetKeyName(3, "DataSourceCSV.bmp");
            this.imageList1.Images.SetKeyName(4, "default.png");
            // 
            // Btn_close
            // 
            this.Btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_close.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_close.Location = new System.Drawing.Point(553, 402);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(75, 23);
            this.Btn_close.TabIndex = 4;
            this.Btn_close.Text = "关闭";
            this.Btn_close.UseVisualStyleBackColor = false;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // FrmSystemSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 436);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSystemSetting";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "辉煌.NET代码生成器  Configuration";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lb_setname;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView Tv_settting;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_close;
    }
}