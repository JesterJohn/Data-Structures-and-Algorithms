namespace Data_Structures_and_Algorithms
{
    partial class Form9_Printfrm
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
            this.Displaylistbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Displaylistbox
            // 
            this.Displaylistbox.FormattingEnabled = true;
            this.Displaylistbox.ItemHeight = 20;
            this.Displaylistbox.Location = new System.Drawing.Point(12, 12);
            this.Displaylistbox.Name = "Displaylistbox";
            this.Displaylistbox.Size = new System.Drawing.Size(590, 724);
            this.Displaylistbox.TabIndex = 0;
            // 
            // Form9_Printfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 749);
            this.Controls.Add(this.Displaylistbox);
            this.Name = "Form9_Printfrm";
            this.Text = "Form9_Printfrm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox Displaylistbox;
    }
}