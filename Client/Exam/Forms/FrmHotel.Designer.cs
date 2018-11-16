namespace Exam.Forms
{
    partial class FrmHotel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbHotelName = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbStars = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.lbComments = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbHotelName
            // 
            this.tbHotelName.Location = new System.Drawing.Point(253, 12);
            this.tbHotelName.Name = "tbHotelName";
            this.tbHotelName.ReadOnly = true;
            this.tbHotelName.Size = new System.Drawing.Size(478, 20);
            this.tbHotelName.TabIndex = 1;
            this.tbHotelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(604, 38);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(127, 20);
            this.tbCity.TabIndex = 2;
            this.tbCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(253, 38);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.ReadOnly = true;
            this.tbCountry.Size = new System.Drawing.Size(129, 20);
            this.tbCountry.TabIndex = 3;
            this.tbCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbStars
            // 
            this.tbStars.Location = new System.Drawing.Point(428, 38);
            this.tbStars.Name = "tbStars";
            this.tbStars.ReadOnly = true;
            this.tbStars.Size = new System.Drawing.Size(129, 20);
            this.tbStars.TabIndex = 4;
            this.tbStars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(253, 64);
            this.tbCost.Name = "tbCost";
            this.tbCost.ReadOnly = true;
            this.tbCost.Size = new System.Drawing.Size(478, 20);
            this.tbCost.TabIndex = 5;
            this.tbCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(253, 90);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(478, 135);
            this.rtbInfo.TabIndex = 6;
            this.rtbInfo.Text = "";
            // 
            // tbComment
            // 
            this.tbComment.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbComment.Location = new System.Drawing.Point(12, 231);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(532, 44);
            this.tbComment.TabIndex = 7;
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(550, 231);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(181, 44);
            this.bSend.TabIndex = 8;
            this.bSend.Text = "Send Comment";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // lbComments
            // 
            this.lbComments.FormattingEnabled = true;
            this.lbComments.Location = new System.Drawing.Point(12, 281);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(719, 290);
            this.lbComments.TabIndex = 9;
            // 
            // FrmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 602);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbStars);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbHotelName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmHotel";
            this.Text = "FrmHotel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbHotelName;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbStars;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.ListBox lbComments;
    }
}