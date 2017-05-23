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

            dt.Rows.Add("1", "2", "3");
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnDeleteRecords_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void BtnSaveProgress_Click(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.SelectAll();
            DataObject dataObject = dataGridView1.GetClipboardContent();
            string filePath = _genericFunctionHelper.GetFullFileLocationTest();
            string[] previousFileText = _genericFunctionHelper.ReadFile();
            List<string> finalCSVList = _genericFunctionHelper.RetainLoginInfo(previousFileText);
            var stringPasswordInfo = dataObject.GetText(TextDataFormat.CommaSeparatedValue);
            var arrayPasswordInfo = stringPasswordInfo.Trim().Split(',');
            string finalCSVText = "";
            foreach (var newVal in arrayPasswordInfo)
            {
                finalCSVList.Add(newVal + ",");
            }
            foreach (var val in finalCSVList)
            {
                finalCSVText += val;
                finalCSVText += ",";

            }
            finalCSVText.Trim();
            File.WriteAllText(filePath, finalCSVText);
        }
    }
    
}
