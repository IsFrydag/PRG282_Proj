﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PRG282_Proj.frmUpdateStudent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRG282_Proj
{
    public partial class frmAddStudent : Form
    {
        static string fileName = "students.txt";
        
        

        public frmAddStudent()
        {
            InitializeComponent();

        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {

            students = Read(fileName);
        }

        public static List<string> students = new List<string>();
        public static List<string> Read(string fileName)
        {
            List<string> lines = new List<string>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }

        private void SaveStudent()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("students.txt"))
                {
                    foreach (string student in students)
                    {
                        writer.WriteLine(student);
                    }
                }

                MessageBox.Show("Student registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't register student: " + ex.Message);
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {          

            string studentID = txtStudentID.Text;
            string studentName = txtStudentName.Text;
            int studentAge = Convert.ToInt32(txtStudentAge.Text);
            string studentCourse = cbStudentCourse.Text;

            Student student = new Student(studentID, studentName, studentAge, studentCourse);

            if(txtStudentID.Text.Length != 6)
            {

                MessageBox.Show("Student ID must be exactly 13 digits long.");
                return;

            }
            else if(string.IsNullOrEmpty(txtStudentName.Text))
            {

                MessageBox.Show("Please enter a name.");
                return;

            }
            else if(txtStudentName.Text.Length < 2 || txtStudentName.Text.Length > 20)
            {

                MessageBox.Show("Name must be between 2 and 20 characters long.");
                return;

            }
            else if(int.TryParse(txtStudentAge.Text, out int age) && (age < 10 || age > 99))
            {
                MessageBox.Show("Please enter valid age.");
            }
            else 
            {

                students.Add(student.ToString());
                SaveStudent();

                txtStudentID.Text = "";
                txtStudentName.Text = "";
                txtStudentAge.Text = "";
                cbStudentCourse.Text = "";

            }


            

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

            frmHomePage homePage = new frmHomePage();

            homePage.Show();
            this.Close();

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentID.Text, out int value))
            {
                MessageBox.Show("Student ID must contain only digits.");
            }
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtStudentName.Text))
            {
                
            }
            else
            {
               
                foreach (char c in txtStudentName.Text)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        
                        MessageBox.Show("Name can only contain letters.");
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           thisIsUs us = new thisIsUs();
            us.Show();
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

        private void btnSummaryReport_Click(object sender, EventArgs e)
        {

            frmSummaryReport sum = new frmSummaryReport();
            sum.Show();
            this.Hide();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
