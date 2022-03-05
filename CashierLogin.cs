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
    public partial class CashierLogin : Form
    {
        public CashierLogin()
        {
            InitializeComponent();
        }

        private void btnCashierSignIn_Click(object sender, EventArgs e)
        {
            CashierPanel cashier = new CashierPanel();
            cashier.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            getStarted gs = new getStarted();
            this.Hide();
            gs.Show();
        }
    }
}
