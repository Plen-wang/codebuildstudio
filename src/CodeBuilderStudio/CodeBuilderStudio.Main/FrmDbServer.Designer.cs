namespace CodeBuilderStudio.Main
{
    partial class FrmDbServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDbServer));
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.Tools_splitbutton = new System.Windows.Forms.ToolStripSplitButton();
            this.Tools_Sqlmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_oledb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_oraclemuen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_link = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_end = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_ref = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_viewtable = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TV_tblist = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Tools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tools
            // 
            this.Tools.BackColor = System.Drawing.SystemColors.Control;
            this.Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tools_splitbutton,
            this.toolStripSeparator1,
            this.Tools_link,
            this.toolStripSeparator2,
            this.Tools_end,
            this.toolStripSeparator3,
            this.Tools_ref,
            this.toolStripSeparator4,
            this.Tools_viewtable});
            this.Tools.Location = new System.Drawing.Point(0, 0);
            this.Tools.Name = "Tools";
            this.Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Tools.Size = new System.Drawing.Size(223, 25);
            this.Tools.TabIndex = 3;
            // 
            // Tools_splitbutton
            // 
            this.Tools_splitbutton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tools_Sqlmenu,
            this.toolStripMenuItem1,
            this.Tools_oraclemuen,
            this.toolStripMenuItem2,
            this.Tools_oledb});
            this.Tools_splitbutton.Image = ((System.Drawing.Image)(resources.GetObject("Tools_splitbutton.Image")));
            this.Tools_splitbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_splitbutton.Name = "Tools_splitbutton";
            this.Tools_splitbutton.Size = new System.Drawing.Size(100, 22);
            this.Tools_splitbutton.Text = "连接数据源";
            // 
            // Tools_Sqlmenu
            // 
            this.Tools_Sqlmenu.Name = "Tools_Sqlmenu";
            this.Tools_Sqlmenu.Size = new System.Drawing.Size(196, 22);
            this.Tools_Sqlmenu.Text = "SQLServer数据库引擎";
            this.Tools_Sqlmenu.ToolTipText = "连接SQLServer数据库引擎";
            this.Tools_Sqlmenu.Click += new System.EventHandler(this.Tools_Sqlmenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // Tools_oledb
            // 
            this.Tools_oledb.Enabled = false;
            this.Tools_oledb.Name = "Tools_oledb";
            this.Tools_oledb.Size = new System.Drawing.Size(196, 22);
            this.Tools_oledb.Text = "OLEDB数据源";
            this.Tools_oledb.ToolTipText = "连接OLEDB数据源";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // Tools_oraclemuen
            // 
            this.Tools_oraclemuen.Name = "Tools_oraclemuen";
            this.Tools_oraclemuen.Size = new System.Drawing.Size(196, 22);
            this.Tools_oraclemuen.Text = "Oracle数据源";
            this.Tools_oraclemuen.ToolTipText = "连接Oracle数据源";
            this.Tools_oraclemuen.Click += new System.EventHandler(this.Tools_oraclemuen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Tools_link
            // 
            this.Tools_link.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tools_link.Image = ((System.Drawing.Image)(resources.GetObject("Tools_link.Image")));
            this.Tools_link.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_link.Name = "Tools_link";
            this.Tools_link.Size = new System.Drawing.Size(23, 22);
            this.Tools_link.ToolTipText = "搜索指定名称的表节点";
            this.Tools_link.Click += new System.EventHandler(this.Tools_link_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Tools_end
            // 
            this.Tools_end.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tools_end.Image = ((System.Drawing.Image)(resources.GetObject("Tools_end.Image")));
            this.Tools_end.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_end.Name = "Tools_end";
            this.Tools_end.Size = new System.Drawing.Size(23, 22);
            this.Tools_end.ToolTipText = "断开所有数据源连接";
            this.Tools_end.Click += new System.EventHandler(this.Tools_end_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Tools_ref
            // 
            this.Tools_ref.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tools_ref.Image = ((System.Drawing.Image)(resources.GetObject("Tools_ref.Image")));
            this.Tools_ref.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_ref.Name = "Tools_ref";
            this.Tools_ref.Size = new System.Drawing.Size(23, 22);
            this.Tools_ref.ToolTipText = "刷新目录结构";
            this.Tools_ref.Click += new System.EventHandler(this.Tools_ref_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Tools_viewtable
            // 
            this.Tools_viewtable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tools_viewtable.Image = ((System.Drawing.Image)(resources.GetObject("Tools_viewtable.Image")));
            this.Tools_viewtable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_viewtable.Name = "Tools_viewtable";
            this.Tools_viewtable.Size = new System.Drawing.Size(23, 20);
            this.Tools_viewtable.Text = "查看表视图";
            this.Tools_viewtable.Click += new System.EventHandler(this.Tools_viewtable_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TV_tblist);
            this.panel1.Controls.Add(this.Tools);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 471);
            this.panel1.TabIndex = 4;
            // 
            // TV_tblist
            // 
            this.TV_tblist.BackColor = System.Drawing.Color.White;
            this.TV_tblist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TV_tblist.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TV_tblist.ImageIndex = 0;
            this.TV_tblist.ImageList = this.imageList1;
            this.TV_tblist.Location = new System.Drawing.Point(0, 25);
            this.TV_tblist.Name = "TV_tblist";
            this.TV_tblist.SelectedImageIndex = 0;
            this.TV_tblist.Size = new System.Drawing.Size(223, 442);
            this.TV_tblist.TabIndex = 4;
            this.TV_tblist.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TV_tblist_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "database.bmp");
            this.imageList1.Images.SetKeyName(1, "field.bmp");
            this.imageList1.Images.SetKeyName(2, "server.bmp");
            // 
            // FrmDbServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(227, 471);
            this.Controls.Add(this.panel1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDbServer";
            this.Text = "数据库服务器";
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripSplitButton Tools_splitbutton;
        private System.Windows.Forms.ToolStripMenuItem Tools_Sqlmenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Tools_oledb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Tools_link;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Tools_end;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Tools_ref;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Tools_oraclemuen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Tools_viewtable;
        private System.Windows.Forms.TreeView TV_tblist;


    }
}