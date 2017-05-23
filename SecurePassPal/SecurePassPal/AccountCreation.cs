using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePassPal
{
    public partial class AccountCreation : Form
    {
        private Login _login = new Login();

        public AccountCreation()
        {
            InitializeComponent();
        }

        public void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            string userName = TxtEnterUserName.Text;
            string password = _login.EncryptPassword(TxtEnterPassword.Text);
            string confirmPassword = _login.EncryptPassword(TxtConfirmPassword.Text);
            ValidatePasswords(password, confirmPassword, userName);
        }

        private void ValidatePasswords(string password, string confirmPassword, string userName)
        {
            if (password == confirmPassword && !string.IsNullOrEmpty(userName))
            {
                string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "\\SecurePassPal.txt";
                string fullFileName = fileLocation + fileName;
                string content = userName + "," + password;
                System.IO.File.WriteAllText(fullFileName, content);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords do not match, or Username was left empty");
            }
        }
    }
}
