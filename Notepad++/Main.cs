﻿using System;
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
            //THEME CONFIGURATION BY THE THEME.MSR FILE

            StreamReader srf = new StreamReader("Theme.msr");
            string file = srf.ReadLine();
            

            if (file == "Dark")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.White;
                fileToolStripMenuItem.ForeColor = Color.Black;
                editToolStripMenuItem.ForeColor = Color.Black;
                formatToolStripMenuItem.ForeColor = Color.Black;
                helpToolStripMenuItem.ForeColor = Color.Black;
                txt_LineNumbers.BackColor = Color.Black;
                txt_LineNumbers.ForeColor = Color.Gray;
            }
            else if(file == "Dark Light")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkGray;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.DarkGray;
                fileToolStripMenuItem.ForeColor = Color.Black;
                editToolStripMenuItem.ForeColor = Color.Black;
                formatToolStripMenuItem.ForeColor = Color.Black;
                helpToolStripMenuItem.ForeColor = Color.Black;
                txt_LineNumbers.BackColor = Color.Black;
                txt_LineNumbers.ForeColor = Color.Gray;
            }
            else if(file == "Dark Blue")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.Aqua;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.Aqua;
                fileToolStripMenuItem.ForeColor = Color.Black;
                editToolStripMenuItem.ForeColor = Color.Black;
                formatToolStripMenuItem.ForeColor = Color.Black;
                helpToolStripMenuItem.ForeColor = Color.Black;
                txt_LineNumbers.BackColor = Color.Black;
                txt_LineNumbers.ForeColor = Color.DarkGray;
            }
            else if(file == "Hacker")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.Black;
                rtxt_text.BackColor = Color.Black;
                rtxt_text.ForeColor = Color.Lime;
                txt_LineNumbers.BackColor = Color.Black;
                txt_LineNumbers.ForeColor = Color.Gray;
            }
            else if(file == "Light")
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                rtxt_text.BackColor = Color.White;
                rtxt_text.ForeColor = Color.Black;
                txt_LineNumbers.BackColor = Color.White;
                txt_LineNumbers.ForeColor = Color.Gray;
            }
            else
                MessageBox.Show("Theme not available yet!", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            srf.Close();




            //LANGUAGE CONFIGURATION BY THE LANGUAGE.MSR FILE
            
            StreamReader sr_language = new StreamReader("Languages.msr"); //READ THE LANGUAGE FILE TO SET THE LANGUAGE IN THE PREFERENCES FORM
            string language = sr_language.ReadLine();

            if (language == "Italian")                              //SET LANGUAGE TO ITALIAN IN PREFERENCES FORM
            {
                fileToolStripMenuItem.Text = "Archivio";
                editToolStripMenuItem.Text = "Modifica";
                formatToolStripMenuItem.Text = "Visualizza";
                helpToolStripMenuItem.Text = "Aiuto";

                newToolStripMenuItem.Text = "Nuovo";
                openToolStripMenuItem.Text = "Apri";
                saveToolStripMenuItem.Text = "Salva";
                saveAsToolStripMenuItem.Text = "Salva con nome";
                printPreviewToolStripMenuItem.Text = "Imposta pagina";
                printToolStripMenuItem.Text = "Stampa";
                exitToolStripMenuItem.Text = "Esci";

                undoToolStripMenuItem.Text = "Indietro";
                redoToolStripMenuItem.Text = "Avanti";
                cutToolStripMenuItem.Text = "Taglia";
                copyToolStripMenuItem.Text = "Copia";
                pasteToolStripMenuItem.Text = "Incolla";
                selectAllToolStripMenuItem.Text = "Seleziona Tutto";
                deleteToolStripMenuItem.Text = "Cancella";

                wordWrapToolStripMenuItem.Text = "A capo automatico";
                fontToolStripMenuItem.Text = "Fonte";
                highlightTextToolStripMenuItem.Text = "Sottolineare";

                licenceToolStripMenuItem.Text = "Licenza";
                preferencesToolStripMenuItem.Text = "Preferenze";
            }
            else if (language == "Portuguese")                      //SET LANGUAGE TO PORTOGHESE IN PREFERENCES FORM
            {
                fileToolStripMenuItem.Text = "File";
                editToolStripMenuItem.Text = "Modificar";
                formatToolStripMenuItem.Text = "Formato";
                helpToolStripMenuItem.Text = "Ajuda";

                newToolStripMenuItem.Text = "Novo";
                openToolStripMenuItem.Text = "Abrir";
                saveToolStripMenuItem.Text = "Salvar";
                saveAsToolStripMenuItem.Text = "Salvar como";
                printPreviewToolStripMenuItem.Text = "Pre-Visualizar";
                printToolStripMenuItem.Text = "Imprimir";
                exitToolStripMenuItem.Text = "Sair";

                undoToolStripMenuItem.Text = "Desfazer";
                redoToolStripMenuItem.Text = "Refazer";
                cutToolStripMenuItem.Text = "Cortar";
                copyToolStripMenuItem.Text = "Copiar";
                pasteToolStripMenuItem.Text = "Colar";
                selectAllToolStripMenuItem.Text = "Selecionar Tudo";
                deleteToolStripMenuItem.Text = "Deletar";

                wordWrapToolStripMenuItem.Text = "Cortar automaticamente";
                fontToolStripMenuItem.Text = "Fonte";
                highlightTextToolStripMenuItem.Text = "Demarcar";

                licenceToolStripMenuItem.Text = "Licença";
                preferencesToolStripMenuItem.Text = "Preferencias";
            }
            else if (language == "English")                         //SET LANGUAGE TO ENGLISH IN PREFERENCES FORM
            {
                fileToolStripMenuItem.Text = "File";
                editToolStripMenuItem.Text = "Edit";
                formatToolStripMenuItem.Text = "Format";
                helpToolStripMenuItem.Text = "Help";

                newToolStripMenuItem.Text = "New";
                openToolStripMenuItem.Text = "Open";
                saveToolStripMenuItem.Text = "Save";
                saveAsToolStripMenuItem.Text = "Save As";
                printPreviewToolStripMenuItem.Text = "Print Preview";
                printToolStripMenuItem.Text = "Print";
                exitToolStripMenuItem.Text = "Exit";

                undoToolStripMenuItem.Text = "Undo";
                redoToolStripMenuItem.Text = "Redo";
                cutToolStripMenuItem.Text = "Cut";
                copyToolStripMenuItem.Text = "Copy";
                pasteToolStripMenuItem.Text = "Paste";
                selectAllToolStripMenuItem.Text = "Select All";
                deleteToolStripMenuItem.Text = "Delete";

                wordWrapToolStripMenuItem.Text = "Word Wrap";
                fontToolStripMenuItem.Text = "Font";
                highlightTextToolStripMenuItem.Text = "Highlight Text";

                licenceToolStripMenuItem.Text = "License";
                preferencesToolStripMenuItem.Text = "Preferences";
            }
            else
                MessageBox.Show("Language not available yet!", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            sr_language.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(rtxt_text.Text != "")
            {
                MessageBox.Show("Would you like to save your work before closing?", "MSR Notepad Warning", MessageBoxButtons.YesNoCancel);
                if(DialogResult == DialogResult.Yes)
                {
                    //DO
                }
                else if(DialogResult == DialogResult.Cancel)
                    return;
                else
                    rtxt_text.Text = "";

            }
                
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true, Multiselect = false })  //ONLY ACCEPTS WIN32 NAMES, CAN'T SELECT MORE THAN 1 FILE
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        filePath = ofd.FileName;
                        string text = sr.ReadToEnd();
                        rtxt_text.Text = text;
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
                            sw.WriteLine(rtxt_text.Text);
                            
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(rtxt_text.Text);
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
                        sw.WriteLine(rtxt_text.Text);

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

            UpdateLineNumbers();

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

        private void UpdateLineNumbers()
        {
            txt_LineNumbers.Text = ""; 

            int totalLines = rtxt_text.Lines.Length;

            for (int i = 1; i <= totalLines; i++)
            {
                txt_LineNumbers.AppendText(i.ToString() + Environment.NewLine);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtxt_text.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void highlightTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(highlightTextToolStripMenuItem.Checked == true) 
                rtxt_text.SelectionBackColor = Color.Yellow;
            
            if(highlightTextToolStripMenuItem.Checked == false && this.BackColor == Color.Black)
                rtxt_text.SelectionBackColor = Color.Black;

            if (highlightTextToolStripMenuItem.Checked == false && this.BackColor == Color.White)
                rtxt_text.SelectionBackColor = Color.White;

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


        private void wordWrapToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if(wordWrapToolStripMenuItem.Checked == true)
                rtxt_text.WordWrap = true;

            if(wordWrapToolStripMenuItem.Checked == false)
                rtxt_text.WordWrap = false;
        }

        private void programmerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(programmerModeToolStripMenuItem.Checked == true)
            {
                txt_LineNumbers.Visible = true;
                wordWrapToolStripMenuItem.Enabled = false;
            }

        }
    }
}
