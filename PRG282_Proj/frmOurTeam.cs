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
    public partial class frmOurTeam : Form
    {
        public frmOurTeam()
        {
            InitializeComponent();
        }

        private void frmOurTeam_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmJanaRademan Jan = new frmJanaRademan();
            Jan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMilenkeField field = new frmMilenkeField();
            field.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHeinerFreitag freitag = new frmHeinerFreitag();
            freitag.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmArmandSnyman snyman = new frmArmandSnyman();
            snyman.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

            

        }

    }
}
