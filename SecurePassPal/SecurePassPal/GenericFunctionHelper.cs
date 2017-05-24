using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace SecurePassPal
{
    public class GenericFunctionHelper
    {
        string hash = "f0xle@rn";

        public string GetFullFileLocation()
        {
            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "\\SecurePassPal.txt";
            string fullFileName = fileLocation + fileName;
            return fullFileName;
        }

        public string GetFullFileLocationTest()
        {
            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "\\SecurePassPal2.txt";
            string fullFileName = fileLocation + fileName;
            return fullFileName;
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

        public string[] ReadFile()
        {

            string fullFileName = GetFullFileLocation();
            var loginInformation = System.IO.File.ReadAllText(fullFileName);
            var loginInfo = loginInformation.Trim().Split(',');
            return loginInfo;
        }

        public List<string> RetainLoginInfo(string[] previousFileText)
        {
            List<string> keepData = new List<string>();
            keepData.Add(previousFileText[0]);
            keepData.Add(previousFileText[1]);
            return keepData;
        }

        public List<string> ConvertStringArrayToList(string[] stringArray)
        {
            List<string> returnList = new List<string>();
            foreach (var val in stringArray)
            {
                returnList.Add(val);
            }
            return returnList;
        }

        public string EncryptInternalPassword(string password)
        {
            var passLength = password.Length;
            if (passLength > 0)
            {
                if (password[passLength - 1].ToString() == "=")
                {
                    return password;
                }
            }
            
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    password = Convert.ToBase64String(results, 0, results.Length);
                    return password;
                }
            }
        }

        public string DecryptInternalPassword(string password)
        {
            byte[] data = Convert.FromBase64String(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    password = UTF8Encoding.UTF8.GetString(results);
                    return password;
                }
            }
        }
    }
}
