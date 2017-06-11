namespace ThempEdit.Come
{
    partial class UcEditMaster
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
            this.explorerBar1 = new DevComponents.DotNetBar.ExplorerBar();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // explorerBar1
            // 
            this.explorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.explorerBar1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.explorerBar1.BackStyle.BackColor = System.Drawing.SystemColors.Control;
            this.explorerBar1.BackStyle.BackColor2 = System.Drawing.Color.Transparent;
            this.explorerBar1.BackStyle.BackColorGradientAngle = 90;
            this.explorerBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.explorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerBar1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.explorerBar1.GroupImages = null;
            this.explorerBar1.Images = null;
            this.explorerBar1.Location = new System.Drawing.Point(0, 0);
            this.explorerBar1.Name = "explorerBar1";
            this.explorerBar1.ShowToolTips = false;
            this.explorerBar1.Size = new System.Drawing.Size(185, 515);
            this.explorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.OliveGreenSpecial;
            this.explorerBar1.TabIndex = 1;
            // 
            // UcEditMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.explorerBar1);
            this.Name = "UcEditMaster";
            this.Size = new System.Drawing.Size(185, 515);
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExplorerBar explorerBar1;

    }
}
