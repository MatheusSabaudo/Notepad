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

            //TRANSLATION PART - TO DO

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
