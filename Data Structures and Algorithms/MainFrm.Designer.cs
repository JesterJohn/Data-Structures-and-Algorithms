namespace Data_Structures_and_Algorithms
{
    partial class MainFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOS1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOS2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOS3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pOS4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOS5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2564, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOS1ToolStripMenuItem,
            this.pOS2ToolStripMenuItem,
            this.pOS3ToolStripMenuItem,
            this.pOS4ToolStripMenuItem,
            this.pOS5ToolStripMenuItem});
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.pOSToolStripMenuItem.Text = "POS";
            this.pOSToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // pOS1ToolStripMenuItem
            // 
            this.pOS1ToolStripMenuItem.Name = "pOS1ToolStripMenuItem";
            this.pOS1ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pOS1ToolStripMenuItem.Text = "POS 1";
            this.pOS1ToolStripMenuItem.Click += new System.EventHandler(this.pOS1ToolStripMenuItem_Click);
            // 
            // pOS2ToolStripMenuItem
            // 
            this.pOS2ToolStripMenuItem.Name = "pOS2ToolStripMenuItem";
            this.pOS2ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pOS2ToolStripMenuItem.Text = "POS 2";
            this.pOS2ToolStripMenuItem.Click += new System.EventHandler(this.pOS2ToolStripMenuItem_Click);
            // 
            // pOS3ToolStripMenuItem
            // 
            this.pOS3ToolStripMenuItem.Name = "pOS3ToolStripMenuItem";
            this.pOS3ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pOS3ToolStripMenuItem.Text = "POS 3";
            this.pOS3ToolStripMenuItem.Click += new System.EventHandler(this.pOS3ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(2564, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pOS4ToolStripMenuItem
            // 
            this.pOS4ToolStripMenuItem.Name = "pOS4ToolStripMenuItem";
            this.pOS4ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pOS4ToolStripMenuItem.Text = "POS 4";
            this.pOS4ToolStripMenuItem.Click += new System.EventHandler(this.pOS4ToolStripMenuItem_Click);
            // 
            // pOS5ToolStripMenuItem
            // 
            this.pOS5ToolStripMenuItem.Name = "pOS5ToolStripMenuItem";
            this.pOS5ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pOS5ToolStripMenuItem.Text = "POS 5 ";
            this.pOS5ToolStripMenuItem.Click += new System.EventHandler(this.pOS5ToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(2564, 1570);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOS1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOS2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOS3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOS4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOS5ToolStripMenuItem;
    }
}