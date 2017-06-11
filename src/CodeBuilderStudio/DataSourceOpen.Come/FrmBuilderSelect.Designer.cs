namespace DataSourceOpen.Come
{
    partial class FrmBuilderSelect
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
            this.Lb_tbname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_buildersele = new System.Windows.Forms.Button();
            this.Lb_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lb_tbname);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Btn_buildersele);
            this.panel1.Controls.Add(this.Lb_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 278);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Lb_tbname
            // 
            this.Lb_tbname.AutoSize = true;
            this.Lb_tbname.Location = new System.Drawing.Point(3, 4);
            this.Lb_tbname.Name = "Lb_tbname";
            this.Lb_tbname.Size = new System.Drawing.Size(59, 12);
            this.Lb_tbname.TabIndex = 6;
            this.Lb_tbname.Text = "Lb_tbname";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(5, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "打印该表信息";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn_buildersele
            // 
            this.Btn_buildersele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_buildersele.Location = new System.Drawing.Point(5, 36);
            this.Btn_buildersele.Name = "Btn_buildersele";
            this.Btn_buildersele.Size = new System.Drawing.Size(157, 27);
            this.Btn_buildersele.TabIndex = 5;
            this.Btn_buildersele.Text = "常用代码生成";
            this.Btn_buildersele.UseVisualStyleBackColor = true;
            this.Btn_buildersele.Click += new System.EventHandler(this.Btn_buildersele_Click);
            // 
            // Lb_close
            // 
            this.Lb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_close.AutoSize = true;
            this.Lb_close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_close.Location = new System.Drawing.Point(148, 4);
            this.Lb_close.Name = "Lb_close";
            this.Lb_close.Size = new System.Drawing.Size(16, 16);
            this.Lb_close.TabIndex = 4;
            this.Lb_close.Text = "+";
            this.Lb_close.MouseLeave += new System.EventHandler(this.Lb_close_MouseLeave);
            this.Lb_close.Click += new System.EventHandler(this.Lb_close_Click);
            this.Lb_close.MouseEnter += new System.EventHandler(this.Lb_close_MouseEnter);
            // 
            // FrmBuilderSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 278);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuilderSelect";
            this.Opacity = 0.9;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "检索表名称";
            this.Deactivate += new System.EventHandler(this.FrmLookUp_Deactivate);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_close;
        private System.Windows.Forms.Button Btn_buildersele;
        public System.Windows.Forms.Label Lb_tbname;
        private System.Windows.Forms.Button button1;
    }
}