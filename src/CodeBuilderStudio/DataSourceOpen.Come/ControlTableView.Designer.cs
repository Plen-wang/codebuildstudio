namespace DataSourceOpen.Come
{
    partial class ControlTableView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTableView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_tbname = new System.Windows.Forms.Label();
            this.Lb_close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tb_count = new System.Windows.Forms.Label();
            this.Lb_size = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tb_Columns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lb_tbname);
            this.panel1.Controls.Add(this.Lb_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 23);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Lb_tbname
            // 
            this.Lb_tbname.AutoSize = true;
            this.Lb_tbname.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lb_tbname.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_tbname.ForeColor = System.Drawing.Color.White;
            this.Lb_tbname.Location = new System.Drawing.Point(0, 0);
            this.Lb_tbname.Name = "Lb_tbname";
            this.Lb_tbname.Size = new System.Drawing.Size(63, 14);
            this.Lb_tbname.TabIndex = 5;
            this.Lb_tbname.Text = "TB_user";
            // 
            // Lb_close
            // 
            this.Lb_close.AutoSize = true;
            this.Lb_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lb_close.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_close.Location = new System.Drawing.Point(182, 0);
            this.Lb_close.Name = "Lb_close";
            this.Lb_close.Size = new System.Drawing.Size(17, 18);
            this.Lb_close.TabIndex = 0;
            this.Lb_close.Text = "+";
            this.Lb_close.Click += new System.EventHandler(this.Lb_close_Click);
            this.Lb_close.MouseEnter += new System.EventHandler(this.Lb_close_MouseEnter);
            this.Lb_close.MouseLeave += new System.EventHandler(this.Lb_close_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Tb_count);
            this.panel2.Controls.Add(this.Lb_size);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 15);
            this.panel2.TabIndex = 5;
            // 
            // Tb_count
            // 
            this.Tb_count.AutoSize = true;
            this.Tb_count.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tb_count.Location = new System.Drawing.Point(0, 0);
            this.Tb_count.Name = "Tb_count";
            this.Tb_count.Size = new System.Drawing.Size(35, 12);
            this.Tb_count.TabIndex = 6;
            this.Tb_count.Text = "count";
            // 
            // Lb_size
            // 
            this.Lb_size.AutoSize = true;
            this.Lb_size.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Lb_size.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lb_size.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_size.Image = ((System.Drawing.Image)(resources.GetObject("Lb_size.Image")));
            this.Lb_size.Location = new System.Drawing.Point(185, 0);
            this.Lb_size.Name = "Lb_size";
            this.Lb_size.Size = new System.Drawing.Size(14, 14);
            this.Lb_size.TabIndex = 5;
            this.Lb_size.Text = " ";
            this.Lb_size.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lb_size_MouseDown);
            this.Lb_size.MouseEnter += new System.EventHandler(this.Lb_size_MouseEnter);
            this.Lb_size.MouseLeave += new System.EventHandler(this.Lb_size_MouseLeave);
            this.Lb_size.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lb_size_MouseMove);
            this.Lb_size.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lb_size_MouseUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tb_Columns});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 16;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(201, 319);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // Tb_Columns
            // 
            this.Tb_Columns.DataPropertyName = "tbcolumname";
            this.Tb_Columns.HeaderText = "列集合";
            this.Tb_Columns.Name = "Tb_Columns";
            this.Tb_Columns.ReadOnly = true;
            this.Tb_Columns.Width = 200;
            // 
            // ControlTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "ControlTableView";
            this.Size = new System.Drawing.Size(201, 357);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lb_close;
        private System.Windows.Forms.Label Lb_size;
        private System.Windows.Forms.Label Lb_tbname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tb_Columns;
        private System.Windows.Forms.Label Tb_count;
    }
}
