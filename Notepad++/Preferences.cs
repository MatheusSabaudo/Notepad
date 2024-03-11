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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notepad__
{
    public partial class Preferences : Form
    {

        public Preferences()
        {
            InitializeComponent();

            // Available themes

            cmb_theme.Items.Add("Dark");                //01
            cmb_theme.Items.Add("Dark Light");          //02
            cmb_theme.Items.Add("Dark Blue");           //03
            cmb_theme.Items.Add("Light");               //04
            cmb_theme.Items.Add("Hacker");              //05

            // default theme
            cmb_theme.SelectedIndex = 0; //DARK

            // Available languages

            cmb_language.Items.Add("English");          //01
            cmb_language.Items.Add("Italian");          //02
            cmb_language.Items.Add("Portuguese");       //03

            // default language
            cmb_language.SelectedIndex = 0; //ENGLISH
        }



        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Preferences_DoubleClick(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //THEME SETUP

            StreamWriter sw_theme = new StreamWriter("Theme.msr", false);
            sw_theme.WriteLine(cmb_theme.SelectedItem.ToString());
            sw_theme.Close();

            //LANGUAGE SETUP

            StreamWriter sw_language = new StreamWriter("Languages.msr", false); //LANGUAGE SELECTED TO USE
            sw_language.WriteLine(cmb_language.SelectedItem.ToString());
            sw_language.Close();

            new Main().Show();                                      //RETURNS TO THE MAIN PAGE WITH THE CONFIG SELECTED
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            new Main().Show();                                      //RETURNS TO THE MAIN PAGE DISCARDING ALL THE CONFIG SELECTED
            this.Hide();
        }

        private void cmb_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamWriter sw_language = new StreamWriter("Languages.msr", false); //LANGUAGE SELECTED TO USE
            sw_language.WriteLine(cmb_language.SelectedItem.ToString());
            sw_language.Close();

            StreamReader sr_language = new StreamReader("Languages.msr"); //READ THE LANGUAGE FILE TO SET THE LANGUAGE IN THE PREFERENCES FORM
            string language = sr_language.ReadLine();

            if (language == "Italian")                              //SET LANGUAGE TO ITALIAN IN PREFERENCES FORM
            {
                lbl_preferences.Text = "PREFERENZE";
                lbl_theme.Text = "TEMA";
                lbl_language.Text = "LINGUA";
                btn_confirm.Text = "CONFERMA";
                btn_cancel.Text = "CANCELLA";
                fileToolStripMenuItem.Text = "Archivio";
                helpToolStripMenuItem.Text = "Aiuto";
            }
            else if (language == "Portuguese")                      //SET LANGUAGE TO PORTOGHESE IN PREFERENCES FORM
            {
                lbl_preferences.Text = "PREFERENCIAS";
                lbl_theme.Text = "TEMA";
                lbl_language.Text = "LINGUA";
                btn_confirm.Text = "CONFIRMAR";
                btn_cancel.Text = "CANCELAR";
                fileToolStripMenuItem.Text = "File";
                helpToolStripMenuItem.Text = "Ajuda";
            }
            else if(language == "English")
            {
                lbl_preferences.Text = "PREFERENCES";
                lbl_theme.Text = "THEME";
                lbl_language.Text = "LANGUAGE";
                btn_confirm.Text = "CONFIRM";
                btn_cancel.Text = "CANCEL";
                fileToolStripMenuItem.Text = "File";
                helpToolStripMenuItem.Text = "Help";
            }
            else
                MessageBox.Show("Language not available yet!", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            sr_language.Close();
        }
    }
}
