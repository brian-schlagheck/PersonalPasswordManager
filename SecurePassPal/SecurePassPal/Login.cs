using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePassPal
{
    public partial class Login : Form
    {
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
            var loginInformation = ReadFile();
            var correctUserName = loginInformation[0];
            var correctEncryptedPassword = loginInformation[1];
            var userName = TxtUserName.Text;
            var password = EncryptPassword(TxtPassword.Text);
            ValidateCredentials(userName, correctUserName, password, correctEncryptedPassword);
        }

    
        private string[] ReadFile()
        {
            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "\\SecurePassPal.txt";
            string fullFileName = fileLocation + fileName;
            var loginInformation = System.IO.File.ReadAllText(fullFileName);
            var loginInfo = loginInformation.Split(',');
            return loginInfo;
        }

        public string EncryptPassword(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] passwordByteValue = md5.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(passwordByteValue);
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
            var accountCreationForm = new AccountCreation();
            accountCreationForm.Show();
        }
    }
}
