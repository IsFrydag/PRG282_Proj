using System;
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
        public string fileName = "students.txt";

        int PW;
        bool Hided;

        public frmAddStudent()
        {
            InitializeComponent();
            PW = Spanel.Width;
            Hided = false;

        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {

            //Takes info from file using the Read method and saves it in the students List
            students = Read(fileName);
        }

        public static List<string> students = new List<string>();

        //Read method for reading text file and saving it to a list
        public static List<string> Read(string fileName)
        {
            List<string> lines = new List<string>();
            
            if (!File.Exists(fileName))
            {
                using (FileStream fs = File.Create(fileName)) {//file is created if it does not exist
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.WriteLine("Student Registered");
                    }
                    MessageBox.Show("File created");
                    return lines;
                }
            }

            //stream reader for reading file
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

        //method for saving student info to text file
        private void SaveStudent()
        {
            //error handling for saving info to text file
            try
            {
                //stream writer for writing to text file
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
            //once register button is clicked check if the file exists but creates one if it does not exist
            if (!File.Exists(fileName))
            {
                try
                {
                    using (FileStream fs = File.Create(fileName))
                    {

                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.WriteLine("Students Registered:");
                        }
                    }
                    MessageBox.Show("File Created");


                }
                catch (Exception ex){
                    MessageBox.Show("Error" + ex.Message);
                    return;
                }
            }

            //saves info entered into text boxes into strings and ints
            string studentID = txtStudentID.Text;
            string studentName = txtStudentName.Text;
            int studentAge = Convert.ToInt32(txtStudentAge.Text);
            string studentCourse = cbStudentCourse.Text;

            //created student object using entered student info
            Student student = new Student(studentID, studentName, studentAge, studentCourse);

            //multiple validations to ensure data integrity and consistency
            if(students.Any(s => s.Split(',')[0] == studentID))
            {

                //checks if the ID already exists
                MessageBox.Show("Student ID already exists. Please enter a unique ID.");
                return;

            }
            else if(txtStudentID.Text.Length != 6)
            {

                //checks if the ID is exactly 6 digits long
                MessageBox.Show("Student ID must be exactly 6 digits long.");
                return;

            }
            else if(txtStudentName.Text.Length < 2 || txtStudentName.Text.Length > 20)
            {

                //checks if the student name is longer than 1 character and shorter than 20
                MessageBox.Show("Name must be between 2 and 20 characters long.");
                return;

            }
            else if(int.TryParse(txtStudentAge.Text, out int age) && (age < 14 && age > 99))
            {

                //checks if the student is older than 14 and younger than 99 as there will most likely not be any students older than 99
                MessageBox.Show("Please enter valid age (between the age of 14 and 99).");

            }
            else 
            {

                //if all validations are clear and correct it saves the student object, that was turned into a string, in the text file
                students.Add(student.ToString());
                //savestudent method to write to the text file
                SaveStudent();

                //empties the text boxes for new info
                txtStudentID.Text = "000000";
                txtStudentName.Text = "";
                txtStudentAge.Text = "";
                cbStudentCourse.Text = "";

            }  

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

            //button takes you to homepage
            frmHomePage homePage = new frmHomePage();

            homePage.Show();
            this.Close();

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

            //checks if the ID entered has only integers
            if (!int.TryParse(txtStudentID.Text, out int value))
            {
                MessageBox.Show("Student ID must contain only digits.");
            }

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        { 
               
            //checks if the name entered has only letters and no spaces
            foreach (char c in txtStudentName.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                        
                    MessageBox.Show("Name can only contain letters.");
                    break;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //button takes you to frmthisIsUs
            thisIsUs us = new thisIsUs();
            us.Show();
            this.Hide();

        }

        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {

            //button takes you to frmViewAllStudents
            frmViewAllStudents view = new frmViewAllStudents();
            view.Show();
            this.Hide();

        }

        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {
            
            //button takes you to frmUpdateStudentInfo
            frmUpdateStudent up = new frmUpdateStudent();
            up.Show();
            this.Hide();

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            //button takes you to frmDeleteStudent
            frmDeleteStudent delete = new frmDeleteStudent();
            delete.Show();
            this.Hide();

        }

        private void btnSummaryReport_Click(object sender, EventArgs e)
        {

            //button takes you to frmSummaryReport
            frmSummaryReport sum = new frmSummaryReport();
            sum.Show();
            this.Hide();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

            //X button in the top right of the window to exit the application
            Application.Exit();

        }

        private void hideBtn_Click(object sender, EventArgs e)
        {

            //button hides navigation panel on the left
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
