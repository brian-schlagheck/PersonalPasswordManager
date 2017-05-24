namespace SecurePassPal
{
    partial class AccountCreation
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
            this.TxtEnterUserName = new System.Windows.Forms.TextBox();
            this.TxtEnterPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.LblEnterUserName = new System.Windows.Forms.Label();
            this.LblEnterPassword = new System.Windows.Forms.Label();
            this.LblConfirmPassword = new System.Windows.Forms.Label();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtEnterUserName
            // 
            this.TxtEnterUserName.Location = new System.Drawing.Point(127, 35);
            this.TxtEnterUserName.Name = "TxtEnterUserName";
            this.TxtEnterUserName.Size = new System.Drawing.Size(166, 20);
            this.TxtEnterUserName.TabIndex = 0;
            // 
            // TxtEnterPassword
            // 
            this.TxtEnterPassword.Location = new System.Drawing.Point(127, 72);
            this.TxtEnterPassword.Name = "TxtEnterPassword";
            this.TxtEnterPassword.Size = new System.Drawing.Size(166, 20);
            this.TxtEnterPassword.TabIndex = 1;
            this.TxtEnterPassword.UseSystemPasswordChar = true;
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(127, 107);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(166, 20);
            this.TxtConfirmPassword.TabIndex = 2;
            this.TxtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // LblEnterUserName
            // 
            this.LblEnterUserName.AutoSize = true;
            this.LblEnterUserName.Location = new System.Drawing.Point(12, 35);
            this.LblEnterUserName.Name = "LblEnterUserName";
            this.LblEnterUserName.Size = new System.Drawing.Size(91, 13);
            this.LblEnterUserName.TabIndex = 3;
            this.LblEnterUserName.Text = "Enter User Name:";
            // 
            // LblEnterPassword
            // 
            this.LblEnterPassword.AutoSize = true;
            this.LblEnterPassword.Location = new System.Drawing.Point(12, 72);
            this.LblEnterPassword.Name = "LblEnterPassword";
            this.LblEnterPassword.Size = new System.Drawing.Size(84, 13);
            this.LblEnterPassword.TabIndex = 4;
            this.LblEnterPassword.Text = "Enter Password:";
            // 
            // LblConfirmPassword
            // 
            this.LblConfirmPassword.AutoSize = true;
            this.LblConfirmPassword.Location = new System.Drawing.Point(12, 107);
            this.LblConfirmPassword.Name = "LblConfirmPassword";
            this.LblConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.LblConfirmPassword.TabIndex = 5;
            this.LblConfirmPassword.Text = "Confirm Password:";
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Location = new System.Drawing.Point(127, 153);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(166, 23);
            this.BtnCreateAccount.TabIndex = 6;
            this.BtnCreateAccount.Text = "Create Account";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // AccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 211);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.LblConfirmPassword);
            this.Controls.Add(this.LblEnterPassword);
            this.Controls.Add(this.LblEnterUserName);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.TxtEnterPassword);
            this.Controls.Add(this.TxtEnterUserName);
            this.Name = "AccountCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountCreation";
            this.Load += new System.EventHandler(this.AccountCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEnterUserName;
        private System.Windows.Forms.TextBox TxtEnterPassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Label LblEnterUserName;
        private System.Windows.Forms.Label LblEnterPassword;
        private System.Windows.Forms.Label LblConfirmPassword;
        private System.Windows.Forms.Button BtnCreateAccount;
    }
}