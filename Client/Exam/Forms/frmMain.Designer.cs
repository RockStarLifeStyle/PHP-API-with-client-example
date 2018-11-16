namespace Exam.Forms
{
    partial class FrmMain
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
            this.lbHotels = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbHotels
            // 
            this.lbHotels.FormattingEnabled = true;
            this.lbHotels.Location = new System.Drawing.Point(12, 12);
            this.lbHotels.Name = "lbHotels";
            this.lbHotels.Size = new System.Drawing.Size(398, 368);
            this.lbHotels.TabIndex = 0;
            this.lbHotels.SelectedIndexChanged += new System.EventHandler(this.lbHotels_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 392);
            this.Controls.Add(this.lbHotels);
            this.Name = "FrmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbHotels;
    }
}