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

       
            static string fileName = "students.txt";
            private List<Student> students = new List<Student>();

            public frmUpdateStudent()
            {
                InitializeComponent();
           
        }

            public class Student
            {
                public string ID { get; set; }
                public string Name { get; set; }
                public int Age { get; set; }
                public string Course { get; set; }
            }
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private TextBox txtStudentAge;
        private ComboBox cbStudentCourse;

        private Student FindStudentById(string studentID)
            {
                if (File.Exists(fileName))
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] studentData = line.Split(',');
                            if (studentData.Length == 4)
                            {
                                string id = studentData[0].Trim();
                                string name = studentData[1].Trim();
                                int age = int.Parse(studentData[2].Trim());
                                string course = studentData[3].Trim();

                                if (id == studentID)
                                {
                                    return new Student
                                    {
                                        ID = id,
                                        Name = name,
                                        Age = age,
                                        Course = course
                                    };
                                }
                            }
                        }
                    }
                }
                return null;
            }

            private Student SearchStudent(string id)
            {
                return students.FirstOrDefault(s => s.ID == id);
            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                string studentID = StudentID.Text;
                Student student = FindStudentById(studentID);

                if (student != null)
                {
                    txtStudentName.Text = student.Name;
                    txtStudentAge.Text = student.Age.ToString();
                    cbStudentCourse.Text = student.Course;
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
        }
    }
