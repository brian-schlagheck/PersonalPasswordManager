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
            var passWord = TxtPassword.Text;
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

        private string EncryptPassWord()
        {
            return "";
        }
    }
}
