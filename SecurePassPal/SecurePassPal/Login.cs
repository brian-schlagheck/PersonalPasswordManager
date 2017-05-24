using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePassPal
{
    public partial class Login : Form
    {
        private GenericFunctionHelper _genericFunctionHelper = new GenericFunctionHelper();

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static bool CheckLoginCredentials(string loginString)
        {
            return false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string[] loginInformation = new string[] { };
            try
            {
                loginInformation = _genericFunctionHelper.ReadFile();
                var correctUserName = loginInformation[0];
                var correctEncryptedPassword = loginInformation[1];
                var userName = TxtUserName.Text;
                var password = _genericFunctionHelper.EncryptPassword(TxtPassword.Text);
                ValidateCredentials(userName, correctUserName, password, correctEncryptedPassword);
            }
            catch
            {
                MessageBox.Show("Account has not been created, or has been moved. Please move it back or Create an Account below");
            }
            
        }

    
        public void ValidateCredentials(string userName, string correctUserName, string password, string correctEncryptedPassword)
        {
            if (password == correctEncryptedPassword && userName == correctUserName)
            {
                this.Hide();
                var passManagerForm = new PasswordManager();
                passManagerForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials - Please Try Again");
            }
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            string fullFileName = _genericFunctionHelper.GetFullFileLocation();
            if (File.Exists(fullFileName))
            {
                MessageBox.Show("Account already exists on this computer");
            }
            else
            {
                var accountCreationForm = new AccountCreation();
                accountCreationForm.Show();
            }
            
        }
    }
}
