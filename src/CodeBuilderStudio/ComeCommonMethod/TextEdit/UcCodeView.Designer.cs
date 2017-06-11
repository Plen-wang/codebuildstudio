namespace ComeCommonMethod
{
    partial class UcCodeView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCodeView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.Tools_zoomin = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools_zoomout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_print = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools_insert = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Tools_codetype = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Tools_encoding = new System.Windows.Forms.ToolStripComboBox();
            this.scin = new ICSharpCode.TextEditor.TextEditorControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripSeparator5,
            this.Tools_save,
            this.toolStripSeparator4,
            this.Tools_print,
            this.toolStripSeparator6,
            this.Tools_insert,
            this.toolStripLabel1,
            this.Tools_codetype,
            this.toolStripLabel2,
            this.Tools_encoding});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1007, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 21);
            this.toolStripButton1.Text = "语法检查";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tools_zoomin,
            this.Tools_zoomout});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(88, 21);
            this.toolStripSplitButton1.Text = "缩放代码";
            // 
            // Tools_zoomin
            // 
            this.Tools_zoomin.Name = "Tools_zoomin";
            this.Tools_zoomin.Size = new System.Drawing.Size(100, 22);
            this.Tools_zoomin.Text = "放大";
            this.Tools_zoomin.ToolTipText = "放大";
            this.Tools_zoomin.Click += new System.EventHandler(this.Tools_zoomin_Click);
            // 
            // Tools_zoomout
            // 
            this.Tools_zoomout.Name = "Tools_zoomout";
            this.Tools_zoomout.Size = new System.Drawing.Size(100, 22);
            this.Tools_zoomout.Text = "缩小";
            this.Tools_zoomout.ToolTipText = "缩小";
            this.Tools_zoomout.Click += new System.EventHandler(this.Tools_zoomout_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // Tools_save
            // 
            this.Tools_save.Image = ((System.Drawing.Image)(resources.GetObject("Tools_save.Image")));
            this.Tools_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_save.Name = "Tools_save";
            this.Tools_save.Size = new System.Drawing.Size(76, 21);
            this.Tools_save.Text = "保存代码";
            this.Tools_save.ToolTipText = "保存代码";
            this.Tools_save.Click += new System.EventHandler(this.Tools_save_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // Tools_print
            // 
            this.Tools_print.Image = ((System.Drawing.Image)(resources.GetObject("Tools_print.Image")));
            this.Tools_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_print.Name = "Tools_print";
            this.Tools_print.Size = new System.Drawing.Size(76, 21);
            this.Tools_print.Text = "打印代码";
            this.Tools_print.Click += new System.EventHandler(this.Tools_print_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // Tools_insert
            // 
            this.Tools_insert.Image = ((System.Drawing.Image)(resources.GetObject("Tools_insert.Image")));
            this.Tools_insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_insert.Name = "Tools_insert";
            this.Tools_insert.Size = new System.Drawing.Size(100, 21);
            this.Tools_insert.Text = "打开智能提示";
            this.Tools_insert.Click += new System.EventHandler(this.Tools_insert_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripLabel1.Text = "代码类型：";
            // 
            // Tools_codetype
            // 
            this.Tools_codetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tools_codetype.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Tools_codetype.Items.AddRange(new object[] {
            "C#",
            "Vb.net",
            "J#",
            "CLI/C++",
            "HTML",
            "Css",
            "Js",
            "Vbs",
            "Sql",
            "XML"});
            this.Tools_codetype.Name = "Tools_codetype";
            this.Tools_codetype.Size = new System.Drawing.Size(121, 25);
            this.Tools_codetype.SelectedIndexChanged += new System.EventHandler(this.Tools_codetype_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 17);
            this.toolStripLabel2.Text = "字符编码：";
            // 
            // Tools_encoding
            // 
            this.Tools_encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tools_encoding.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Tools_encoding.Items.AddRange(new object[] {
            "GB2312",
            "UTF-8",
            "UTF-16",
            "UTF-32"});
            this.Tools_encoding.Name = "Tools_encoding";
            this.Tools_encoding.Size = new System.Drawing.Size(121, 25);
            this.Tools_encoding.SelectedIndexChanged += new System.EventHandler(this.Tools_encoding_SelectedIndexChanged);
            // 
            // scin
            // 
            this.scin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scin.IsReadOnly = false;
            this.scin.Location = new System.Drawing.Point(0, 25);
            this.scin.Name = "scin";
            this.scin.Size = new System.Drawing.Size(1007, 421);
            this.scin.TabIndex = 4;
            // 
            // UcCodeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.scin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UcCodeView";
            this.Size = new System.Drawing.Size(1007, 446);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox Tools_codetype;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox Tools_encoding;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Tools_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Tools_print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem Tools_zoomin;
        private System.Windows.Forms.ToolStripMenuItem Tools_zoomout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton Tools_insert;
        private ICSharpCode.TextEditor.TextEditorControl scin;
    }
}
