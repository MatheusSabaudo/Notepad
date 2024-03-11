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
using System.Data.Odbc;

namespace Notepad__
{
    public partial class Main : Form
    {

        string filePath = "";   //file location path

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            StreamReader srf = new StreamReader("Theme.msr");
            string file = srf.ReadLine();
            

            if (file == "Dark")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.White;

                darkLightToolStripMenuItem.Checked = false;
                darkBlueToolStripMenuItem.Checked = false;
                lightToolStripMenuItem.Checked = false;
                hackerToolStripMenuItem.Checked = false;
            }else if(file == "Dark Light")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkGray;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.DarkGray;

                darkToolStripMenuItem.Checked = false;
                darkBlueToolStripMenuItem.Checked = false;
                lightToolStripMenuItem.Checked = false;
                hackerToolStripMenuItem.Checked = false;
            }else if(file == "Dark Blue")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkBlue;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.DarkBlue;

                darkLightToolStripMenuItem.Checked = false;
                darkToolStripMenuItem.Checked = false;
                lightToolStripMenuItem.Checked = false;
                hackerToolStripMenuItem.Checked = false;
            }else if(file == "Hacker")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.LimeGreen;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.LimeGreen;

                darkLightToolStripMenuItem.Checked = false;
                darkBlueToolStripMenuItem.Checked = false;
                lightToolStripMenuItem.Checked = false;
                darkToolStripMenuItem.Checked = false;
            }

            srf.Close();


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(rtxt_text.Text != "")
            {
                MessageBox.Show("Would you like to save your work before closing?", "MSR Notepad Warning", MessageBoxButtons.YesNoCancel);
                if(DialogResult == DialogResult.Yes)
                {

                }
                else if(DialogResult == DialogResult.Cancel)
                    return;
                else
                    rtxt_text.Text = "";

            }
                
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        filePath = ofd.FileName;
                        Task <string> text = sr.ReadToEndAsync();
                        rtxt_text.Text = text.Result;
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true})
                {
                    if(sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLineAsync(rtxt_text.Text);
                            
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLineAsync(rtxt_text.Text);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLineAsync(rtxt_text.Text);

                    }
                }
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtxt_text.Text, rtxt_text.Font, Brushes.Black, 12, 10);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.SelectedText = "";
        }

        private void rtxt_text_TextChanged(object sender, EventArgs e)
        {
            if (rtxt_text.Text.Length > 0)
            {
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
            }
            else
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                wordWrapToolStripMenuItem.Checked = false;
                rtxt_text.WordWrap = false;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = true;
                rtxt_text.WordWrap = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtxt_text.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void highlightTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_text.SelectionBackColor = Color.Yellow;
        }

        private void licenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad Created by MSR Corporation LLC! \nAll rights reserved.", "MSR Corporation", MessageBoxButtons.OK);
        }

        

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Preferences().Show();
            this.Hide();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(darkToolStripMenuItem.Checked == true)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.White;

                darkLightToolStripMenuItem.Checked = false;
                darkBlueToolStripMenuItem.Checked = false;
                lightToolStripMenuItem.Checked = false;
                hackerToolStripMenuItem.Checked = false;
            }
            
        }

        private void darkLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(darkLightToolStripMenuItem.Checked == true)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkGray;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.DarkGray;

                darkToolStripMenuItem.Checked = false;
                darkBlueToolStripMenuItem.Checked = false;
                lightToolStripMenuItem.Checked = false;
                hackerToolStripMenuItem.Checked = false;
            }
            
        }

        private void darkBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(darkBlueToolStripMenuItem.Checked == true)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkBlue;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.DarkBlue;

                darkLightToolStripMenuItem.Checked = false;
                darkToolStripMenuItem.Checked = false;
                lightToolStripMenuItem.Checked = false;
                hackerToolStripMenuItem.Checked = false;
            }
            
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lightToolStripMenuItem.Checked == true)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                rtxt_text.BackColor = Color.White;
                rtxt_text.ForeColor = Color.Black;

                darkLightToolStripMenuItem.Checked = false;
                darkBlueToolStripMenuItem.Checked = false;
                darkToolStripMenuItem.Checked = false;
                hackerToolStripMenuItem.Checked = false;
            }
            
        }

        private void hackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(hackerToolStripMenuItem.Checked == true)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.LimeGreen;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.LimeGreen;

                darkLightToolStripMenuItem.Checked = false;
                darkBlueToolStripMenuItem.Checked = false;
                lightToolStripMenuItem.Checked = false;
                darkToolStripMenuItem.Checked = false;
            }
        }
    }
}
