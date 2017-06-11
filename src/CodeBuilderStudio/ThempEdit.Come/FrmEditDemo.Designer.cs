namespace ThempEdit.Come
{
    partial class FrmEditDemo
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
            this.ucCodeView1 = new ComeCommonMethod.UcCodeView();
            this.SuspendLayout();
            // 
            // ucCodeView1
            // 
            this.ucCodeView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucCodeView1.CodeText = null;
            this.ucCodeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCodeView1.Location = new System.Drawing.Point(0, 0);
            this.ucCodeView1.Name = "ucCodeView1";
            this.ucCodeView1.Size = new System.Drawing.Size(774, 345);
            this.ucCodeView1.TabIndex = 0;
            // 
            // FrmEditDemo
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 345);
            this.Controls.Add(this.ucCodeView1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Float;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmEditDemo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TabText = "";
            this.ResumeLayout(false);

        }

        #endregion

        private ComeCommonMethod.UcCodeView ucCodeView1;
    }
}