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
    public partial class PasswordManager : Form
    {
        DataTable dt = new DataTable();
        private GenericFunctionHelper _genericFunctionHelper = new GenericFunctionHelper();

        public PasswordManager()
        { 
            InitializeComponent();
        }

        private void PasswordManager_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Account For", typeof(string));
            dt.Columns.Add("User Name/Email", typeof(string));
            dt.Columns.Add("Password", typeof(string));

            string[] previousFileText = _genericFunctionHelper.ReadFile();

            for (int i = 2; i < previousFileText.Length - 4; i += 3)
            {
                dt.Rows.Add(previousFileText[i], previousFileText[i + 1], previousFileText[i+2]);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnDeleteRecords_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
            catch
            {
                MessageBox.Show("Can't delete the uncommited (*) row");
            }

        }

        private void BtnSaveProgress_Click(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.SelectAll();
            DataObject dataObject = dataGridView1.GetClipboardContent();
            string filePath = _genericFunctionHelper.GetFullFileLocation();
            string[] previousFileText = _genericFunctionHelper.ReadFile();
            List<string> finalCSVList = _genericFunctionHelper.RetainLoginInfo(previousFileText);
            var stringPasswordInfo = dataObject.GetText(TextDataFormat.CommaSeparatedValue);
            stringPasswordInfo = stringPasswordInfo.Replace(System.Environment.NewLine, ",");
            var arrayPasswordInfo = stringPasswordInfo.Trim().Split(',');
            string finalCSVText = "";
            var counter = 1;
            foreach (var newVal in arrayPasswordInfo)
            {
                if (counter == 3)
                {
                    var encryptedVal = _genericFunctionHelper.EncryptInternalPassword(newVal);
                    finalCSVList.Add(encryptedVal);
                    counter = 0;
                }
                else if (counter == 2)
                {
                    var encryptedVal = _genericFunctionHelper.EncryptInternalPassword(newVal);
                    finalCSVList.Add(encryptedVal);
                }
                else
                {
                    finalCSVList.Add(newVal);
                }
                counter += 1;
            }
            foreach (var val in finalCSVList)
            {
                finalCSVText += val;
                finalCSVText += ",";

            }
            finalCSVText.Trim();
            finalCSVText.Replace(System.Environment.NewLine, ",");
            File.WriteAllText(filePath, finalCSVText);

        }

        private void BtnDecryptPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var decryptedPassword = _genericFunctionHelper.DecryptInternalPassword(dataGridView1.CurrentCell.Value.ToString());
                TxtDecryptedPassword.Text = decryptedPassword;
            }
            catch
            {
                MessageBox.Show("Please just select 1 cell");
            }
        }
    }
    
}
