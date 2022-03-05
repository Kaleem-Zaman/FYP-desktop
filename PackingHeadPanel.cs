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
    public partial class PackingHeadPanel : Form
    {
        public PackingHeadPanel()
        {
            InitializeComponent();
        }

        private void btnPackingHeadSignOut_Click(object sender, EventArgs e)
        {
            PackingHeadLogin packing = new PackingHeadLogin();
            this.Hide();
            packing.Show();
        }
    }
}
