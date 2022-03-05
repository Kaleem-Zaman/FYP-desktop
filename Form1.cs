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
    public partial class getStarted : Form
    {
        public getStarted()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cashierImageButton_Click(object sender, EventArgs e)
        {
            
        }

        private void packingHeadImageButton_Click(object sender, EventArgs e)
        {
            
        }

        private void securityHeadImageButton_Click(object sender, EventArgs e)
        {
            
        }

        private void cashierImageButton_Click_1(object sender, EventArgs e)
        {
            CashierLogin login = new CashierLogin();
            login.Show();
            this.Hide();
        }

        private void packingHeadImageButton_Click_1(object sender, EventArgs e)
        {
            PackingHeadLogin login = new PackingHeadLogin();
            login.Show();
            this.Hide();
        }

        private void securityHeadImageButton_Click_1(object sender, EventArgs e)
        {
            SecurityHeadPanel security = new SecurityHeadPanel();
            security.Show();
            this.Hide();
        }
    }
}
