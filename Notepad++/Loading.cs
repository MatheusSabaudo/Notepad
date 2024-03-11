using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            tmr_loadingtime.Enabled = true;
            tmr_loadingtime.Start();
            prg_loading.Value = 0;
        }

        private void tmr_loadingtime_Tick(object sender, EventArgs e)
        {
            prg_loading.Value += 10;

            if (prg_loading.Value >= 100)
            {
                // Stop the timer if progress reaches 100
                tmr_loadingtime.Stop();

                new Main().Show();
                this.Hide();
            }
        }
    }
}
