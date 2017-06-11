namespace SystemSetting.Come
{
    partial class UcSettingCodeThemp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_path = new System.Windows.Forms.TextBox();
            this.Btn_browser = new System.Windows.Forms.Button();
            this.Btn_setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "说明：系统读取模板文件的路径是以用户设置的为准，因为模板是属于用户信息的一部分。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "路径：";
            // 
            // Tb_path
            // 
            this.Tb_path.Location = new System.Drawing.Point(50, 29);
            this.Tb_path.Name = "Tb_path";
            this.Tb_path.Size = new System.Drawing.Size(390, 21);
            this.Tb_path.TabIndex = 2;
            // 
            // Btn_browser
            // 
            this.Btn_browser.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_browser.Location = new System.Drawing.Point(457, 28);
            this.Btn_browser.Name = "Btn_browser";
            this.Btn_browser.Size = new System.Drawing.Size(75, 23);
            this.Btn_browser.TabIndex = 3;
            this.Btn_browser.Text = "浏览";
            this.Btn_browser.UseVisualStyleBackColor = false;
            this.Btn_browser.Click += new System.EventHandler(this.Btn_browser_Click);
            // 
            // Btn_setting
            // 
            this.Btn_setting.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_setting.Location = new System.Drawing.Point(545, 28);
            this.Btn_setting.Name = "Btn_setting";
            this.Btn_setting.Size = new System.Drawing.Size(75, 23);
            this.Btn_setting.TabIndex = 3;
            this.Btn_setting.Text = "设置";
            this.Btn_setting.UseVisualStyleBackColor = false;
            this.Btn_setting.Click += new System.EventHandler(this.Btn_setting_Click);
            // 
            // UcSettingCodeThemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Btn_setting);
            this.Controls.Add(this.Btn_browser);
            this.Controls.Add(this.Tb_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcSettingCodeThemp";
            this.Size = new System.Drawing.Size(641, 271);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_path;
        private System.Windows.Forms.Button Btn_browser;
        private System.Windows.Forms.Button Btn_setting;
    }
}
