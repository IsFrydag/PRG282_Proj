
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG282_Proj
{
    public partial class frmUpdateStudent : Form
    {
        static string fileName = @"students.txt";

        public class Student
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Course { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHomePage f7 = new frmHomePage();
            f7.Show();

        }

        public frmUpdateStudent()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadStudentsFromFile();
          


        }
       
        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Age";
            dataGridView1.Columns[3].Name = "Course";
        }
        private List<Student> students = new List<Student>();

        private void LoadStudentsFromFile()
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    if (values.Length == 4)
                    {
                        students.Add(new Student
                        {
                            ID = values[0].Trim(),
                            Name = values[1].Trim(),
                            Age = int.Parse(values[2].Trim()),
                            Course = values[3].Trim()
                        });
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string studentID = StudentID.Text.Trim(); 
            dataGridView1.Rows.Clear();

            bool studentFound = false;

            foreach (Student student in students)
            {
                if (string.Equals(student.ID, studentID, StringComparison.OrdinalIgnoreCase))
                {
                    dataGridView1.Rows.Add(student.ID, student.Name, student.Age, student.Course);
                    studentFound = true;
                    break; 
                }
            }

            if (!studentFound)
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string studentID = txtStudentID.Text;
            string studentName = txtStudentName.Text;
            int studentAge = Convert.ToInt32(txtStudentAge.Text);
            string studentCourse = cbStudentCourse.Text;

            Student studentToUpdate = students.FirstOrDefault(s => s.ID == studentID);

            if (studentToUpdate != null)
            {
               
                studentToUpdate.Name = studentName;
                studentToUpdate.Age = studentAge;
                studentToUpdate.Course = studentCourse;

               
                SaveStudentsToFile();

                MessageBox.Show("Student information updated successfully.");
                txtStudentID.Clear();
                txtStudentName.Clear();
                txtStudentAge.Clear();
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Student ID not found.");
            }
        
    }
        private void SaveStudentsToFile()
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine($"{student.ID}, {student.Name}, {student.Age}, {student.Course}");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmOurTeam us = new frmOurTeam();
            us.Show();
        }
    }
}