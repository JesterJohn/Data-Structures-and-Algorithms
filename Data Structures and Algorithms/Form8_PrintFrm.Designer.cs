namespace Data_Structures_and_Algorithms
{
    partial class Form8_PrintFrm
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
            this.label31 = new System.Windows.Forms.Label();
            this.DisplayListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(12, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(642, 102);
            this.label31.TabIndex = 48;
            this.label31.Text = "SAVORY HUB";
            // 
            // DisplayListbox
            // 
            this.DisplayListbox.FormattingEnabled = true;
            this.DisplayListbox.ItemHeight = 20;
            this.DisplayListbox.Location = new System.Drawing.Point(12, 114);
            this.DisplayListbox.Name = "DisplayListbox";
            this.DisplayListbox.Size = new System.Drawing.Size(643, 584);
            this.DisplayListbox.TabIndex = 49;
            // 
            // Form8_PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 720);
            this.Controls.Add(this.DisplayListbox);
            this.Controls.Add(this.label31);
            this.Name = "Form8_PrintFrm";
            this.Text = "Form8_PrintFrm";
            this.Load += new System.EventHandler(this.Form8_PrintFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label31;
        public System.Windows.Forms.ListBox DisplayListbox;
    }
}