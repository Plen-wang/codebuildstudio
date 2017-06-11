namespace DataSourceOpen.Come
{
    partial class FrmTableViewContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableViewContainer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_max = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_restore = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_deleview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_saveview = new System.Windows.Forms.ToolStripSplitButton();
            this.Toos_preview = new System.Windows.Forms.ToolStripMenuItem();
            this.Toos_printc = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tools_close = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools_print = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.Tools_max,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.Tools_restore,
            this.toolStripSeparator4,
            this.Tools_deleview,
            this.toolStripSeparator5,
            this.Tools_saveview});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(919, 25);
            this.toolStrip1.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Tools_max
            // 
            this.Tools_max.Image = ((System.Drawing.Image)(resources.GetObject("Tools_max.Image")));
            this.Tools_max.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_max.Name = "Tools_max";
            this.Tools_max.Size = new System.Drawing.Size(100, 22);
            this.Tools_max.Text = "放大视图版面";
            this.Tools_max.Click += new System.EventHandler(this.Tools_max_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton3.Text = "缩小视图版面";
            this.toolStripButton3.Click += new System.EventHandler(this.Tools_min_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Tools_restore
            // 
            this.Tools_restore.Image = ((System.Drawing.Image)(resources.GetObject("Tools_restore.Image")));
            this.Tools_restore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_restore.Name = "Tools_restore";
            this.Tools_restore.Size = new System.Drawing.Size(100, 22);
            this.Tools_restore.Text = "还原视图版面";
            this.Tools_restore.Click += new System.EventHandler(this.Tools_restore_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Tools_deleview
            // 
            this.Tools_deleview.Image = ((System.Drawing.Image)(resources.GetObject("Tools_deleview.Image")));
            this.Tools_deleview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_deleview.Name = "Tools_deleview";
            this.Tools_deleview.Size = new System.Drawing.Size(100, 22);
            this.Tools_deleview.Text = "删除视图版面";
            this.Tools_deleview.Click += new System.EventHandler(this.Tools_deleview_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // Tools_saveview
            // 
            this.Tools_saveview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toos_preview,
            this.Toos_printc});
            this.Tools_saveview.Image = ((System.Drawing.Image)(resources.GetObject("Tools_saveview.Image")));
            this.Tools_saveview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_saveview.Name = "Tools_saveview";
            this.Tools_saveview.Size = new System.Drawing.Size(112, 22);
            this.Tools_saveview.Text = "保存视图版面";
            this.Tools_saveview.ToolTipText = "系统将以打印的方式为您保存试图中的各字段信息";
            // 
            // Toos_preview
            // 
            this.Toos_preview.Name = "Toos_preview";
            this.Toos_preview.Size = new System.Drawing.Size(124, 22);
            this.Toos_preview.Text = "预览视图";
            this.Toos_preview.Click += new System.EventHandler(this.Toos_preview_Click);
            // 
            // Toos_printc
            // 
            this.Toos_printc.Name = "Toos_printc";
            this.Toos_printc.Size = new System.Drawing.Size(124, 22);
            this.Toos_printc.Text = "打印视图";
            this.Toos_printc.Click += new System.EventHandler(this.Toos_printc_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tools_close,
            this.Tools_print});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 48);
            // 
            // Tools_close
            // 
            this.Tools_close.Name = "Tools_close";
            this.Tools_close.Size = new System.Drawing.Size(118, 22);
            this.Tools_close.Text = "关闭";
            this.Tools_close.Click += new System.EventHandler(this.Tools_close_Click);
            // 
            // Tools_print
            // 
            this.Tools_print.Name = "Tools_print";
            this.Tools_print.Size = new System.Drawing.Size(118, 22);
            this.Tools_print.Text = "打印视图";
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reflectionLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reflectionLabel1.Location = new System.Drawing.Point(562, 366);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(336, 70);
            this.reflectionLabel1.TabIndex = 3;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>FastExpress.net </i><font color=\"#B02B2C\">代码生成器</font></fon" +
                "t></b>";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.reflectionLabel1);
            this.panel1.Location = new System.Drawing.Point(7, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 443);
            this.panel1.TabIndex = 4;
            // 
            // FrmTableViewContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTableViewContainer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabPageContextMenuStrip = this.contextMenuStrip1;
            this.Text = "数据源视图查看";
            this.Load += new System.EventHandler(this.FrmTableViewContainer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DesignPanel_Paint);
            this.Resize += new System.EventHandler(this.DesignPanel_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Tools_max;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Tools_restore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Tools_deleview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tools_close;
        private System.Windows.Forms.ToolStripMenuItem Tools_print;
        private System.Windows.Forms.ToolStripSplitButton Tools_saveview;
        private System.Windows.Forms.ToolStripMenuItem Toos_preview;
        private System.Windows.Forms.ToolStripMenuItem Toos_printc;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        public System.Windows.Forms.Panel panel1;



    }
}