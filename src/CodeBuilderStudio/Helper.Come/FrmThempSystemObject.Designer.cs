namespace Helper.Come
{
    partial class FrmThempSystemObject
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("CurrentDayTime");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("DefaultNameSpace");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("系统常量查询", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucCodeView1 = new ComeCommonMethod.UcCodeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ucCodeView1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 395);
            this.panel1.TabIndex = 1;
            // 
            // ucCodeView1
            // 
            this.ucCodeView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucCodeView1.CodeText = null;
            this.ucCodeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCodeView1.Location = new System.Drawing.Point(198, 0);
            this.ucCodeView1.Name = "ucCodeView1";
            this.ucCodeView1.Size = new System.Drawing.Size(588, 391);
            this.ucCodeView1.TabIndex = 2;
            this.ucCodeView1.ToolsVisble = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "CurrentDayTime";
            treeNode1.Text = "CurrentDayTime";
            treeNode2.Name = "DefaultNameSpace";
            treeNode2.Text = "DefaultNameSpace";
            treeNode3.Name = "System";
            treeNode3.Text = "System";
            treeNode4.Name = "节点0";
            treeNode4.Text = "系统常量查询";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(198, 391);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // FrmThempSystemObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 395);
            this.Controls.Add(this.panel1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Float;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmThempSystemObject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "系统帮助";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComeCommonMethod.UcCodeView ucCodeView1;
        private System.Windows.Forms.TreeView treeView1;

    }
}