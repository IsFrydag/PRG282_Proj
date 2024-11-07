using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Proj
{
    public partial class thisIsUs : Form
    {
        public thisIsUs()
        {
            InitializeComponent();
        }

        private void btnMilenke_Click(object sender, EventArgs e)
        {
            frmMilenkeField milenke = new frmMilenkeField();
            milenke.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            frmHomePage home = new frmHomePage();
            home.Show();
            this.Hide();
        }

        private void btnJana_Click(object sender, EventArgs e)
        {
            frmJanaRademan jana = new frmJanaRademan();
            jana.Show();
            this.Hide();
        }

        private void btnArmand_Click(object sender, EventArgs e)
        {
            frmArmandSnyman armand = new frmArmandSnyman();
            armand.Show();
            this.Hide();
        }

        private void btnHeiner_Click(object sender, EventArgs e)
        {
            frmHeinerFreitag heiner = new frmHeinerFreitag();
            heiner.Show();
            this.Hide();
        }
    }
}
