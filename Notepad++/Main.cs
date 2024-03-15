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
using System.Text.RegularExpressions;
using System.Net.Configuration;

namespace Notepad__
{
    public partial class Main : Form
    {

        string filePath = "";   //file location path

        //EXTENSIONS CONFIG IN THE SAVE PAGE
        SaveFileDialog sfd = new SaveFileDialog();

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
                languageToolStripMenuItem.ForeColor= Color.Black;
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
                languageToolStripMenuItem.ForeColor = Color.Black;
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
                languageToolStripMenuItem.ForeColor = Color.Black;
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
                    if (string.IsNullOrEmpty(filePath))
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
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            sw.WriteLine(rtxt_text.Text);
                        }
                    }
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

        private void findAndorReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //FIND AND REPLACE CODE
            FindReplace findReplaceForm = new FindReplace();
            findReplaceForm.FindReplaceAction += FindReplaceActionHandler;
           

            //HIGHLIGH CONFIGURATION AFTER FINDREPLACE FORMCLOSED
            findReplaceForm.FormClosed += FindReplaceForm_FormClosed; // Aggiungi un gestore per l'evento FormClosed
            findReplaceForm.ShowDialog();
        }

        private void FindReplaceActionHandler(string findText, string replaceText, bool replaceMode)
        {
            if (replaceMode)
            {
                // Esegui la sostituzione del testo nella RichTextBox
                if (!string.IsNullOrEmpty(findText) && !string.IsNullOrEmpty(replaceText))
                {
                    string pattern = @"\b" + Regex.Escape(findText) + @"\b";
                    rtxt_text.Text = Regex.Replace(rtxt_text.Text, pattern, replaceText);
                }
            }
            else
            {
                // Esegui la ricerca del testo nella RichTextBox
                if (!string.IsNullOrEmpty(findText))
                {
                    string pattern = @"\b" + Regex.Escape(findText) + @"\b";
                    Match match = Regex.Match(rtxt_text.Text, pattern);
                    if (match.Success)
                    {
                        rtxt_text.Select(match.Index, match.Length);
                        rtxt_text.SelectionBackColor = Color.Yellow;

                        rtxt_text.ScrollToCaret(); // Assicura che il testo trovato sia visibile nella RichTextBox
                        rtxt_text.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Text not found", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void FindReplaceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(rtxt_text.SelectionBackColor == Color.Yellow && this.BackColor == Color.Black)
                rtxt_text.SelectionBackColor = Color.Black;
            else
                rtxt_text.SelectionBackColor = Color.White;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MODEL PRE-SELECTED IF THE USER SELECT THE LANGUAGE BEFORE WRITING ANYTHING IN THE NOTEPAD
            DialogResult result = MessageBox.Show("Would you like to pre-load an existing base model for this language?", "MSR Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (cToolStripMenuItem.Checked == true)
                    rtxt_text.Text = "#include <stdio.h>\r\n\r\nint main() {\r\n    printf(\"Hello, World!\\n\");\r\n    return 0;\r\n}";
            }

            //CHECKING FALSE TO ANOTHER OPTIONS IF ACTIVATED
            cToolStripMenuItem2.Checked = false;
            cToolStripMenuItem1.Checked = false;
            pythonToolStripMenuItem.Checked = false;
            javaToolStripMenuItem.Checked = false;
            javaScriptToolStripMenuItem.Checked = false;
            hTMLToolStripMenuItem.Checked = false;
            cSSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;

            cToolStripMenuItem.Checked = true;
            programmerModeToolStripMenuItem.Checked = true;
            programmerModeToolStripMenuItem_Click(programmerModeToolStripMenuItem, EventArgs.Empty);

            sfd.FileName = "new.c";
            sfd.Filter = "C Language | *.c";
        }

        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //MODEL PRE-SELECTED IF THE USER SELECT THE LANGUAGE BEFORE WRITING ANYTHING IN THE NOTEPAD
            DialogResult result = MessageBox.Show("Would you like to pre-load an existing base model for this language?", "MSR Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (cToolStripMenuItem2.Checked == true)
                    rtxt_text.Text = "#include <iostream>\r\n\r\nint main() {\r\n    std::cout << \"Hello, World!\" << std::endl;\r\n    return 0;\r\n}";
            }

            //CHECKING FALSE TO ANOTHER OPTIONS IF ACTIVATED
            cToolStripMenuItem.Checked = false;
            cToolStripMenuItem1.Checked = false;
            pythonToolStripMenuItem.Checked = false;
            javaToolStripMenuItem.Checked = false;
            javaScriptToolStripMenuItem.Checked = false;
            hTMLToolStripMenuItem.Checked = false;
            cSSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;

            cToolStripMenuItem2.Checked = true;
            programmerModeToolStripMenuItem_Click(programmerModeToolStripMenuItem, EventArgs.Empty);

            sfd.FileName = "new.cpp";
            sfd.Filter = "C++ Language | *.cpp";
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MODEL PRE-SELECTED IF THE USER SELECT THE LANGUAGE BEFORE WRITING ANYTHING IN THE NOTEPAD
            DialogResult result = MessageBox.Show("Would you like to pre-load an existing base model for this language?", "MSR Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (cToolStripMenuItem1.Checked == true)
                    rtxt_text.Text = "using System;\r\n\r\nclass Program {\r\n    static void Main(string[] args) {\r\n        Console.WriteLine(\"Hello, World!\");\r\n    }\r\n}";
            }
            

            //CHECKING FALSE TO ANOTHER OPTIONS IF ACTIVATED
            cToolStripMenuItem2.Checked = false;
            cToolStripMenuItem.Checked = false;
            pythonToolStripMenuItem.Checked = false;
            javaToolStripMenuItem.Checked = false;
            javaScriptToolStripMenuItem.Checked = false;
            hTMLToolStripMenuItem.Checked = false;
            cSSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;

            cToolStripMenuItem1.Checked = true;
            programmerModeToolStripMenuItem_Click(programmerModeToolStripMenuItem, EventArgs.Empty);

            //SAVE FILE DIALOG PRESET SETTINGS
            sfd.FileName = "new.cs";
            sfd.Filter = "C# Language | *.cs";
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MODEL PRE-SELECTED IF THE USER SELECT THE LANGUAGE BEFORE WRITING ANYTHING IN THE NOTEPAD

            DialogResult result = MessageBox.Show("Would you like to pre-load an existing base model for this language?", "MSR Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (pythonToolStripMenuItem.Checked == true)
                    rtxt_text.Text = "print(\"Hello, World!\")";
            }


            //CHECKING FALSE TO ANOTHER OPTIONS IF ACTIVATED
            cToolStripMenuItem2.Checked = false;
            cToolStripMenuItem1.Checked = false;
            cToolStripMenuItem.Checked = false;
            javaToolStripMenuItem.Checked = false;
            javaScriptToolStripMenuItem.Checked = false;
            hTMLToolStripMenuItem.Checked = false;
            cSSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;

            pythonToolStripMenuItem.Checked = true;
            programmerModeToolStripMenuItem_Click(programmerModeToolStripMenuItem, EventArgs.Empty);


            //SAVE FILE DIALOG PRESET SETTINGS
            sfd.FileName = "new.py";
            sfd.Filter = "Python Language | *.py";
        }

        private void javaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MODEL PRE-SELECTED IF THE USER SELECT THE LANGUAGE BEFORE WRITING ANYTHING IN THE NOTEPAD

            DialogResult result = MessageBox.Show("Would you like to pre-load an existing base model for this language?", "MSR Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (javaToolStripMenuItem.Checked == true)
                    rtxt_text.Text = "public class Main\r\n        {\\r\\n public static void main(String[] args)\r\n            {\\r\\n System.out.println(\\\"Hello, World!\\\");\\r\\n    }\\r\\n}";
            }
            
            //CHECKING FALSE TO ANOTHER OPTIONS IF ACTIVATED
            cToolStripMenuItem2.Checked = false;
            cToolStripMenuItem1.Checked = false;
            cToolStripMenuItem.Checked = false;
            pythonToolStripMenuItem.Checked = false;
            javaScriptToolStripMenuItem.Checked = false;
            hTMLToolStripMenuItem.Checked = false;
            cSSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;

            javaToolStripMenuItem.Checked = true;
            programmerModeToolStripMenuItem_Click(programmerModeToolStripMenuItem, EventArgs.Empty);

            sfd.FileName = "new.java";
            sfd.Filter = "Java Language | *.java";
        }

        private void javaScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MODEL PRE-SELECTED IF THE USER SELECT THE LANGUAGE BEFORE WRITING ANYTHING IN THE NOTEPAD
            DialogResult result = MessageBox.Show("Would you like to pre-load an existing base model for this language?", "MSR Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (javaScriptToolStripMenuItem.Checked == true)
                    rtxt_text.Text = "console.log(\"Hello, World!\");";
            }
            

            //CHECKING FALSE TO ANOTHER OPTIONS IF ACTIVATED
            cToolStripMenuItem2.Checked = false;
            cToolStripMenuItem1.Checked = false;
            cToolStripMenuItem.Checked = false;
            pythonToolStripMenuItem.Checked = false;
            javaToolStripMenuItem.Checked = false;
            hTMLToolStripMenuItem.Checked = false;
            cSSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;

            javaScriptToolStripMenuItem.Checked = true;
            programmerModeToolStripMenuItem_Click(programmerModeToolStripMenuItem, EventArgs.Empty);

            sfd.FileName = "new.js";
            sfd.Filter = "JavaScript Language | *.js";
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MODEL PRE-SELECTED IF THE USER SELECT THE LANGUAGE BEFORE WRITING ANYTHING IN THE NOTEPAD
            DialogResult result = MessageBox.Show("Would you like to pre-load an existing base model for this language?", "MSR Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (hTMLToolStripMenuItem.Checked == true)
                    rtxt_text.Text = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <title>Hello, World!</title>\r\n</head>\r\n<body>\r\n    <h1>Hello, World!</h1>\r\n</body>\r\n</html>";
            }
            

            //CHECKING FALSE TO ANOTHER OPTIONS IF ACTIVATED
            cToolStripMenuItem2.Checked = false;
            cToolStripMenuItem1.Checked = false;
            cToolStripMenuItem.Checked = false;
            pythonToolStripMenuItem.Checked = false;
            javaScriptToolStripMenuItem.Checked = false;
            javaToolStripMenuItem.Checked = false;
            cSSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;

            hTMLToolStripMenuItem.Checked = true;
            programmerModeToolStripMenuItem_Click(programmerModeToolStripMenuItem, EventArgs.Empty);

            sfd.FileName = "new.html";
            sfd.Filter = "HTML File | *.html";
        }

        private void cSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MODEL PRE-SELECTED IF THE USER SELECT THE LANGUAGE BEFORE WRITING ANYTHING IN THE NOTEPAD
            DialogResult result = MessageBox.Show("Would you like to pre-load an existing base model for this language?", "MSR Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (cSSToolStripMenuItem.Checked == true)
                    rtxt_text.Text = "/* CSS Stylesheet for Hello World */\r\nbody {\r\n    background-color: #f0f0f0;\r\n    color: #333;\r\n    font-family: Arial, sans-serif;\r\n}\r\n\r\nh1 {\r\n    text-align: center;\r\n}";
            }
            

            //CHECKING FALSE TO ANOTHER OPTIONS IF ACTIVATED
            cToolStripMenuItem2.Checked = false;
            cToolStripMenuItem1.Checked = false;
            cToolStripMenuItem.Checked = false;
            pythonToolStripMenuItem.Checked = false;
            javaScriptToolStripMenuItem.Checked = false;
            hTMLToolStripMenuItem.Checked = false;
            javaToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;

            cSSToolStripMenuItem.Checked = true;
            programmerModeToolStripMenuItem_Click(programmerModeToolStripMenuItem, EventArgs.Empty);

            sfd.FileName = "new.css";
            sfd.Filter = "CSS File | *.css";
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MODEL PRE-SELECTED IF THE USER SELECT THE LANGUAGE BEFORE WRITING ANYTHING IN THE NOTEPAD
            DialogResult result = MessageBox.Show("Would you like to pre-load an existing base model for this language?", "MSR Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (pHPToolStripMenuItem.Checked == true)
                    rtxt_text.Text = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <title>Hello, World!</title>\r\n</head>\r\n<body>\r\n    <?php echo \"Hello, World!\"; ?>\r\n</body>\r\n</html>";
            }

            //CHECKING FALSE TO ANOTHER OPTIONS IF ACTIVATED
            cToolStripMenuItem2.Checked = false;
            cToolStripMenuItem1.Checked = false;
            cToolStripMenuItem.Checked = false;
            pythonToolStripMenuItem.Checked = false;
            javaScriptToolStripMenuItem.Checked = false;
            hTMLToolStripMenuItem.Checked = false;
            cSSToolStripMenuItem.Checked = false;
            javaToolStripMenuItem.Checked = false;

            pHPToolStripMenuItem.Checked = true;
            programmerModeToolStripMenuItem_Click(programmerModeToolStripMenuItem, EventArgs.Empty);

            sfd.FileName = "new.php";
            sfd.Filter = "PHP Language | *.php";
        }
    }


}
