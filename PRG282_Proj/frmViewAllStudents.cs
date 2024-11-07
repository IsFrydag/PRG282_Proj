using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG282_Proj
{
    public partial class frmViewAllStudents : Form
    {

        string filePath = "students.txt";
        public frmViewAllStudents()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void frmViewAllStudents_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(string));
            dt.Columns.Add("Course", typeof(string));

            dataGridView1.DataSource = dt;

        }

        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePath);
            string[] values;

            for(int i=0; i<lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] rows=new string[values.Length];

                for(int j=0; j<values.Length; j++)
                {
                    rows[j] = values[j].Trim();
                }
                dt.Rows.Add(rows);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHomePage frm = new frmHomePage();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           thisIsUs us = new thisIsUs();
            us.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            frmAddStudent add = new frmAddStudent();
            add.Show();
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

        private void btnSummaryReport_Click(object sender, EventArgs e)
        {

            frmSummaryReport summary = new frmSummaryReport();
            summary.Show();
            this.Hide();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
