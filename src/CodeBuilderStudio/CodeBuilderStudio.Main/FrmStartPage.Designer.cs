namespace CodeBuilderStudio.Main
{
    partial class FrmStartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStartPage));
            this.mainInitPageControlHelper1 = new CodeBuilderStudio.Control.MainInitPageControlHelper();
            this.mainInitPageControlProject1 = new CodeBuilderStudio.Control.MainInitPageControlProject();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tools_close = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainInitPageControlHelper1
            // 
            this.mainInitPageControlHelper1.BackColor = System.Drawing.Color.Transparent;
            this.mainInitPageControlHelper1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainInitPageControlHelper1.BackgroundImage")));
            this.mainInitPageControlHelper1.Location = new System.Drawing.Point(24, 47);
            this.mainInitPageControlHelper1.Name = "mainInitPageControlHelper1";
            this.mainInitPageControlHelper1.Size = new System.Drawing.Size(241, 195);
            this.mainInitPageControlHelper1.TabIndex = 0;
            // 
            // mainInitPageControlProject1
            // 
            this.mainInitPageControlProject1.BackColor = System.Drawing.Color.Transparent;
            this.mainInitPageControlProject1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainInitPageControlProject1.BackgroundImage")));
            this.mainInitPageControlProject1.Location = new System.Drawing.Point(372, 47);
            this.mainInitPageControlProject1.Name = "mainInitPageControlProject1";
            this.mainInitPageControlProject1.Size = new System.Drawing.Size(239, 196);
            this.mainInitPageControlProject1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tools_close});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // Tools_close
            // 
            this.Tools_close.Name = "Tools_close";
            this.Tools_close.Size = new System.Drawing.Size(98, 22);
            this.Tools_close.Text = "关闭";
            this.Tools_close.Click += new System.EventHandler(this.Tools_close_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reflectionLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reflectionLabel1.Location = new System.Drawing.Point(343, 264);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(275, 70);
            this.reflectionLabel1.TabIndex = 2;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>FastExpress.net</i><font color=\"#B02B2C\"> 代码生成器</font></fon" +
                "t></b>";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.reflectionLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 341);
            this.panel1.TabIndex = 3;
            // 
            // FrmStartPage
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 341);
            this.Controls.Add(this.mainInitPageControlProject1);
            this.Controls.Add(this.mainInitPageControlHelper1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStartPage";
            this.TabPageContextMenuStrip = this.contextMenuStrip1;
            this.Text = "起始页";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CodeBuilderStudio.Control.MainInitPageControlHelper mainInitPageControlHelper1;
        private CodeBuilderStudio.Control.MainInitPageControlProject mainInitPageControlProject1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tools_close;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.Panel panel1;






    }
}