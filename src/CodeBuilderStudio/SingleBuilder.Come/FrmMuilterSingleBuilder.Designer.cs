namespace SingleBuilder.Come
{
    partial class FrmMuilterSingleBuilder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Clb_tblist = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Cb_statecheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Btn_look = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_prname = new System.Windows.Forms.TextBox();
            this.Cb_store = new System.Windows.Forms.CheckBox();
            this.Clb_tempfile = new System.Windows.Forms.CheckedListBox();
            this.Btn_builder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_browserpath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_path = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Btn_esc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 393);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 357);
            this.panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.Clb_tblist);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Size = new System.Drawing.Size(876, 355);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 2;
            // 
            // Clb_tblist
            // 
            this.Clb_tblist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clb_tblist.FormattingEnabled = true;
            this.Clb_tblist.Location = new System.Drawing.Point(0, 27);
            this.Clb_tblist.Name = "Clb_tblist";
            this.Clb_tblist.Size = new System.Drawing.Size(206, 324);
            this.Clb_tblist.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Cb_statecheck);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 27);
            this.panel4.TabIndex = 2;
            // 
            // Cb_statecheck
            // 
            this.Cb_statecheck.AutoSize = true;
            this.Cb_statecheck.Location = new System.Drawing.Point(136, 6);
            this.Cb_statecheck.Name = "Cb_statecheck";
            this.Cb_statecheck.Size = new System.Drawing.Size(48, 16);
            this.Cb_statecheck.TabIndex = 5;
            this.Cb_statecheck.Text = "全选";
            this.Cb_statecheck.UseVisualStyleBackColor = true;
            this.Cb_statecheck.CheckedChanged += new System.EventHandler(this.Cb_statecheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择生成的表";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Btn_look);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.Tb_prname);
            this.panel6.Controls.Add(this.Cb_store);
            this.panel6.Controls.Add(this.Clb_tempfile);
            this.panel6.Controls.Add(this.Btn_builder);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.Btn_browserpath);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.Tb_path);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(658, 304);
            this.panel6.TabIndex = 4;
            // 
            // Btn_look
            // 
            this.Btn_look.Location = new System.Drawing.Point(250, 277);
            this.Btn_look.Name = "Btn_look";
            this.Btn_look.Size = new System.Drawing.Size(75, 23);
            this.Btn_look.TabIndex = 7;
            this.Btn_look.Text = "搜索";
            this.Btn_look.UseVisualStyleBackColor = true;
            this.Btn_look.Click += new System.EventHandler(this.Btn_look_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "搜索：";
            // 
            // Tb_prname
            // 
            this.Tb_prname.Location = new System.Drawing.Point(57, 278);
            this.Tb_prname.Name = "Tb_prname";
            this.Tb_prname.Size = new System.Drawing.Size(187, 21);
            this.Tb_prname.TabIndex = 5;
            // 
            // Cb_store
            // 
            this.Cb_store.AutoSize = true;
            this.Cb_store.Location = new System.Drawing.Point(15, 254);
            this.Cb_store.Name = "Cb_store";
            this.Cb_store.Size = new System.Drawing.Size(72, 16);
            this.Cb_store.TabIndex = 4;
            this.Cb_store.Text = "存储过程";
            this.Cb_store.UseVisualStyleBackColor = true;
            this.Cb_store.CheckedChanged += new System.EventHandler(this.Cb_store_CheckedChanged);
            // 
            // Clb_tempfile
            // 
            this.Clb_tempfile.BackColor = System.Drawing.Color.White;
            this.Clb_tempfile.FormattingEnabled = true;
            this.Clb_tempfile.Location = new System.Drawing.Point(119, 48);
            this.Clb_tempfile.Name = "Clb_tempfile";
            this.Clb_tempfile.Size = new System.Drawing.Size(435, 196);
            this.Clb_tempfile.TabIndex = 3;
            // 
            // Btn_builder
            // 
            this.Btn_builder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_builder.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_builder.Location = new System.Drawing.Point(467, 250);
            this.Btn_builder.Name = "Btn_builder";
            this.Btn_builder.Size = new System.Drawing.Size(87, 23);
            this.Btn_builder.TabIndex = 0;
            this.Btn_builder.Text = "生成(&B)";
            this.Btn_builder.UseVisualStyleBackColor = false;
            this.Btn_builder.Click += new System.EventHandler(this.Btn_builder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "保存文件的路径：";
            // 
            // Btn_browserpath
            // 
            this.Btn_browserpath.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_browserpath.Location = new System.Drawing.Point(561, 8);
            this.Btn_browserpath.Name = "Btn_browserpath";
            this.Btn_browserpath.Size = new System.Drawing.Size(87, 23);
            this.Btn_browserpath.TabIndex = 2;
            this.Btn_browserpath.Text = "浏览(&S)";
            this.Btn_browserpath.UseVisualStyleBackColor = false;
            this.Btn_browserpath.Click += new System.EventHandler(this.Btn_browserpath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "选择生成的模板：";
            // 
            // Tb_path
            // 
            this.Tb_path.BackColor = System.Drawing.Color.White;
            this.Tb_path.Location = new System.Drawing.Point(119, 9);
            this.Tb_path.Name = "Tb_path";
            this.Tb_path.ReadOnly = true;
            this.Tb_path.Size = new System.Drawing.Size(435, 21);
            this.Tb_path.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(658, 47);
            this.panel5.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(650, 39);
            this.panel7.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(9, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "设置生成基本项";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.Btn_esc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 32);
            this.panel3.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 4);
            this.progressBar1.Maximum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(669, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // Btn_esc
            // 
            this.Btn_esc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_esc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_esc.Location = new System.Drawing.Point(778, 3);
            this.Btn_esc.Name = "Btn_esc";
            this.Btn_esc.Size = new System.Drawing.Size(87, 23);
            this.Btn_esc.TabIndex = 0;
            this.Btn_esc.Text = "关闭(&E)";
            this.Btn_esc.UseVisualStyleBackColor = true;
            // 
            // FrmMuilterSingleBuilder
            // 
            this.AcceptButton = this.Btn_builder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_esc;
            this.ClientSize = new System.Drawing.Size(884, 395);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMuilterSingleBuilder";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "对表、视图的代码生成";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_esc;
        private System.Windows.Forms.Button Btn_builder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_path;
        private System.Windows.Forms.Button Btn_browserpath;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox Cb_statecheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox Clb_tempfile;
        private System.Windows.Forms.CheckedListBox Clb_tblist;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox Cb_store;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_prname;
        private System.Windows.Forms.Button Btn_look;
    }
}