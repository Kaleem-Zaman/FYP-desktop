using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class PackingHeadLogin : Form
    {
        public PackingHeadLogin()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            PackingHeadPanel panel = new PackingHeadPanel();
            this.Hide();
            panel.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            getStarted gs = new getStarted();
            this.Hide();
            gs.Show();
        }
    }
}
