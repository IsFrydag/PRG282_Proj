namespace PRG282_Proj
{
    partial class frmViewAllStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAllStudents));
            this.btnViewAllStudents = new System.Windows.Forms.Button();
            this.lblViewAllStudents = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Spanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnSummaryReport = new System.Windows.Forms.Button();
            this.btnUpdateStudentInfo = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hidePanel = new System.Windows.Forms.Panel();
            this.hideBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Spanel.SuspendLayout();
            this.hidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewAllStudents
            // 
            this.btnViewAllStudents.BackColor = System.Drawing.Color.CadetBlue;
            this.btnViewAllStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAllStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllStudents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewAllStudents.Location = new System.Drawing.Point(545, 359);
            this.btnViewAllStudents.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAllStudents.Name = "btnViewAllStudents";
            this.btnViewAllStudents.Size = new System.Drawing.Size(68, 29);
            this.btnViewAllStudents.TabIndex = 0;
            this.btnViewAllStudents.Text = "View All";
            this.btnViewAllStudents.UseVisualStyleBackColor = false;
            this.btnViewAllStudents.Click += new System.EventHandler(this.btnViewAllStudents_Click);
            // 
            // lblViewAllStudents
            // 
            this.lblViewAllStudents.AutoSize = true;
            this.lblViewAllStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.lblViewAllStudents.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblViewAllStudents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewAllStudents.Location = new System.Drawing.Point(196, 25);
            this.lblViewAllStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewAllStudents.Name = "lblViewAllStudents";
            this.lblViewAllStudents.Size = new System.Drawing.Size(278, 33);
            this.lblViewAllStudents.TabIndex = 1;
            this.lblViewAllStudents.Text = "View All Students:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 58);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(192, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 236);
            this.dataGridView1.TabIndex = 3;
            // 
            // Spanel
            // 
            this.Spanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.Spanel.Controls.Add(this.button2);
            this.Spanel.Controls.Add(this.btnDeleteStudent);
            this.Spanel.Controls.Add(this.btnSummaryReport);
            this.Spanel.Controls.Add(this.btnUpdateStudentInfo);
            this.Spanel.Controls.Add(this.btnAddStudent);
            this.Spanel.Controls.Add(this.btnBack);
            this.Spanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Spanel.ForeColor = System.Drawing.Color.Navy;
            this.Spanel.Location = new System.Drawing.Point(0, 0);
            this.Spanel.Name = "Spanel";
            this.Spanel.Size = new System.Drawing.Size(146, 399);
            this.Spanel.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 54);
            this.button2.TabIndex = 24;
            this.button2.Text = "Settings";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btnDeleteStudent.Location = new System.Drawing.Point(0, 197);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(146, 72);
            this.btnDeleteStudent.TabIndex = 19;
            this.btnDeleteStudent.Text = "Remove Student";
            this.btnDeleteStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
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
            this.btnSummaryReport.Location = new System.Drawing.Point(0, 275);
            this.btnSummaryReport.Name = "btnSummaryReport";
            this.btnSummaryReport.Size = new System.Drawing.Size(146, 63);
            this.btnSummaryReport.TabIndex = 20;
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
            this.btnUpdateStudentInfo.Location = new System.Drawing.Point(0, 128);
            this.btnUpdateStudentInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateStudentInfo.Name = "btnUpdateStudentInfo";
            this.btnUpdateStudentInfo.Size = new System.Drawing.Size(146, 66);
            this.btnUpdateStudentInfo.TabIndex = 18;
            this.btnUpdateStudentInfo.Text = "Update Student";
            this.btnUpdateStudentInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateStudentInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdateStudentInfo.UseVisualStyleBackColor = false;
            this.btnUpdateStudentInfo.Click += new System.EventHandler(this.btnUpdateStudentInfo_Click);
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
            this.btnAddStudent.Location = new System.Drawing.Point(0, 58);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(146, 67);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "Add New Student";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(608, 7);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 35);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hidePanel
            // 
            this.hidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.hidePanel.Controls.Add(this.hideBtn);
            this.hidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.hidePanel.Location = new System.Drawing.Point(146, 0);
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(19, 399);
            this.hidePanel.TabIndex = 34;
            // 
            // hideBtn
            // 
            this.hideBtn.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.hideBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.hideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBtn.Image = ((System.Drawing.Image)(resources.GetObject("hideBtn.Image")));
            this.hideBtn.Location = new System.Drawing.Point(0, 171);
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
            // frmViewAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(658, 399);
            this.Controls.Add(this.hidePanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.Spanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblViewAllStudents);
            this.Controls.Add(this.btnViewAllStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(658, 399);
            this.MinimumSize = new System.Drawing.Size(658, 399);
            this.Name = "frmViewAllStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewAllStudents";
            this.Load += new System.EventHandler(this.frmViewAllStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Spanel.ResumeLayout(false);
            this.hidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewAllStudents;
        private System.Windows.Forms.Label lblViewAllStudents;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel Spanel;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdateStudentInfo;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSummaryReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel hidePanel;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.Timer timer1;
    }
}