namespace PresentationLayer
{
    partial class FormRoomStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomStudents));
            this.dataGridViewRoomStudents = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblFloorValue = new System.Windows.Forms.Label();
            this.lblNumberValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomStudents)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRoomStudents
            // 
            this.dataGridViewRoomStudents.AllowUserToAddRows = false;
            this.dataGridViewRoomStudents.AllowUserToDeleteRows = false;
            this.dataGridViewRoomStudents.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewRoomStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.OIB,
            this.Course,
            this.Year});
            this.dataGridViewRoomStudents.Location = new System.Drawing.Point(802, 396);
            this.dataGridViewRoomStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRoomStudents.Name = "dataGridViewRoomStudents";
            this.dataGridViewRoomStudents.ReadOnly = true;
            this.dataGridViewRoomStudents.RowTemplate.Height = 24;
            this.dataGridViewRoomStudents.Size = new System.Drawing.Size(644, 261);
            this.dataGridViewRoomStudents.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // OIB
            // 
            this.OIB.DataPropertyName = "OIB";
            this.OIB.HeaderText = "OIB";
            this.OIB.Name = "OIB";
            this.OIB.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.lblFloor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFloor.Location = new System.Drawing.Point(1006, 96);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(96, 41);
            this.lblFloor.TabIndex = 1;
            this.lblFloor.Text = "Kat:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.lblNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNumber.Location = new System.Drawing.Point(888, 173);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(214, 41);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Broj sobe:";
            // 
            // lblFloorValue
            // 
            this.lblFloorValue.AutoSize = true;
            this.lblFloorValue.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lblFloorValue.Location = new System.Drawing.Point(1134, 103);
            this.lblFloorValue.Name = "lblFloorValue";
            this.lblFloorValue.Size = new System.Drawing.Size(85, 31);
            this.lblFloorValue.TabIndex = 3;
            this.lblFloorValue.Text = "Floor";
            // 
            // lblNumberValue
            // 
            this.lblNumberValue.AutoSize = true;
            this.lblNumberValue.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lblNumberValue.Location = new System.Drawing.Point(1134, 180);
            this.lblNumberValue.Name = "lblNumberValue";
            this.lblNumberValue.Size = new System.Drawing.Size(205, 31);
            this.lblNumberValue.TabIndex = 4;
            this.lblNumberValue.Text = "RoomNumber";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 849);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 115);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormRoomStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1475, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNumberValue);
            this.Controls.Add(this.lblFloorValue);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.dataGridViewRoomStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRoomStudents";
            this.Text = "Studenti u sobi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRoomStudents;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblNumber;
        public System.Windows.Forms.Label lblFloorValue;
        public System.Windows.Forms.Label lblNumberValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}