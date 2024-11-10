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

        string filePath = "students.txt";//text file that will store student data

        int PW;//PW=panel width
        bool Hided;

        public frmViewAllStudents()
        {
            InitializeComponent();
            PW = Spanel.Width;
            Hided = false; 
        }
        //creates instance of data table
        DataTable dt = new DataTable();

        //creates column heading names
        private void frmViewAllStudents_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));//column heading added named ID with a field type identified as int
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(string));
            dt.Columns.Add("Course", typeof(string));

            //binds dt table to datagridview1, makes dt table visible
            dataGridView1.DataSource = dt;

            //When you click on a cell then it selects the entire row.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Prevent cells from being edited.
            dataGridView1.ReadOnly = true;

        }
        //button to display all students information
        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();//refreshes datagridview so that student information is not duplicated when 'View All' button clicked more than once

            string[] lines = File.ReadAllLines(filePath); //lines array stores text from students.txt file as an array of strings
            string[] values;//values array stored text with different types of fields

            for(int i=0; i<lines.Length; i++)
            {
                values = lines[i].ToString().Split(','); //values splits lines into different fields, w/ "," separation
                string[] rows=new string[values.Length];//rows array stores records  ...record=["222222", "John","21", "BIT" ]

                for(int j=0; j<values.Length; j++)//inner for loop further formats records by trimming any excess blank space before insert into data table
                {
                    rows[j] = values[j].Trim();
                }
                dt.Rows.Add(rows);//put rows array as Rows of data table in datagridview
            }
        }
        //button takes you to homepage
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHomePage frm = new frmHomePage();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)//button to go to thisIsUs form displaying app creators info
        {
           thisIsUs us = new thisIsUs();
            us.Show();
        }
        //button to go to form to add new student
        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            frmAddStudent add = new frmAddStudent();
            add.Show();
            this.Hide();

        }
        //button takes you to frmUpdateStudentInfo
        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {

            frmUpdateStudent up = new frmUpdateStudent();
            up.Show();
            this.Hide();

        }
        //button takes you to frmDeleteStudent
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            frmDeleteStudent delete = new frmDeleteStudent();
            delete.Show();
            this.Hide();

        }
        //button takes you to frmSummaryReport
        private void btnSummaryReport_Click(object sender, EventArgs e)
        {

            frmSummaryReport summary = new frmSummaryReport();
            summary.Show();
            this.Hide();

        }
        //X button in the top right of the window to exit the application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //button hides navigation panel on the left
        private void hideBtn_Click(object sender, EventArgs e)
        {
            if (Hided) hideBtn.Text = "";
            else hideBtn.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this method helps with making the open and closing of the panel smoother

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
