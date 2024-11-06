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
    public partial class frmSummaryReport : Form
    {
        public frmSummaryReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOurTeam us = new frmOurTeam();
            us.Show();
        }

        private void frmSummaryReport_Load(object sender, EventArgs e)
        {

            frmSummaryReport sum = new frmSummaryReport();
            sum.Show();
            this.Hide();

        }

        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {

            frmViewAllStudents view = new frmViewAllStudents();
            view.Show();
            this.Hide();

        }

        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {

            frmUpdateStudent up = new frmUpdateStudent();
            up.Show();
            this.Hide();

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            frmDeleteStudent delete = new frmDeleteStudent();
            delete.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            frmHomePage home = new frmHomePage();
            home.Show();
            this.Hide();

        }
    }
}
