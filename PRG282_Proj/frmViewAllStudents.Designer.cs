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
            this.btnViewAllStudents = new System.Windows.Forms.Button();
            this.lblViewAllStudents = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewAllStudents
            // 
            this.btnViewAllStudents.BackColor = System.Drawing.Color.CadetBlue;
            this.btnViewAllStudents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewAllStudents.Location = new System.Drawing.Point(511, 320);
            this.btnViewAllStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewAllStudents.Name = "btnViewAllStudents";
            this.btnViewAllStudents.Size = new System.Drawing.Size(68, 35);
            this.btnViewAllStudents.TabIndex = 0;
            this.btnViewAllStudents.Text = "View All";
            this.btnViewAllStudents.UseVisualStyleBackColor = false;
            this.btnViewAllStudents.Click += new System.EventHandler(this.btnViewAllStudents_Click);
            // 
            // lblViewAllStudents
            // 
            this.lblViewAllStudents.AutoSize = true;
            this.lblViewAllStudents.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblViewAllStudents.Location = new System.Drawing.Point(166, 18);
            this.lblViewAllStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewAllStudents.Name = "lblViewAllStudents";
            this.lblViewAllStudents.Size = new System.Drawing.Size(278, 33);
            this.lblViewAllStudents.TabIndex = 1;
            this.lblViewAllStudents.Text = "View All Students:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(265, 366);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(568, 236);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmViewAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 405);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblViewAllStudents);
            this.Controls.Add(this.btnViewAllStudents);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(616, 444);
            this.MinimumSize = new System.Drawing.Size(616, 405);
            this.Name = "frmViewAllStudents";
            this.Text = "frmViewAllStudents";
            this.Load += new System.EventHandler(this.frmViewAllStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewAllStudents;
        private System.Windows.Forms.Label lblViewAllStudents;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}