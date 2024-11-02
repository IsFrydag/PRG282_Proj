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
            this.btnViewAllStudents.Location = new System.Drawing.Point(227, 40);
            this.btnViewAllStudents.Name = "btnViewAllStudents";
            this.btnViewAllStudents.Size = new System.Drawing.Size(339, 43);
            this.btnViewAllStudents.TabIndex = 0;
            this.btnViewAllStudents.Text = "View All";
            this.btnViewAllStudents.UseVisualStyleBackColor = true;
            // 
            // lblViewAllStudents
            // 
            this.lblViewAllStudents.AutoSize = true;
            this.lblViewAllStudents.Location = new System.Drawing.Point(348, 21);
            this.lblViewAllStudents.Name = "lblViewAllStudents";
            this.lblViewAllStudents.Size = new System.Drawing.Size(112, 16);
            this.lblViewAllStudents.TabIndex = 1;
            this.lblViewAllStudents.Text = "View All Students:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(345, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 291);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmViewAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblViewAllStudents);
            this.Controls.Add(this.btnViewAllStudents);
            this.Name = "frmViewAllStudents";
            this.Text = "frmViewAllStudents";
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