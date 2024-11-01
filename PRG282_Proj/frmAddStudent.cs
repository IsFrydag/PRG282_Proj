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

namespace PRG282_Proj
{
    public partial class frmAddStudent : Form
    {
        static string fileName = "students.txt";

        private NotifyEvent notifyEvent = new NotifyEvent();

        public frmAddStudent()
        {
            InitializeComponent();

            notifyEvent.OnAddStudent += OnAddStudentButtonClicked;
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {

        }

        private void OnAddStudentButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Student Registered");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            notifyEvent.RaiseOnAddStudent();

            string studentID = txtStudentID.Text;
            string studentName = txtStudentName.Text;
            int studentAge = Convert.ToInt32(txtStudentAge.Text);
            string studentCourse = cbStudentCourse.Text;

            string line = studentID + ", " + studentName + ", " + studentAge + ", " + studentCourse;

            FileStream myStream = new FileStream(fileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(myStream);

            writer.WriteLine(line);

            writer.Close();
            myStream.Close();

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {


            frmHomePage homePage = new frmHomePage();

            homePage.Show();
            this.Close();

        }
    }
}
