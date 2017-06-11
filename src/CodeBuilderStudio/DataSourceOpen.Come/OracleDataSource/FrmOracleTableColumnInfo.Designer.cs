namespace DataSourceOpen.Come
{
    partial class FrmOracleTableColumnInfo
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
            this.Btn_builder = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.列名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数据类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数据长度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数值长度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小数点位数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否允许空 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.列序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.缺省值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_builder);
            this.panel1.Controls.Add(this.Btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 32);
            this.panel1.TabIndex = 11;
            // 
            // Btn_builder
            // 
            this.Btn_builder.Location = new System.Drawing.Point(492, 4);
            this.Btn_builder.Name = "Btn_builder";
            this.Btn_builder.Size = new System.Drawing.Size(87, 23);
            this.Btn_builder.TabIndex = 8;
            this.Btn_builder.Text = "生成(&B)";
            this.Btn_builder.UseVisualStyleBackColor = true;
            this.Btn_builder.Click += new System.EventHandler(this.Btn_builder_Click);
            // 
            // Btn_close
            // 
            this.Btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_close.Location = new System.Drawing.Point(599, 4);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(87, 23);
            this.Btn_close.TabIndex = 8;
            this.Btn_close.Text = "关闭(&C)";
            this.Btn_close.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.列名,
            this.数据类型,
            this.数据长度,
            this.数值长度,
            this.小数点位数,
            this.是否允许空,
            this.列序号,
            this.缺省值});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 16;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(694, 257);
            this.dataGridView1.TabIndex = 10;
            // 
            // 列名
            // 
            this.列名.DataPropertyName = "COLUMN_NAME";
            this.列名.HeaderText = "列名";
            this.列名.Name = "列名";
            this.列名.ReadOnly = true;
            this.列名.Width = 150;
            // 
            // 数据类型
            // 
            this.数据类型.DataPropertyName = "DATA_TYPE";
            this.数据类型.HeaderText = "列类型";
            this.数据类型.Name = "数据类型";
            this.数据类型.ReadOnly = true;
            this.数据类型.Width = 150;
            // 
            // 数据长度
            // 
            this.数据长度.DataPropertyName = "DATA_LENGTH";
            this.数据长度.HeaderText = "列长度";
            this.数据长度.Name = "数据长度";
            this.数据长度.ReadOnly = true;
            this.数据长度.Width = 150;
            // 
            // 数值长度
            // 
            this.数值长度.DataPropertyName = "DATA_PRECISION";
            this.数值长度.HeaderText = "数值长度";
            this.数值长度.Name = "数值长度";
            this.数值长度.ReadOnly = true;
            // 
            // 小数点位数
            // 
            this.小数点位数.DataPropertyName = "DATA_SCALE";
            this.小数点位数.HeaderText = "小数点位数";
            this.小数点位数.Name = "小数点位数";
            this.小数点位数.ReadOnly = true;
            // 
            // 是否允许空
            // 
            this.是否允许空.DataPropertyName = "NULLABLE";
            this.是否允许空.HeaderText = "是否允许空";
            this.是否允许空.Name = "是否允许空";
            this.是否允许空.ReadOnly = true;
            // 
            // 列序号
            // 
            this.列序号.DataPropertyName = "COLUMN_ID";
            this.列序号.HeaderText = "列序号";
            this.列序号.Name = "列序号";
            this.列序号.ReadOnly = true;
            // 
            // 缺省值
            // 
            this.缺省值.DataPropertyName = "DATA_DEFAULT";
            this.缺省值.HeaderText = "缺省值";
            this.缺省值.Name = "缺省值";
            this.缺省值.ReadOnly = true;
            // 
            // FrmOracleTableColumnInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 289);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOracleTableColumnInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "列的信息";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_builder;
        private System.Windows.Forms.Button Btn_close;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 列名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数据类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数据长度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数值长度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小数点位数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否允许空;
        private System.Windows.Forms.DataGridViewTextBoxColumn 列序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 缺省值;
    }
}