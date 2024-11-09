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

        int PW;
        bool Hided;

        public frmViewAllStudents()
        {
            InitializeComponent();
            PW = Spanel.Width;
            Hided = false;
        }
        DataTable dt = new DataTable();
        private void frmViewAllStudents_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(string));
            dt.Columns.Add("Course", typeof(string));

            dataGridView1.DataSource = dt;

            //When you click on a cell then it selects the entire row.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Prevent cells from being edited.
            dataGridView1.ReadOnly = true;

        }

        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();

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

        private void hideBtn_Click(object sender, EventArgs e)
        {
            if (Hided) hideBtn.Text = "";
            else hideBtn.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Hided)
            {
                Spanel.Width = Spanel.Width + 20;
                if (Spanel.Width >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                Spanel.Width = Spanel.Width - 20;
                if (Spanel.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }
    }
}
