namespace PRG282_Proj
{
    partial class frmDeleteStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteStudent));
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.txtEnterStudentID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.Spanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSummaryReport = new System.Windows.Forms.Button();
            this.btnUpdateStudentInfo = new System.Windows.Forms.Button();
            this.btnViewAllStudents = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnShowAllRecords = new System.Windows.Forms.Button();
            this.hidePanel = new System.Windows.Forms.Panel();
            this.hideBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Spanel.SuspendLayout();
            this.hidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(258, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Delete a Student";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(180, 108);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(441, 241);
            this.dataGridView.TabIndex = 22;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteStudent.Location = new System.Drawing.Point(428, 355);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(108, 28);
            this.btnDeleteStudent.TabIndex = 23;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // txtEnterStudentID
            // 
            this.txtEnterStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterStudentID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEnterStudentID.Location = new System.Drawing.Point(220, 73);
            this.txtEnterStudentID.Multiline = true;
            this.txtEnterStudentID.Name = "txtEnterStudentID";
            this.txtEnterStudentID.Size = new System.Drawing.Size(316, 28);
            this.txtEnterStudentID.TabIndex = 24;
            this.txtEnterStudentID.Text = "Enter Student ID...";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(559, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 28);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(583, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 35);
            this.exitBtn.TabIndex = 27;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Spanel
            // 
            this.Spanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.Spanel.Controls.Add(this.button4);
            this.Spanel.Controls.Add(this.btnSummaryReport);
            this.Spanel.Controls.Add(this.btnAddStudent);
            this.Spanel.Controls.Add(this.btnUpdateStudentInfo);
            this.Spanel.Controls.Add(this.btnViewAllStudents);
            this.Spanel.Controls.Add(this.btnBack);
            this.Spanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Spanel.Location = new System.Drawing.Point(0, 0);
            this.Spanel.Name = "Spanel";
            this.Spanel.Size = new System.Drawing.Size(155, 392);
            this.Spanel.TabIndex = 28;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(0, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 54);
            this.button4.TabIndex = 32;
            this.button4.Text = "Settings";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.btnSummaryReport.Location = new System.Drawing.Point(0, 267);
            this.btnSummaryReport.Name = "btnSummaryReport";
            this.btnSummaryReport.Size = new System.Drawing.Size(155, 63);
            this.btnSummaryReport.TabIndex = 30;
            this.btnSummaryReport.Text = "Summary";
            this.btnSummaryReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSummaryReport.UseVisualStyleBackColor = false;
            this.btnSummaryReport.Click += new System.EventHandler(this.btnSummaryReport_Click);
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
            this.btnUpdateStudentInfo.Location = new System.Drawing.Point(0, 198);
            this.btnUpdateStudentInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateStudentInfo.Name = "btnUpdateStudentInfo";
            this.btnUpdateStudentInfo.Size = new System.Drawing.Size(155, 66);
            this.btnUpdateStudentInfo.TabIndex = 31;
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
            this.btnViewAllStudents.Location = new System.Drawing.Point(0, 133);
            this.btnViewAllStudents.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewAllStudents.Name = "btnViewAllStudents";
            this.btnViewAllStudents.Size = new System.Drawing.Size(155, 65);
            this.btnViewAllStudents.TabIndex = 30;
            this.btnViewAllStudents.Text = "View All Students";
            this.btnViewAllStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewAllStudents.UseVisualStyleBackColor = false;
            this.btnViewAllStudents.Click += new System.EventHandler(this.btnViewAllStudents_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 58);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnAddStudent.Location = new System.Drawing.Point(1, 63);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(155, 67);
            this.btnAddStudent.TabIndex = 29;
            this.btnAddStudent.Text = "Add New Student";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnShowAllRecords
            // 
            this.btnShowAllRecords.BackColor = System.Drawing.Color.CadetBlue;
            this.btnShowAllRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllRecords.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowAllRecords.Location = new System.Drawing.Point(220, 355);
            this.btnShowAllRecords.Name = "btnShowAllRecords";
            this.btnShowAllRecords.Size = new System.Drawing.Size(143, 28);
            this.btnShowAllRecords.TabIndex = 30;
            this.btnShowAllRecords.Text = "Show All Records";
            this.btnShowAllRecords.UseVisualStyleBackColor = false;
            this.btnShowAllRecords.Click += new System.EventHandler(this.btnShowAllRecords_Click);
            // 
            // hidePanel
            // 
            this.hidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.hidePanel.Controls.Add(this.hideBtn);
            this.hidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.hidePanel.Location = new System.Drawing.Point(155, 0);
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(19, 392);
            this.hidePanel.TabIndex = 31;
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
            // frmDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(643, 392);
            this.Controls.Add(this.hidePanel);
            this.Controls.Add(this.btnShowAllRecords);
            this.Controls.Add(this.Spanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEnterStudentID);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(643, 392);
            this.MinimumSize = new System.Drawing.Size(643, 392);
            this.Name = "frmDeleteStudent";
            this.Text = "frmDeleteStudent";
            this.Load += new System.EventHandler(this.frmDeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Spanel.ResumeLayout(false);
            this.hidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.TextBox txtEnterStudentID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel Spanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnViewAllStudents;
        private System.Windows.Forms.Button btnUpdateStudentInfo;
        private System.Windows.Forms.Button btnSummaryReport;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnShowAllRecords;
        private System.Windows.Forms.Panel hidePanel;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.Timer timer1;
    }
}