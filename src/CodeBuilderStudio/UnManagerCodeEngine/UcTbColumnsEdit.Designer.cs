namespace UnManagerCodeEngine
{
    partial class UcTbColumnsEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gv_setinfo = new System.Windows.Forms.DataGridView();
            this.dbcolumnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnManagertypename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gv_info = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_dbtype = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_setinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_info)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库字段类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLI/托管类型\r\n";
            // 
            // Gv_setinfo
            // 
            this.Gv_setinfo.AllowUserToResizeColumns = false;
            this.Gv_setinfo.AllowUserToResizeRows = false;
            this.Gv_setinfo.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_setinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv_setinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_setinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbcolumnname,
            this.UnManagertypename,
            this.mark});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gv_setinfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gv_setinfo.Location = new System.Drawing.Point(174, 98);
            this.Gv_setinfo.Name = "Gv_setinfo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_setinfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Gv_setinfo.RowHeadersVisible = false;
            this.Gv_setinfo.RowTemplate.Height = 18;
            this.Gv_setinfo.Size = new System.Drawing.Size(364, 236);
            this.Gv_setinfo.TabIndex = 2;
            // 
            // dbcolumnname
            // 
            this.dbcolumnname.DataPropertyName = "DataType";
            this.dbcolumnname.HeaderText = "数据库字段名称";
            this.dbcolumnname.Name = "dbcolumnname";
            this.dbcolumnname.Width = 140;
            // 
            // UnManagertypename
            // 
            this.UnManagertypename.DataPropertyName = "UnmanagerType";
            this.UnManagertypename.HeaderText = "托管数据类型名称";
            this.UnManagertypename.Name = "UnManagertypename";
            this.UnManagertypename.Width = 140;
            // 
            // mark
            // 
            this.mark.DataPropertyName = "Remark";
            this.mark.HeaderText = "备注信息";
            this.mark.Name = "mark";
            // 
            // Gv_info
            // 
            this.Gv_info.AllowUserToAddRows = false;
            this.Gv_info.AllowUserToDeleteRows = false;
            this.Gv_info.AllowUserToResizeColumns = false;
            this.Gv_info.AllowUserToResizeRows = false;
            this.Gv_info.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Gv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gv_info.DefaultCellStyle = dataGridViewCellStyle5;
            this.Gv_info.Location = new System.Drawing.Point(3, 98);
            this.Gv_info.Name = "Gv_info";
            this.Gv_info.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Gv_info.RowHeadersVisible = false;
            this.Gv_info.RowTemplate.Height = 18;
            this.Gv_info.Size = new System.Drawing.Size(165, 236);
            this.Gv_info.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ColumnName";
            this.dataGridViewTextBoxColumn1.HeaderText = "数据库字段名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据库类型：";
            // 
            // Cb_dbtype
            // 
            this.Cb_dbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_dbtype.FormattingEnabled = true;
            this.Cb_dbtype.Items.AddRange(new object[] {
            "Microsoft SqlServer",
            "Oracle"});
            this.Cb_dbtype.Location = new System.Drawing.Point(97, 20);
            this.Cb_dbtype.Name = "Cb_dbtype";
            this.Cb_dbtype.Size = new System.Drawing.Size(145, 20);
            this.Cb_dbtype.TabIndex = 5;
            this.Cb_dbtype.SelectedIndexChanged += new System.EventHandler(this.Cb_dbtype_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cb_dbtype);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_save.Location = new System.Drawing.Point(546, 311);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(75, 23);
            this.Btn_save.TabIndex = 6;
            this.Btn_save.Text = "保存";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // UcTbColumnsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gv_info);
            this.Controls.Add(this.Gv_setinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcTbColumnsEdit";
            this.Size = new System.Drawing.Size(646, 337);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_setinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_info)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Gv_setinfo;
        private System.Windows.Forms.DataGridView Gv_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_dbtype;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbcolumnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnManagertypename;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
    }
}
