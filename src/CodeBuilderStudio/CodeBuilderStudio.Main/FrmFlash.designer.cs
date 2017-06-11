namespace CodeBuilderStudio.Main
{
    partial class FrmFlash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFlash));
            this.mainStartFlashControl1 = new CodeBuilderStudio.Control.MainStartFlashControl();
            this.SuspendLayout();
            // 
            // mainStartFlashControl1
            // 
            this.mainStartFlashControl1.BackColor = System.Drawing.Color.Transparent;
            this.mainStartFlashControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainStartFlashControl1.BackgroundImage")));
            this.mainStartFlashControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainStartFlashControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainStartFlashControl1.Location = new System.Drawing.Point(0, 0);
            this.mainStartFlashControl1.Name = "mainStartFlashControl1";
            this.mainStartFlashControl1.Size = new System.Drawing.Size(670, 416);
            this.mainStartFlashControl1.TabIndex = 0;
            // 
            // FrmFlash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 416);
            this.Controls.Add(this.mainStartFlashControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFlash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private CodeBuilderStudio.Control.MainStartFlashControl mainStartFlashControl1;


















    }
}