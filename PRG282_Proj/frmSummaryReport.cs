﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRG282_Proj
{
    public partial class frmSummaryReport : Form
    {
        int PW;
        bool Hided;

        public frmSummaryReport()
        {
            InitializeComponent();
            PW = Spanel.Width;
            Hided = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button takes you to frmthisIsUs

            thisIsUs us = new thisIsUs();
            us.Show();
            this.Hide();
        }

        private void frmSummaryReport_Load(object sender, EventArgs e)
        {


            //The form loads, when the form loads, do the following.
            string fileName = "students.txt";

            if (File.Exists(fileName))
            {
                try
                {
                    //Write file contents to string.
                    string[] lines = File.ReadAllLines(fileName);
                    int totalStudents = lines.Length;
                    int totalAge = 0;
                    

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        string[] parts = line.Split(',');

                        if (parts.Length > 0)
                        {
                            string ageString = parts[2].Trim();
                            //Add to total age.
                            totalAge += int.Parse(ageString);
                        }
                    }

                    //Calculate average age.
                    double averageAge = (double)totalAge / totalStudents;

                    txtTotalNumberOfStudents.Text = totalStudents.ToString();
                    txtAverageAgeOfStudents.Text = averageAge.ToString(); 
                   


                }
                catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }

            else
            {
                MessageBox.Show($"{fileName} not found.");
            }

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            //button takes you to homepage

            frmHomePage home = new frmHomePage();
            home.Show();
            this.Hide();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //X button in the top right of the window to exit the application

            Application.Exit();
        }

        private void txtTotalNumberOfStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAverageAgeOfStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveSummary_Click(object sender, EventArgs e)
        {
            string saveSummary = "summary.txt";

            string totalStudents = txtTotalNumberOfStudents.Text;
            string averageAge = txtAverageAgeOfStudents.Text;
            
            string content = totalStudents + ", " + averageAge;

            try
            {
                //Write to file, the content.
                File.WriteAllText(saveSummary, content);
                MessageBox.Show("Summary saved to " + saveSummary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
