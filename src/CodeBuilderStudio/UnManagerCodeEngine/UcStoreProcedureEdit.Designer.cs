namespace UnManagerCodeEngine
{
    partial class UcStoreProcedureEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_dbtype = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gv_info = new System.Windows.Forms.DataGridView();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gv_setinfo = new System.Windows.Forms.DataGridView();
            this.dbcolumnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnManagertypename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_setinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "数据库字段类型";
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
            this.groupBox1.Size = new System.Drawing.Size(625, 60);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // Gv_info
            // 
            this.Gv_info.AllowUserToAddRows = false;
            this.Gv_info.AllowUserToDeleteRows = false;
            this.Gv_info.AllowUserToResizeColumns = false;
            this.Gv_info.AllowUserToResizeRows = false;
            this.Gv_info.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Gv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gv_info.DefaultCellStyle = dataGridViewCellStyle8;
            this.Gv_info.Location = new System.Drawing.Point(3, 84);
            this.Gv_info.Name = "Gv_info";
            this.Gv_info.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Gv_info.RowHeadersVisible = false;
            this.Gv_info.RowTemplate.Height = 18;
            this.Gv_info.Size = new System.Drawing.Size(165, 236);
            this.Gv_info.TabIndex = 10;
            // 
            // mark
            // 
            this.mark.DataPropertyName = "Remark";
            this.mark.HeaderText = "备注信息";
            this.mark.Name = "mark";
            // 
            // Gv_setinfo
            // 
            this.Gv_setinfo.AllowUserToResizeColumns = false;
            this.Gv_setinfo.AllowUserToResizeRows = false;
            this.Gv_setinfo.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_setinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Gv_setinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_setinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbcolumnname,
            this.UnManagertypename,
            this.mark});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gv_setinfo.DefaultCellStyle = dataGridViewCellStyle11;
            this.Gv_setinfo.Location = new System.Drawing.Point(174, 84);
            this.Gv_setinfo.Name = "Gv_setinfo";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_setinfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Gv_setinfo.RowHeadersVisible = false;
            this.Gv_setinfo.RowTemplate.Height = 18;
            this.Gv_setinfo.Size = new System.Drawing.Size(364, 236);
            this.Gv_setinfo.TabIndex = 9;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "CLI/托管类型\r\n";
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_save.Location = new System.Drawing.Point(546, 297);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(75, 23);
            this.Btn_save.TabIndex = 11;
            this.Btn_save.Text = "保存";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // UcStoreProcedureEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gv_info);
            this.Controls.Add(this.Gv_setinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_save);
            this.Name = "UcStoreProcedureEdit";
            this.Size = new System.Drawing.Size(625, 337);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_setinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_dbtype;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Gv_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridView Gv_setinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbcolumnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnManagertypename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_save;
    }
}
