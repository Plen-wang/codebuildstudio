namespace DataSourceOpen.Come
{
    partial class FrmLoginDataSource
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_savepwd = new System.Windows.Forms.CheckBox();
            this.Tb_pwd = new System.Windows.Forms.TextBox();
            this.Tb_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P_logninfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_sqlserver = new System.Windows.Forms.RadioButton();
            this.Rb_window = new System.Windows.Forms.RadioButton();
            this.Tb_close = new System.Windows.Forms.Button();
            this.Bt_acceptconn = new System.Windows.Forms.Button();
            this.Bt_enter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tb_dbname = new System.Windows.Forms.TextBox();
            this.Cb_savefromdata = new System.Windows.Forms.CheckBox();
            this.Tb_dbserver = new System.Windows.Forms.TextBox();
            this.P_logninfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "服务器名:";
            // 
            // Cb_savepwd
            // 
            this.Cb_savepwd.AutoSize = true;
            this.Cb_savepwd.Location = new System.Drawing.Point(56, 68);
            this.Cb_savepwd.Name = "Cb_savepwd";
            this.Cb_savepwd.Size = new System.Drawing.Size(90, 16);
            this.Cb_savepwd.TabIndex = 10;
            this.Cb_savepwd.Text = "保存密码(&S)";
            this.Cb_savepwd.UseVisualStyleBackColor = true;
            // 
            // Tb_pwd
            // 
            this.Tb_pwd.Location = new System.Drawing.Point(56, 38);
            this.Tb_pwd.Name = "Tb_pwd";
            this.Tb_pwd.PasswordChar = '*';
            this.Tb_pwd.Size = new System.Drawing.Size(254, 21);
            this.Tb_pwd.TabIndex = 9;
            this.Tb_pwd.UseSystemPasswordChar = true;
            // 
            // Tb_user
            // 
            this.Tb_user.Location = new System.Drawing.Point(56, 6);
            this.Tb_user.Name = "Tb_user";
            this.Tb_user.Size = new System.Drawing.Size(254, 21);
            this.Tb_user.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "密码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户名:";
            // 
            // P_logninfo
            // 
            this.P_logninfo.Controls.Add(this.Cb_savepwd);
            this.P_logninfo.Controls.Add(this.Tb_pwd);
            this.P_logninfo.Controls.Add(this.Tb_user);
            this.P_logninfo.Controls.Add(this.label3);
            this.P_logninfo.Controls.Add(this.label2);
            this.P_logninfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.P_logninfo.Enabled = false;
            this.P_logninfo.Location = new System.Drawing.Point(3, 86);
            this.P_logninfo.Name = "P_logninfo";
            this.P_logninfo.Size = new System.Drawing.Size(313, 90);
            this.P_logninfo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.P_logninfo);
            this.groupBox1.Controls.Add(this.Rb_sqlserver);
            this.groupBox1.Controls.Add(this.Rb_window);
            this.groupBox1.Location = new System.Drawing.Point(8, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 179);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录到服务器";
            // 
            // Rb_sqlserver
            // 
            this.Rb_sqlserver.AutoSize = true;
            this.Rb_sqlserver.Location = new System.Drawing.Point(6, 64);
            this.Rb_sqlserver.Name = "Rb_sqlserver";
            this.Rb_sqlserver.Size = new System.Drawing.Size(179, 16);
            this.Rb_sqlserver.TabIndex = 2;
            this.Rb_sqlserver.Text = "使用 SQLServer 身份认证(&Q)";
            this.Rb_sqlserver.UseVisualStyleBackColor = true;
            this.Rb_sqlserver.CheckedChanged += new System.EventHandler(this.Rb_sqlserver_CheckedChanged);
            // 
            // Rb_window
            // 
            this.Rb_window.AutoSize = true;
            this.Rb_window.Checked = true;
            this.Rb_window.Location = new System.Drawing.Point(6, 31);
            this.Rb_window.Name = "Rb_window";
            this.Rb_window.Size = new System.Drawing.Size(167, 16);
            this.Rb_window.TabIndex = 1;
            this.Rb_window.TabStop = true;
            this.Rb_window.Text = "使用 Windows 身份认证(&W)";
            this.Rb_window.UseVisualStyleBackColor = true;
            // 
            // Tb_close
            // 
            this.Tb_close.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Tb_close.Location = new System.Drawing.Point(252, 329);
            this.Tb_close.Name = "Tb_close";
            this.Tb_close.Size = new System.Drawing.Size(75, 23);
            this.Tb_close.TabIndex = 25;
            this.Tb_close.Text = "取消(&Esc)";
            this.Tb_close.UseVisualStyleBackColor = true;
            // 
            // Bt_acceptconn
            // 
            this.Bt_acceptconn.Location = new System.Drawing.Point(8, 329);
            this.Bt_acceptconn.Name = "Bt_acceptconn";
            this.Bt_acceptconn.Size = new System.Drawing.Size(83, 23);
            this.Bt_acceptconn.TabIndex = 23;
            this.Bt_acceptconn.Text = "测试连接(&T)";
            this.Bt_acceptconn.UseVisualStyleBackColor = true;
            this.Bt_acceptconn.Click += new System.EventHandler(this.Bt_acceptconn_Click);
            // 
            // Bt_enter
            // 
            this.Bt_enter.Location = new System.Drawing.Point(157, 329);
            this.Bt_enter.Name = "Bt_enter";
            this.Bt_enter.Size = new System.Drawing.Size(79, 23);
            this.Bt_enter.TabIndex = 24;
            this.Bt_enter.Text = "确定(&Enter)";
            this.Bt_enter.UseVisualStyleBackColor = true;
            this.Bt_enter.Click += new System.EventHandler(this.Bt_enter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "数据库名:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Tb_dbname);
            this.groupBox2.Location = new System.Drawing.Point(8, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 74);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "连接到一个数据库";
            // 
            // Tb_dbname
            // 
            this.Tb_dbname.Location = new System.Drawing.Point(69, 24);
            this.Tb_dbname.Name = "Tb_dbname";
            this.Tb_dbname.Size = new System.Drawing.Size(244, 21);
            this.Tb_dbname.TabIndex = 6;
            // 
            // Cb_savefromdata
            // 
            this.Cb_savefromdata.AutoSize = true;
            this.Cb_savefromdata.Location = new System.Drawing.Point(8, 305);
            this.Cb_savefromdata.Name = "Cb_savefromdata";
            this.Cb_savefromdata.Size = new System.Drawing.Size(156, 16);
            this.Cb_savefromdata.TabIndex = 26;
            this.Cb_savefromdata.Text = "保存服务器、数据库名称";
            this.Cb_savefromdata.UseVisualStyleBackColor = true;
            // 
            // Tb_dbserver
            // 
            this.Tb_dbserver.Location = new System.Drawing.Point(70, 2);
            this.Tb_dbserver.Name = "Tb_dbserver";
            this.Tb_dbserver.Size = new System.Drawing.Size(254, 21);
            this.Tb_dbserver.TabIndex = 27;
            // 
            // FrmLoginDataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 354);
            this.Controls.Add(this.Tb_dbserver);
            this.Controls.Add(this.Cb_savefromdata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tb_close);
            this.Controls.Add(this.Bt_acceptconn);
            this.Controls.Add(this.Bt_enter);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoginDataSource";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录数据源";
            this.P_logninfo.ResumeLayout(false);
            this.P_logninfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Cb_savepwd;
        private System.Windows.Forms.TextBox Tb_pwd;
        private System.Windows.Forms.TextBox Tb_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel P_logninfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_sqlserver;
        private System.Windows.Forms.RadioButton Rb_window;
        private System.Windows.Forms.Button Tb_close;
        private System.Windows.Forms.Button Bt_acceptconn;
        private System.Windows.Forms.Button Bt_enter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Tb_dbname;
        private System.Windows.Forms.CheckBox Cb_savefromdata;
        private System.Windows.Forms.TextBox Tb_dbserver;
    }
}