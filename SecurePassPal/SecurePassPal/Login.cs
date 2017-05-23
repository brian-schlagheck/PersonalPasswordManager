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
            var x = ReadFile();
            var userName = TxtUserName.Text;
            var passWord = TxtPassword.Text;
        }

    
        private string ReadFile()
        {
            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "\\SecurePassPal";
            string fullFileName = fileLocation + fileName;
            var chars = System.IO.File.ReadAllText(fullFileName);
            return chars;
        }
    }
}
