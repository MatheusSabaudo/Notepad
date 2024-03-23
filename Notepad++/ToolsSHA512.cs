using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__
{
    public partial class ToolsSHA512 : Form
    {
        public ToolsSHA512()
        {
            InitializeComponent();
        }

        private void ToolsSHA512_Load(object sender, EventArgs e)
        {

        }

        private string GetHash(string inputText, HashAlgorithm algorithm)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(inputText);
            byte[] hashBytes = algorithm.ComputeHash(inputBytes);

            StringBuilder builder = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                builder.Append(b.ToString("x2"));
            }

            return builder.ToString();
        }

        private void btn_encrypt_Click_1(object sender, EventArgs e)
        {
            string inputText = rtxt_orginal.Text;

            if (!string.IsNullOrEmpty(inputText))
            {
                // MD5
                string md5Hash = GetHash(inputText, new MD5CryptoServiceProvider());
                rtxt_encrypted.Text = md5Hash;

                StreamWriter sw = new StreamWriter("MyEncryptedText.txt", false);
                sw.WriteLine("Word Encrypted: " + rtxt_encrypted.Text);
                MessageBox.Show("Encrypted Text saved as 'MyEncriptedText'", "MSR Corporation Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sw.Close();
            }
            else
            {
                MessageBox.Show("Inserisci del testo da convertire.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
