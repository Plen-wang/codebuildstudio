namespace CodeBuilderStudio.Main
{
    partial class FrmProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProject));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tool_lookup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_openfile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_openfiledir = new System.Windows.Forms.ToolStripButton();
            this.Tv_filebrowser = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tools_property = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_lookup,
            this.toolStripSeparator1,
            this.Tools_openfile,
            this.toolStripSeparator2,
            this.Tools_openfiledir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(225, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tool_lookup
            // 
            this.Tool_lookup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_lookup.Image = ((System.Drawing.Image)(resources.GetObject("Tool_lookup.Image")));
            this.Tool_lookup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_lookup.Name = "Tool_lookup";
            this.Tool_lookup.Size = new System.Drawing.Size(23, 22);
            this.Tool_lookup.ToolTipText = "查找指定名称的节点";
            this.Tool_lookup.Click += new System.EventHandler(this.Tool_lookup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Tools_openfile
            // 
            this.Tools_openfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tools_openfile.Image = ((System.Drawing.Image)(resources.GetObject("Tools_openfile.Image")));
            this.Tools_openfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_openfile.Name = "Tools_openfile";
            this.Tools_openfile.Size = new System.Drawing.Size(23, 22);
            this.Tools_openfile.ToolTipText = "打开该文件";
            this.Tools_openfile.Click += new System.EventHandler(this.Tools_openfile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Tools_openfiledir
            // 
            this.Tools_openfiledir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tools_openfiledir.Image = ((System.Drawing.Image)(resources.GetObject("Tools_openfiledir.Image")));
            this.Tools_openfiledir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_openfiledir.Name = "Tools_openfiledir";
            this.Tools_openfiledir.Size = new System.Drawing.Size(23, 22);
            this.Tools_openfiledir.ToolTipText = "浏览文件";
            this.Tools_openfiledir.Click += new System.EventHandler(this.Tools_openfiledir_Click);
            // 
            // Tv_filebrowser
            // 
            this.Tv_filebrowser.BackColor = System.Drawing.Color.White;
            this.Tv_filebrowser.ContextMenuStrip = this.contextMenuStrip1;
            this.Tv_filebrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tv_filebrowser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tv_filebrowser.ImageIndex = 0;
            this.Tv_filebrowser.ImageList = this.imageList1;
            this.Tv_filebrowser.Location = new System.Drawing.Point(0, 25);
            this.Tv_filebrowser.Name = "Tv_filebrowser";
            this.Tv_filebrowser.SelectedImageIndex = 0;
            this.Tv_filebrowser.Size = new System.Drawing.Size(225, 376);
            this.Tv_filebrowser.TabIndex = 5;
            this.Tv_filebrowser.DoubleClick += new System.EventHandler(this.Tv_filebrowser_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tools_property});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // Tools_property
            // 
            this.Tools_property.Name = "Tools_property";
            this.Tools_property.Size = new System.Drawing.Size(112, 22);
            this.Tools_property.Text = "属性(&P)";
            this.Tools_property.Click += new System.EventHandler(this.Tools_property_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "9.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            this.imageList1.Images.SetKeyName(5, "6.png");
            this.imageList1.Images.SetKeyName(6, "11.png");
            this.imageList1.Images.SetKeyName(7, "10.png");
            this.imageList1.Images.SetKeyName(8, "7.png");
            this.imageList1.Images.SetKeyName(9, "8.png");
            this.imageList1.Images.SetKeyName(10, "4.png");
            this.imageList1.Images.SetKeyName(11, "12.png");
            this.imageList1.Images.SetKeyName(12, "13.png");
            this.imageList1.Images.SetKeyName(13, "14.png");
            this.imageList1.Images.SetKeyName(14, "15.png");
            this.imageList1.Images.SetKeyName(15, "16.png");
            this.imageList1.Images.SetKeyName(16, "17.png");
            this.imageList1.Images.SetKeyName(17, "18.png");
            this.imageList1.Images.SetKeyName(18, "19.png");
            this.imageList1.Images.SetKeyName(19, "20.png");
            this.imageList1.Images.SetKeyName(20, "21.png");
            this.imageList1.Images.SetKeyName(21, "22.png");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Tv_filebrowser);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 405);
            this.panel1.TabIndex = 6;
            // 
            // FrmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(229, 405);
            this.Controls.Add(this.panel1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProject";
            this.Text = "项目";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView Tv_filebrowser;
        private System.Windows.Forms.ToolStripButton Tool_lookup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Tools_openfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Tools_openfiledir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tools_property;
        private System.Windows.Forms.Panel panel1;


    }
}