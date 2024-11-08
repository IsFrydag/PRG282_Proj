namespace PRG282_Proj
{
    partial class frmSummaryReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummaryReport));
            this.lblTotalNumberOfStudents = new System.Windows.Forms.Label();
            this.lblAverageAgeOfStudents = new System.Windows.Forms.Label();
            this.btnSaveSummary = new System.Windows.Forms.Button();
            this.txtTotalNumberOfStudents = new System.Windows.Forms.TextBox();
            this.txtAverageAgeOfStudents = new System.Windows.Forms.TextBox();
            this.lblSummaryReport = new System.Windows.Forms.Label();
            this.Spanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdateStudentInfo = new System.Windows.Forms.Button();
            this.btnViewAllStudents = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hidePanel = new System.Windows.Forms.Panel();
            this.hideBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Spanel.SuspendLayout();
            this.hidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalNumberOfStudents
            // 
            this.lblTotalNumberOfStudents.AutoSize = true;
            this.lblTotalNumberOfStudents.Location = new System.Drawing.Point(189, 178);
            this.lblTotalNumberOfStudents.Name = "lblTotalNumberOfStudents";
            this.lblTotalNumberOfStudents.Size = new System.Drawing.Size(128, 13);
            this.lblTotalNumberOfStudents.TabIndex = 0;
            this.lblTotalNumberOfStudents.Text = "Total Number of Students";
            // 
            // lblAverageAgeOfStudents
            // 
            this.lblAverageAgeOfStudents.AutoSize = true;
            this.lblAverageAgeOfStudents.Location = new System.Drawing.Point(189, 250);
            this.lblAverageAgeOfStudents.Name = "lblAverageAgeOfStudents";
            this.lblAverageAgeOfStudents.Size = new System.Drawing.Size(126, 13);
            this.lblAverageAgeOfStudents.TabIndex = 1;
            this.lblAverageAgeOfStudents.Text = "Average Age of Students";
            // 
            // btnSaveSummary
            // 
            this.btnSaveSummary.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSaveSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSummary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveSummary.Location = new System.Drawing.Point(283, 344);
            this.btnSaveSummary.Name = "btnSaveSummary";
            this.btnSaveSummary.Size = new System.Drawing.Size(108, 27);
            this.btnSaveSummary.TabIndex = 2;
            this.btnSaveSummary.Text = "Save Summary";
            this.btnSaveSummary.UseVisualStyleBackColor = false;
            this.btnSaveSummary.Click += new System.EventHandler(this.btnSaveSummary_Click);
            // 
            // txtTotalNumberOfStudents
            // 
            this.txtTotalNumberOfStudents.Location = new System.Drawing.Point(384, 175);
            this.txtTotalNumberOfStudents.Name = "txtTotalNumberOfStudents";
            this.txtTotalNumberOfStudents.Size = new System.Drawing.Size(108, 20);
            this.txtTotalNumberOfStudents.TabIndex = 3;
            this.txtTotalNumberOfStudents.TextChanged += new System.EventHandler(this.txtTotalNumberOfStudents_TextChanged);
            // 
            // txtAverageAgeOfStudents
            // 
            this.txtAverageAgeOfStudents.Location = new System.Drawing.Point(384, 247);
            this.txtAverageAgeOfStudents.Name = "txtAverageAgeOfStudents";
            this.txtAverageAgeOfStudents.Size = new System.Drawing.Size(108, 20);
            this.txtAverageAgeOfStudents.TabIndex = 4;
            this.txtAverageAgeOfStudents.TextChanged += new System.EventHandler(this.txtAverageAgeOfStudents_TextChanged);
            // 
            // lblSummaryReport
            // 
            this.lblSummaryReport.AutoSize = true;
            this.lblSummaryReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.lblSummaryReport.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryReport.Location = new System.Drawing.Point(186, 62);
            this.lblSummaryReport.Name = "lblSummaryReport";
            this.lblSummaryReport.Size = new System.Drawing.Size(260, 33);
            this.lblSummaryReport.TabIndex = 22;
            this.lblSummaryReport.Text = "Summary Report";
            // 
            // Spanel
            // 
            this.Spanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.Spanel.Controls.Add(this.button2);
            this.Spanel.Controls.Add(this.btnUpdateStudentInfo);
            this.Spanel.Controls.Add(this.btnDeleteStudent);
            this.Spanel.Controls.Add(this.btnViewAllStudents);
            this.Spanel.Controls.Add(this.btnAddStudent);
            this.Spanel.Controls.Add(this.btnBack);
            this.Spanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Spanel.Location = new System.Drawing.Point(0, 0);
            this.Spanel.Name = "Spanel";
            this.Spanel.Size = new System.Drawing.Size(159, 401);
            this.Spanel.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 54);
            this.button2.TabIndex = 27;
            this.button2.Text = "Settings";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btnUpdateStudentInfo.Location = new System.Drawing.Point(0, 197);
            this.btnUpdateStudentInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateStudentInfo.Name = "btnUpdateStudentInfo";
            this.btnUpdateStudentInfo.Size = new System.Drawing.Size(159, 66);
            this.btnUpdateStudentInfo.TabIndex = 25;
            this.btnUpdateStudentInfo.Text = "Update Student";
            this.btnUpdateStudentInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateStudentInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdateStudentInfo.UseVisualStyleBackColor = false;
            this.btnUpdateStudentInfo.Click += new System.EventHandler(this.btnUpdateStudentInfo_Click);
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
            this.btnViewAllStudents.Location = new System.Drawing.Point(0, 132);
            this.btnViewAllStudents.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewAllStudents.Name = "btnViewAllStudents";
            this.btnViewAllStudents.Size = new System.Drawing.Size(159, 65);
            this.btnViewAllStudents.TabIndex = 24;
            this.btnViewAllStudents.Text = "View All Students";
            this.btnViewAllStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewAllStudents.UseVisualStyleBackColor = false;
            this.btnViewAllStudents.Click += new System.EventHandler(this.btnViewAllStudents_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.Location = new System.Drawing.Point(0, 62);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(159, 67);
            this.btnAddStudent.TabIndex = 24;
            this.btnAddStudent.Text = "Add New Student";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 56);
            this.btnBack.TabIndex = 24;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnDeleteStudent.Location = new System.Drawing.Point(0, 266);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(156, 72);
            this.btnDeleteStudent.TabIndex = 26;
            this.btnDeleteStudent.Text = "Remove Student";
            this.btnDeleteStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(482, 6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 35);
            this.exitBtn.TabIndex = 29;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hidePanel
            // 
            this.hidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.hidePanel.Controls.Add(this.hideBtn);
            this.hidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.hidePanel.Location = new System.Drawing.Point(159, 0);
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(19, 401);
            this.hidePanel.TabIndex = 32;
            // 
            // hideBtn
            // 
            this.hideBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.hideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBtn.Image = ((System.Drawing.Image)(resources.GetObject("hideBtn.Image")));
            this.hideBtn.Location = new System.Drawing.Point(0, 167);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(19, 56);
            this.hideBtn.TabIndex = 26;
            this.hideBtn.UseVisualStyleBackColor = true;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 401);
            this.Controls.Add(this.hidePanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.Spanel);
            this.Controls.Add(this.lblSummaryReport);
            this.Controls.Add(this.txtAverageAgeOfStudents);
            this.Controls.Add(this.txtTotalNumberOfStudents);
            this.Controls.Add(this.btnSaveSummary);
            this.Controls.Add(this.lblAverageAgeOfStudents);
            this.Controls.Add(this.lblTotalNumberOfStudents);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(537, 401);
            this.MinimumSize = new System.Drawing.Size(537, 401);
            this.Name = "frmSummaryReport";
            this.Text = "frmSummaryReport";
            this.Load += new System.EventHandler(this.frmSummaryReport_Load);
            this.Spanel.ResumeLayout(false);
            this.hidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalNumberOfStudents;
        private System.Windows.Forms.Label lblAverageAgeOfStudents;
        private System.Windows.Forms.Button btnSaveSummary;
        private System.Windows.Forms.TextBox txtTotalNumberOfStudents;
        private System.Windows.Forms.TextBox txtAverageAgeOfStudents;
        private System.Windows.Forms.Label lblSummaryReport;
        private System.Windows.Forms.Panel Spanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnViewAllStudents;
        private System.Windows.Forms.Button btnUpdateStudentInfo;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel hidePanel;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.Timer timer1;
    }
}