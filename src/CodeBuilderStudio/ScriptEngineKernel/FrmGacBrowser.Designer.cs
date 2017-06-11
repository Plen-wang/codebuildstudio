namespace ScriptEngineKernel
{
    partial class FrmGacBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGacBrowser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_canel = new System.Windows.Forms.Button();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.Lv_dll = new System.Windows.Forms.ListView();
            this.HeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Headversion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeadPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btn_canel);
            this.panel1.Controls.Add(this.Btn_ok);
            this.panel1.Controls.Add(this.Lv_dll);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Btn_canel
            // 
            resources.ApplyResources(this.Btn_canel, "Btn_canel");
            this.Btn_canel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_canel.Name = "Btn_canel";
            this.Btn_canel.UseVisualStyleBackColor = true;
            // 
            // Btn_ok
            // 
            resources.ApplyResources(this.Btn_ok, "Btn_ok");
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.UseVisualStyleBackColor = true;
            // 
            // Lv_dll
            // 
            this.Lv_dll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeadName,
            this.Headversion,
            this.HeadPath});
            resources.ApplyResources(this.Lv_dll, "Lv_dll");
            this.Lv_dll.Name = "Lv_dll";
            this.Lv_dll.UseCompatibleStateImageBehavior = false;
            this.Lv_dll.View = System.Windows.Forms.View.Details;
            // 
            // HeadName
            // 
            resources.ApplyResources(this.HeadName, "HeadName");
            // 
            // Headversion
            // 
            resources.ApplyResources(this.Headversion, "Headversion");
            // 
            // HeadPath
            // 
            resources.ApplyResources(this.HeadPath, "HeadPath");
            // 
            // FrmGacBrowser
            // 
            this.AcceptButton = this.Btn_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_canel;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGacBrowser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_canel;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.ListView Lv_dll;
        private System.Windows.Forms.ColumnHeader HeadName;
        private System.Windows.Forms.ColumnHeader Headversion;
        private System.Windows.Forms.ColumnHeader HeadPath;
    }
}