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

namespace Notepad__
{
    public partial class FindReplace : Form
    {
        public event Action<string, string, bool> FindReplaceAction;

        public FindReplace()
        {
            InitializeComponent();
        }

        private void FindReplace_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Languages.msr");
            string language = sr.ReadLine();

            if (language == "Italian")                              //SET LANGUAGE TO ITALIAN IN PREFERENCES FORM
            {
                lbl_find.Text = "Trova";
                lbl_replace.Text = "Sostituisce";
                btn_action.Text = "Trova/Sostituisce";
                btn_cancel.Text = "Cancella";
            }
            else if (language == "Portuguese")                      //SET LANGUAGE TO PORTOGHESE IN PREFERENCES FORM
            {
                lbl_find.Text = "Encontra";
                lbl_replace.Text = "Substituir";
                btn_action.Text = "Encontrar/Substituir";
                btn_cancel.Text = "Anular";
            }
            else if (language == "English")                         //SET LANGUAGE TO ENGLISH IN PREFERENCES FORM
            {
                lbl_find.Text = "Find";
                lbl_replace.Text = "Replace";
                btn_action.Text = "Find/Replace";
                btn_cancel.Text = "Cancel";
            }
            else
                MessageBox.Show("Language not available yet!", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            sr.Close();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }       

        private void btn_action_Click(object sender, EventArgs e)
        {
            string findText = txt_find.Text;
            string replaceText = txt_replace.Text;
            bool replaceMode = !string.IsNullOrEmpty(replaceText);

            // Emetti l'evento per gestire l'azione di ricerca o sostituzione
            FindReplaceAction?.Invoke(findText, replaceText, replaceMode);
        }

        private void FindReplace_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
