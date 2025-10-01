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
            this.enrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentEnrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pOSAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashier4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSToolStripMenuItem,
            this.pOSAdministratorToolStripMenuItem,
            this.userAccountToolStripMenuItem,
            this.accountingToolStripMenuItem,
            this.employeeInformationToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.enrollmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2564, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOS1ToolStripMenuItem,
            this.pOS2ToolStripMenuItem,
            this.pOS3ToolStripMenuItem,
            this.cashier4ToolStripMenuItem});
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.pOSToolStripMenuItem.Text = "POS Cashier";
            this.pOSToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // pOS1ToolStripMenuItem
            // 
            this.pOS1ToolStripMenuItem.Name = "pOS1ToolStripMenuItem";
            this.pOS1ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pOS1ToolStripMenuItem.Text = "Cashier 1";
            this.pOS1ToolStripMenuItem.Click += new System.EventHandler(this.pOS1ToolStripMenuItem_Click);
            // 
            // pOS2ToolStripMenuItem
            // 
            this.pOS2ToolStripMenuItem.Name = "pOS2ToolStripMenuItem";
            this.pOS2ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pOS2ToolStripMenuItem.Text = "Cashier 2";
            this.pOS2ToolStripMenuItem.Click += new System.EventHandler(this.pOS2ToolStripMenuItem_Click);
            // 
            // pOS3ToolStripMenuItem
            // 
            this.pOS3ToolStripMenuItem.Name = "pOS3ToolStripMenuItem";
            this.pOS3ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pOS3ToolStripMenuItem.Text = "Cashier 3";
            this.pOS3ToolStripMenuItem.Click += new System.EventHandler(this.pOS3ToolStripMenuItem_Click);
            // 
            // enrollmentToolStripMenuItem
            // 
            this.enrollmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentEnrollmentToolStripMenuItem});
            this.enrollmentToolStripMenuItem.Name = "enrollmentToolStripMenuItem";
            this.enrollmentToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.enrollmentToolStripMenuItem.Text = "Enrollment ";
            // 
            // studentEnrollmentToolStripMenuItem
            // 
            this.studentEnrollmentToolStripMenuItem.Name = "studentEnrollmentToolStripMenuItem";
            this.studentEnrollmentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.studentEnrollmentToolStripMenuItem.Text = "Student Enrollment ";
            this.studentEnrollmentToolStripMenuItem.Click += new System.EventHandler(this.studentEnrollmentToolStripMenuItem_Click);
            // 
            // accountingToolStripMenuItem
            // 
            this.accountingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payrollToolStripMenuItem});
            this.accountingToolStripMenuItem.Name = "accountingToolStripMenuItem";
            this.accountingToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.accountingToolStripMenuItem.Text = "Payroll";
            this.accountingToolStripMenuItem.Click += new System.EventHandler(this.accountingToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.payrollToolStripMenuItem.Text = "Payroll Application";
            this.payrollToolStripMenuItem.Click += new System.EventHandler(this.payrollToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(2564, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pOSAdministratorToolStripMenuItem
            // 
            this.pOSAdministratorToolStripMenuItem.Name = "pOSAdministratorToolStripMenuItem";
            this.pOSAdministratorToolStripMenuItem.Size = new System.Drawing.Size(176, 29);
            this.pOSAdministratorToolStripMenuItem.Text = "POS Administrator";
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.userAccountToolStripMenuItem.Text = "User Account";
            // 
            // employeeInformationToolStripMenuItem
            // 
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(205, 29);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // cashier4ToolStripMenuItem
            // 
            this.cashier4ToolStripMenuItem.Name = "cashier4ToolStripMenuItem";
            this.cashier4ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cashier4ToolStripMenuItem.Text = "Cashier 4";
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
        private System.Windows.Forms.ToolStripMenuItem enrollmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentEnrollmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashier4ToolStripMenuItem;
    }
}