namespace BurstClicker
{
    partial class BurstClickForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BurstClickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 89);
            this.Name = "BurstClickForm";
            this.Text = "BurstClicker: Inactive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BurstClickForm_FormClosing);
            this.Load += new System.EventHandler(this.BurstClickForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}