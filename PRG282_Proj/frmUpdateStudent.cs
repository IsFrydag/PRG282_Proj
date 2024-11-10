
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

        int PW;     //PW is for Panel Width
        bool Hided;   

        public class Student
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Course { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHomePage home = new frmHomePage();
            home.Show();
            this.Hide();

        }

        public frmUpdateStudent()
        {
            InitializeComponent();
            InitializeDataGridView(); //this method sets up the datagrid
            LoadStudentsFromFile();   //this method reads the student.txt file and adds the student objects to the student list

            PW = Spanel.Width;
            Hided = false; //false means the panel is visible

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
                    string[] values = line.Split(','); //splits each line with a comma
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

            string studentID = StudentID.Text.Trim(); //takes the input from the user
            dataGridView1.Rows.Clear(); //clears the datagrid when seraching

            bool studentFound = false;

            foreach (Student student in students) //iterates through each Student object in the students list
            {
                if (string.Equals(student.ID, studentID, StringComparison.OrdinalIgnoreCase)) //checks if the current student’s ID matches the "target" studentID 
                {
                    dataGridView1.Rows.Add(student.ID, student.Name, student.Age, student.Course); //adds the student’s information to dataGridView1 as a new row
                    studentFound = true; //sets studentFound to true to indicate that the student was found
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
            //retrieves the student’s ID, name, age, and course from the input fields
            string studentID = txtStudentID.Text;
            string studentName = txtStudentName.Text;
            int studentAge = Convert.ToInt32(txtStudentAge.Text);
            string studentCourse = cbStudentCourse.Text;

            Student studentToUpdate = students.FirstOrDefault(s => s.ID == studentID); //finds the student with the given ID in the students list

            if (studentToUpdate != null)
            {
                //updates the student’s name, age, and course
                studentToUpdate.Name = studentName;
                studentToUpdate.Age = studentAge;
                studentToUpdate.Course = studentCourse;

               
                SaveStudentsToFile(); // method called, saves the updated list to a file


                MessageBox.Show("Student information updated successfully.");
                txtStudentID.Clear();
                txtStudentName.Clear();
                txtStudentAge.Clear();
                dataGridView1.Rows.Clear(); //clears the input fields and data grid

            }
            else
            {
                MessageBox.Show("Student ID cannot be changed.");
            }
        
    }
        private void SaveStudentsToFile() //method writes all student records from the students list to the specified file(called earlier)
        {
            using (StreamWriter writer = new StreamWriter(fileName)) //makes sure that the file is properly closed after writing( to avoid potential file access issues later)
            {
                foreach (Student student in students)
                {
                    writer.WriteLine($"{student.ID}, {student.Name}, {student.Age}, {student.Course}");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            thisIsUs us = new thisIsUs();
            us.Show();
            this.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            frmAddStudent add = new frmAddStudent();
            add.Show();
            this.Hide();

        }

        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {

            frmViewAllStudents view = new frmViewAllStudents();
            view.Show();
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

        private void frmUpdateStudent_Load(object sender, EventArgs e)
        {

        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            //when the button gets clicked the timer is started,( sets of the sliding animation)
            if (Hided) hideBtn.Text = "";
            else hideBtn.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                //if Hided is true (panel is hidden), the width of Spanel is incremented by 20 pixels at each tick until it reaches PW, to amke it visible
                Spanel.Width = Spanel.Width + 20;
                if (Spanel.Width >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh(); //the Hided flag is updated to reflect the panel’s new visibility state
                }
            }
            else
            {
                //once the panel reaches the target width, the timer stops,to end the animation
                Spanel.Width = Spanel.Width - 20;
                if (Spanel.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh(); //the Hided flag is updated to reflect the panel’s new visibility state
                }
            }
        }

        private void StudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}