namespace PresentationLayer
{
    partial class FormEditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditStudent));
            this.lblEditText = new System.Windows.Forms.Label();
            this.lblEditId = new System.Windows.Forms.Label();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.lblEditOIB = new System.Windows.Forms.Label();
            this.lblEditCourse = new System.Windows.Forms.Label();
            this.lblEditYear = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.textBoxOIB = new System.Windows.Forms.TextBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.lblEditFirstName = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditText
            // 
            this.lblEditText.AutoSize = true;
            this.lblEditText.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold);
            this.lblEditText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEditText.Location = new System.Drawing.Point(844, 87);
            this.lblEditText.Name = "lblEditText";
            this.lblEditText.Size = new System.Drawing.Size(439, 35);
            this.lblEditText.TabIndex = 0;
            this.lblEditText.Text = "Uredite podatke studenta:";
            // 
            // lblEditId
            // 
            this.lblEditId.AutoSize = true;
            this.lblEditId.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEditId.Location = new System.Drawing.Point(790, 216);
            this.lblEditId.Name = "lblEditId";
            this.lblEditId.Size = new System.Drawing.Size(28, 20);
            this.lblEditId.TabIndex = 1;
            this.lblEditId.Text = "Id";
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEditLastName.Location = new System.Drawing.Point(741, 351);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(77, 20);
            this.lblEditLastName.TabIndex = 2;
            this.lblEditLastName.Text = "Prezime";
            // 
            // lblEditOIB
            // 
            this.lblEditOIB.AutoSize = true;
            this.lblEditOIB.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEditOIB.Location = new System.Drawing.Point(1095, 215);
            this.lblEditOIB.Name = "lblEditOIB";
            this.lblEditOIB.Size = new System.Drawing.Size(42, 20);
            this.lblEditOIB.TabIndex = 3;
            this.lblEditOIB.Text = "OIB";
            // 
            // lblEditCourse
            // 
            this.lblEditCourse.AutoSize = true;
            this.lblEditCourse.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEditCourse.Location = new System.Drawing.Point(1076, 284);
            this.lblEditCourse.Name = "lblEditCourse";
            this.lblEditCourse.Size = new System.Drawing.Size(61, 20);
            this.lblEditCourse.TabIndex = 4;
            this.lblEditCourse.Text = "Smjer";
            // 
            // lblEditYear
            // 
            this.lblEditYear.AutoSize = true;
            this.lblEditYear.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEditYear.Location = new System.Drawing.Point(1068, 351);
            this.lblEditYear.Name = "lblEditYear";
            this.lblEditYear.Size = new System.Drawing.Size(69, 20);
            this.lblEditYear.TabIndex = 5;
            this.lblEditYear.Text = "Godina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(850, 216);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(164, 22);
            this.textBoxId.TabIndex = 7;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(850, 285);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(164, 22);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(850, 353);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(164, 22);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(1183, 285);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(164, 22);
            this.textBoxCourse.TabIndex = 11;
            // 
            // textBoxOIB
            // 
            this.textBoxOIB.Location = new System.Drawing.Point(1183, 217);
            this.textBoxOIB.Name = "textBoxOIB";
            this.textBoxOIB.Size = new System.Drawing.Size(164, 22);
            this.textBoxOIB.TabIndex = 12;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCancel.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btnEditCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditCancel.Location = new System.Drawing.Point(708, 501);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(290, 105);
            this.btnEditCancel.TabIndex = 13;
            this.btnEditCancel.Text = "Odustani";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStudent.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btnEditStudent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditStudent.Location = new System.Drawing.Point(1072, 501);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(290, 105);
            this.btnEditStudent.TabIndex = 14;
            this.btnEditStudent.Text = "Potvrdi";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // lblEditFirstName
            // 
            this.lblEditFirstName.AutoSize = true;
            this.lblEditFirstName.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEditFirstName.Location = new System.Drawing.Point(774, 284);
            this.lblEditFirstName.Name = "lblEditFirstName";
            this.lblEditFirstName.Size = new System.Drawing.Size(44, 20);
            this.lblEditFirstName.TabIndex = 15;
            this.lblEditFirstName.Text = "Ime";
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(1183, 353);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(164, 22);
            this.numericUpDownYear.TabIndex = 16;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 726);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1383, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.lblEditFirstName);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.textBoxOIB);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEditYear);
            this.Controls.Add(this.lblEditCourse);
            this.Controls.Add(this.lblEditOIB);
            this.Controls.Add(this.lblEditLastName);
            this.Controls.Add(this.lblEditId);
            this.Controls.Add(this.lblEditText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditStudent";
            this.Text = "Ažuriraj studenta";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditText;
        private System.Windows.Forms.Label lblEditId;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.Label lblEditOIB;
        private System.Windows.Forms.Label lblEditCourse;
        private System.Windows.Forms.Label lblEditYear;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxId;
        public System.Windows.Forms.TextBox textBoxFirstName;
        public System.Windows.Forms.TextBox textBoxLastName;
        public System.Windows.Forms.TextBox textBoxCourse;
        public System.Windows.Forms.TextBox textBoxOIB;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Label lblEditFirstName;
        public System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}