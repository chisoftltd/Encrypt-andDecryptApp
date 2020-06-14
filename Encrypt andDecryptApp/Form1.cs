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

namespace Encrypt_andDecryptApp
{
    public partial class Form1 : Form
    {
        UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
        RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
        byte[] data;
        byte[] encryptData;
        //rSACryptoServiceProvider.ExportParameters(false);
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnEncrypt_Click_Click(object sender, EventArgs e)
        {
            data = unicodeEncoding.GetBytes(txtInput.Text);
            encryptData = Encrypt(data, rSACryptoServiceProvider.ExportParameters(false), false);
            txtEncrypt.Text = unicodeEncoding.GetString(encryptData);
        }

        private byte[] Encrypt(byte[] data, RSAParameters RSAKey, bool fOAEP)
        {
            byte[] encryptedData;
            using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rSACryptoServiceProvider.ImportParameters(RSAKey);
                encryptedData = rSACryptoServiceProvider.Encrypt(data, fOAEP);
            }
            return encryptedData;
        }

        private void btnDecrypt_Click_Click(object sender, EventArgs e)
        {
            byte[] data = Decrypt(encryptData, rSACryptoServiceProvider.ExportParameters(true), false);
            txtDecrypt.Text = unicodeEncoding.GetString(data);
        }

        byte[] Decrypt(byte[] data, RSAParameters RSAKey, bool fOAEP)
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rSACryptoServiceProvider.ImportParameters(RSAKey);
                decryptedData = rSACryptoServiceProvider.Decrypt(data, fOAEP);
            }
            return decryptedData;
        }
    }
}
