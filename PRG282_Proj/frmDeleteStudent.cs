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

        int PW;
        bool Hided;

        public frmDeleteStudent()
        {
            InitializeComponent();
            PW = Spanel.Width;
            Hided = false;
            //When you click on a cell then it selects the entire row.
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Prevent cells from being edited.
            dataGridView.ReadOnly = true;

        }

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

        DataTable dt = new DataTable();
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
                MessageBox.Show("Please enter ID with 6 digits.");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {

                List<int> ids = new List<int>();
                foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
                {
                    int selectedId = (int)selectedRow.Cells["ID"].Value;
                    ids.Add(selectedId);
                }

                string idsToDelete = string.Join(", ", ids);
                var result = MessageBox.Show($"Are you sure you want to delete the record with IDs {idsToDelete}?",
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
                            if (!ids.Contains(id))
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
                        MessageBox.Show($"{idsToDelete} deleted from the file.");
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

        private void hideBtn_Click(object sender, EventArgs e)
        {
            if (Hided) hideBtn.Text = "";
            else hideBtn.Text = "";
            timer1.Start();
        }
    }
}
