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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblName2_Click(object sender, EventArgs e)
        {

        }

        private void lblName1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            frmAddStudent frmAdd = new frmAddStudent();

            frmAdd.Show();

            this.Hide();

        }


        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnSummaryReport_Click(object sender, EventArgs e)
        {

        }

        private void lblTITLE_Click(object sender, EventArgs e)
        {

        }

        private void lblName3_Click(object sender, EventArgs e)
        {

        }

        private void lblName4_Click(object sender, EventArgs e)
        {

        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateStudentInfo_Click_1(object sender, EventArgs e)
        {
            frmUpdateStudent f2 = new frmUpdateStudent();
            f2.Show();
        }

        private void btnViewAllStudents_Click_1(object sender, EventArgs e)
        {
            frmViewAllStudents f3 = new frmViewAllStudents();
            f3.Show();
        }
    }
}
