using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Notepad__
{
    public partial class ToolsMD5 : Form
    {
        public ToolsMD5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void btn_encrypt_Click(object sender, EventArgs e)
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
