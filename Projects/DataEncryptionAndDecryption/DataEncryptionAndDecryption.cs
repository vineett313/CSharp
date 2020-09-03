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

namespace DataEncryptionAndDecryption
{
    public partial class DataEncryptionAndDecryption : Form
    {
        private string key = "GOLDBERG-MRVIRUS";
        public DataEncryptionAndDecryption()
        {
            InitializeComponent();
            this.lblKey.Text += key;
        }

        private void OnEncrypt(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInput.Text?.Trim()))
                {
                    MessageBox.Show("Please enter valid input !!");
                    return;
                }

                byte[] inputArray = UTF8Encoding.UTF8.GetBytes(txtInput.Text);
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                txtResult.Text = Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch (Exception ex)
            {
                txtResult.Text = $"Error occurred : {ex.Message}";
            }
        }

        private void OnDecrypt(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInput.Text?.Trim()))
                {
                    MessageBox.Show("Please enter valid input !!");
                    return;
                }
                byte[] inputArray = Convert.FromBase64String(txtInput.Text);
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                txtResult.Text = UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception ex)
            {
                txtResult.Text = $"Error occurred : {ex.Message}";
            }
        }

        private void OnClear(object sender, EventArgs e)
        {
            txtInput.Text = String.Empty;
            txtResult.Text = String.Empty;
        }
    }
}
