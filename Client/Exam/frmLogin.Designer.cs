namespace Exam
{
    partial class FrmLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUname = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbReg = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUname
            // 
            this.tbUname.Location = new System.Drawing.Point(51, 21);
            this.tbUname.Name = "tbUname";
            this.tbUname.Size = new System.Drawing.Size(252, 20);
            this.tbUname.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(51, 60);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(252, 20);
            this.tbPass.TabIndex = 1;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(51, 201);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(252, 59);
            this.bLogin.TabIndex = 2;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(51, 126);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(252, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // cbReg
            // 
            this.cbReg.AutoSize = true;
            this.cbReg.Location = new System.Drawing.Point(51, 165);
            this.cbReg.Name = "cbReg";
            this.cbReg.Size = new System.Drawing.Size(91, 17);
            this.cbReg.TabIndex = 4;
            this.cbReg.Text = "Регистрация";
            this.cbReg.UseVisualStyleBackColor = true;
            this.cbReg.CheckedChanged += new System.EventHandler(this.cbReg_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pass: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail: ";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbReg);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUname);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUname;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.CheckBox cbReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

