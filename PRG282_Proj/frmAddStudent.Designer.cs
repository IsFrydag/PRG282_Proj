namespace PRG282_Proj
{
    partial class frmAddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.lblSID = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.cbStudentCourse = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSummaryReport = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudentInfo = new System.Windows.Forms.Button();
            this.btnViewAllStudents = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.lblSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSID.Location = new System.Drawing.Point(246, 125);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(23, 16);
            this.lblSID.TabIndex = 1;
            this.lblSID.Text = "ID:";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.lblSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSName.Location = new System.Drawing.Point(246, 169);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(47, 16);
            this.lblSName.TabIndex = 2;
            this.lblSName.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(246, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(246, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course :";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(350, 121);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(159, 20);
            this.txtStudentID.TabIndex = 5;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(350, 165);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(159, 20);
            this.txtStudentName.TabIndex = 6;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(350, 203);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(159, 20);
            this.txtStudentAge.TabIndex = 7;
            // 
            // cbStudentCourse
            // 
            this.cbStudentCourse.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbStudentCourse.FormattingEnabled = true;
            this.cbStudentCourse.Items.AddRange(new object[] {
            "BCOMP",
            "BIT",
            "DIT",
            "National Certificate"});
            this.cbStudentCourse.Location = new System.Drawing.Point(350, 240);
            this.cbStudentCourse.Name = "cbStudentCourse";
            this.cbStudentCourse.Size = new System.Drawing.Size(159, 21);
            this.cbStudentCourse.TabIndex = 8;
            this.cbStudentCourse.Text = "Choose a course..";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.Location = new System.Drawing.Point(336, 316);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(68, 31);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 64);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSummaryReport);
            this.panel1.Controls.Add(this.btnDeleteStudent);
            this.panel1.Controls.Add(this.btnUpdateStudentInfo);
            this.panel1.Controls.Add(this.btnViewAllStudents);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 393);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 63);
            this.button1.TabIndex = 26;
            this.button1.Text = "Settings";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSummaryReport
            // 
            this.btnSummaryReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnSummaryReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSummaryReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSummaryReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnSummaryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummaryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummaryReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSummaryReport.Image = ((System.Drawing.Image)(resources.GetObject("btnSummaryReport.Image")));
            this.btnSummaryReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSummaryReport.Location = new System.Drawing.Point(0, 260);
            this.btnSummaryReport.Name = "btnSummaryReport";
            this.btnSummaryReport.Size = new System.Drawing.Size(166, 71);
            this.btnSummaryReport.TabIndex = 26;
            this.btnSummaryReport.Text = "Summary";
            this.btnSummaryReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSummaryReport.UseVisualStyleBackColor = false;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnDeleteStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStudent.Image")));
            this.btnDeleteStudent.Location = new System.Drawing.Point(0, 190);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(166, 72);
            this.btnDeleteStudent.TabIndex = 26;
            this.btnDeleteStudent.Text = "Remove Student";
            this.btnDeleteStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStudentInfo
            // 
            this.btnUpdateStudentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnUpdateStudentInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateStudentInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStudentInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnUpdateStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudentInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateStudentInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateStudentInfo.Image")));
            this.btnUpdateStudentInfo.Location = new System.Drawing.Point(0, 125);
            this.btnUpdateStudentInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateStudentInfo.Name = "btnUpdateStudentInfo";
            this.btnUpdateStudentInfo.Size = new System.Drawing.Size(166, 66);
            this.btnUpdateStudentInfo.TabIndex = 27;
            this.btnUpdateStudentInfo.Text = "Update Student";
            this.btnUpdateStudentInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateStudentInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdateStudentInfo.UseVisualStyleBackColor = false;
            // 
            // btnViewAllStudents
            // 
            this.btnViewAllStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnViewAllStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewAllStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAllStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnViewAllStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllStudents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewAllStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnViewAllStudents.Image")));
            this.btnViewAllStudents.Location = new System.Drawing.Point(0, 60);
            this.btnViewAllStudents.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewAllStudents.Name = "btnViewAllStudents";
            this.btnViewAllStudents.Size = new System.Drawing.Size(166, 65);
            this.btnViewAllStudents.TabIndex = 26;
            this.btnViewAllStudents.Text = "View All Students";
            this.btnViewAllStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewAllStudents.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(552, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 35);
            this.button2.TabIndex = 25;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(243, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Student";
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(602, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbStudentCourse);
            this.Controls.Add(this.txtStudentAge);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddStudent";
            this.Text = "frmAddStudent";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentAge;
        private System.Windows.Forms.ComboBox cbStudentCourse;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAllStudents;
        private System.Windows.Forms.Button btnUpdateStudentInfo;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSummaryReport;
        private System.Windows.Forms.Button button1;
    }
}