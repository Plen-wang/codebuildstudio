﻿namespace DataSourceOpen.Come
{
    partial class FrmLookUpTable
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
            this.Tb_tbname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_tbname
            // 
            this.Tb_tbname.Location = new System.Drawing.Point(62, 11);
            this.Tb_tbname.Name = "Tb_tbname";
            this.Tb_tbname.Size = new System.Drawing.Size(117, 21);
            this.Tb_tbname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "表名称：";
            // 
            // Btn_start
            // 
            this.Btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_start.Location = new System.Drawing.Point(185, 11);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.Size = new System.Drawing.Size(75, 23);
            this.Btn_start.TabIndex = 2;
            this.Btn_start.Text = "开始检索";
            this.Btn_start.UseVisualStyleBackColor = true;
            this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lb_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_start);
            this.panel1.Controls.Add(this.Tb_tbname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 60);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Lb_close
            // 
            this.Lb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_close.AutoSize = true;
            this.Lb_close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_close.Location = new System.Drawing.Point(271, 0);
            this.Lb_close.Name = "Lb_close";
            this.Lb_close.Size = new System.Drawing.Size(16, 16);
            this.Lb_close.TabIndex = 4;
            this.Lb_close.Text = "+";
            this.Lb_close.MouseLeave += new System.EventHandler(this.Lb_close_MouseLeave);
            this.Lb_close.Click += new System.EventHandler(this.Lb_close_Click);
            this.Lb_close.MouseEnter += new System.EventHandler(this.Lb_close_MouseEnter);
            // 
            // FrmLookUpTable
            // 
            this.AcceptButton = this.Btn_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 60);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLookUpTable";
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

        private System.Windows.Forms.TextBox Tb_tbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_close;
    }
}