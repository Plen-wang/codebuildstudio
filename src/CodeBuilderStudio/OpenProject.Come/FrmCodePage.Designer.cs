namespace OpenProject.Come
{
    partial class FrmCodePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCodePage));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools_close = new System.Windows.Forms.ToolStripMenuItem();
            this.打开所在的文件夹OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uccodeview = new ComeCommonMethod.UcCodeView();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存SToolStripMenuItem,
            this.Tools_close,
            this.打开所在的文件夹OToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 92);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            // 
            // Tools_close
            // 
            this.Tools_close.Name = "Tools_close";
            this.Tools_close.Size = new System.Drawing.Size(184, 22);
            this.Tools_close.Text = "关闭(&C)";
            this.Tools_close.Click += new System.EventHandler(this.Tools_close_Click);
            // 
            // 打开所在的文件夹OToolStripMenuItem
            // 
            this.打开所在的文件夹OToolStripMenuItem.Name = "打开所在的文件夹OToolStripMenuItem";
            this.打开所在的文件夹OToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.打开所在的文件夹OToolStripMenuItem.Text = "打开所在的文件夹(&O)";
            // 
            // uccodeview
            // 
            this.uccodeview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uccodeview.CodeText = null;
            this.uccodeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uccodeview.Location = new System.Drawing.Point(0, 0);
            this.uccodeview.Name = "uccodeview";
            this.uccodeview.Size = new System.Drawing.Size(805, 429);
            this.uccodeview.TabIndex = 1;
            // 
            // FrmCodePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 429);
            this.Controls.Add(this.uccodeview);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCodePage";
            this.TabPageContextMenuStrip = this.contextMenuStrip1;
            this.Text = "生成的代码";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tools_close;
        private System.Windows.Forms.ToolStripMenuItem 打开所在的文件夹OToolStripMenuItem;
        private ComeCommonMethod.UcCodeView uccodeview;
    }
}