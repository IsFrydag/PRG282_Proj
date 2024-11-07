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
    public partial class frmDeleteStudent : Form
    {
        public frmDeleteStudent()
        {
            InitializeComponent();
        }

        //
        DataTable dt = new DataTable();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {

            frmUpdateStudent up = new frmUpdateStudent();
            up.Show();
            this.Hide();

        }

        private void btnSummaryReport_Click(object sender, EventArgs e)
        {


            frmSummaryReport sum = new frmSummaryReport();
            sum.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            frmHomePage home = new frmHomePage();
            home.Show();
            this.Hide();

        }

        private void frmDeleteStudent_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(string));
            dt.Columns.Add("Course", typeof(string));

            dataGridView.DataSource = dt;

            string[] lines = File.ReadAllLines(@"students.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] rows = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    rows[j] = values[j].Trim();
                }
                dt.Rows.Add(rows);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentIDText = txtEnterStudentID.Text;

            if (int.TryParse(studentIDText, out int id))
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = $"ID = {id}";
                dataGridView.DataSource = dv;
                if (dv.Count == 0)
                {
                    MessageBox.Show("No result found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid input.");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridView.SelectedRows[0].Cells["ID"].Value;

                var result = MessageBox.Show($"Are you sure you want to delete the record with ID {selectedId}?",
                                              "Confirm Deletion",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(@"students.txt");
                    List<string> updatedLines = new List<string>();

                    bool recordFound = false;

                    foreach (string line in lines)
                    {
                        string[] values = line.Split(',');
                        if (values.Length > 0 && int.TryParse(values[0].Trim(), out int id))
                        {
                            if (id != selectedId)
                            {
                                updatedLines.Add(line);
                            }
                            else
                            {
                                recordFound = true;
                            }
                        }
                    }

                    File.WriteAllLines(@"students.txt", updatedLines);

                    dt.Clear();
                    foreach (string updatedLine in updatedLines)
                    {
                        string[] values = updatedLine.Split(',');
                        dt.Rows.Add(values);
                    }

                    dataGridView.DataSource = dt;

                    if (recordFound)
                    {
                        MessageBox.Show($"{selectedId} deleted from the file.");
                    }
                    else
                    {
                        MessageBox.Show("No matching record found to delete.");
                    }
                }
                else
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
            else
            {
                MessageBox.Show("Select an ID.");
            }
        }

        private void btnShowAllRecords_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = dt;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
