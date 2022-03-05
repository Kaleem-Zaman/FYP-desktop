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
    public partial class CashierPanel : Form
    {
        public CashierPanel()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnCashierSignOut_Click(object sender, EventArgs e)
        {
            CashierLogin login = new CashierLogin();
            login.Show();
            this.Hide();
        }
    }
}
