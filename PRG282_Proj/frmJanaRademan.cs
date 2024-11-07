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
    public partial class frmJanaRademan : Form
    {
        public frmJanaRademan()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            thisIsUs us = new thisIsUs();
            us.Show();
            this.Hide();
        }
    }
}
