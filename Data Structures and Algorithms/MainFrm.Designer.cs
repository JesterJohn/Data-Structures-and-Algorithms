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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOS1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOS2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOS3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1904, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOS1ToolStripMenuItem,
            this.pOS2ToolStripMenuItem,
            this.pOS3ToolStripMenuItem});
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.pOSToolStripMenuItem.Text = "POS";
            this.pOSToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // pOS1ToolStripMenuItem
            // 
            this.pOS1ToolStripMenuItem.Name = "pOS1ToolStripMenuItem";
            this.pOS1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pOS1ToolStripMenuItem.Text = "POS 1";
            this.pOS1ToolStripMenuItem.Click += new System.EventHandler(this.pOS1ToolStripMenuItem_Click);
            // 
            // pOS2ToolStripMenuItem
            // 
            this.pOS2ToolStripMenuItem.Name = "pOS2ToolStripMenuItem";
            this.pOS2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pOS2ToolStripMenuItem.Text = "POS 2";
            this.pOS2ToolStripMenuItem.Click += new System.EventHandler(this.pOS2ToolStripMenuItem_Click);
            // 
            // pOS3ToolStripMenuItem
            // 
            this.pOS3ToolStripMenuItem.Name = "pOS3ToolStripMenuItem";
            this.pOS3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pOS3ToolStripMenuItem.Text = "POS 3";
            this.pOS3ToolStripMenuItem.Click += new System.EventHandler(this.pOS3ToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
    }
}