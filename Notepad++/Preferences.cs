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

            cmb_theme.Items.Add("Dark");
            cmb_theme.Items.Add("Dark Light");
            cmb_theme.Items.Add("Dark Blue");
            cmb_theme.Items.Add("Light");
            cmb_theme.Items.Add("Hacker");

            // default theme
            cmb_theme.SelectedIndex = 0;

            // Available languages

            cmb_language.Items.Add("English");
            cmb_language.Items.Add("Italian");
            cmb_language.Items.Add("Portuguese");

            // default theme
            cmb_language.SelectedIndex = 0;
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

        public event EventHandler ThemeChanged;
        public string SelectedTheme { get; private set; }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //THEME SETUP

            StreamWriter sw = new StreamWriter("Theme.msr", false);
            sw.WriteLine(cmb_theme.SelectedItem.ToString());
            sw.Close();

            //LANGUAGE SETUP
            if (cmb_language.SelectedIndex == 1)
            {
                btn_confirm.Text = "CONFERMA";
                fileToolStripMenuItem.Text = "Archivio";
                helpToolStripMenuItem.Text = "Aiuto";
            }

            if(cmb_language.SelectedIndex == -1 && cmb_theme.SelectedIndex == -1)
            {
                MessageBox.Show("Empty values are not accepted! \n Campi lasciati vuoti non sono accetabili! \n Campos deixados em branco nao sao aceitaveis!", "CRITICAL ERROR", MessageBoxButtons.OK);
            }
            else
            {
                new Main().Show();
                this.Hide();
            }
        }

       
    }
}
