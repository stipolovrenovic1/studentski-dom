namespace PresentationLayer
{
    partial class FormCreateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateRoom));
            this.lblCreateRoomText = new System.Windows.Forms.Label();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxMaxStudents = new System.Windows.Forms.TextBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblMaxStudents = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateRoomText
            // 
            this.lblCreateRoomText.AutoSize = true;
            this.lblCreateRoomText.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.lblCreateRoomText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCreateRoomText.Location = new System.Drawing.Point(651, 78);
            this.lblCreateRoomText.Name = "lblCreateRoomText";
            this.lblCreateRoomText.Size = new System.Drawing.Size(607, 41);
            this.lblCreateRoomText.TabIndex = 0;
            this.lblCreateRoomText.Text = "Unesite podatke za novu sobu:";
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(959, 214);
            this.textBoxFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(215, 22);
            this.textBoxFloor.TabIndex = 1;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(959, 286);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(215, 22);
            this.textBoxNumber.TabIndex = 2;
            // 
            // textBoxMaxStudents
            // 
            this.textBoxMaxStudents.Location = new System.Drawing.Point(959, 354);
            this.textBoxMaxStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaxStudents.Name = "textBoxMaxStudents";
            this.textBoxMaxStudents.Size = new System.Drawing.Size(215, 22);
            this.textBoxMaxStudents.TabIndex = 3;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblFloor.Location = new System.Drawing.Point(891, 214);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(38, 20);
            this.lblFloor.TabIndex = 4;
            this.lblFloor.Text = "Kat";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblNumber.Location = new System.Drawing.Point(839, 286);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(90, 20);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Broj sobe";
            // 
            // lblMaxStudents
            // 
            this.lblMaxStudents.AutoSize = true;
            this.lblMaxStudents.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblMaxStudents.Location = new System.Drawing.Point(691, 353);
            this.lblMaxStudents.Name = "lblMaxStudents";
            this.lblMaxStudents.Size = new System.Drawing.Size(238, 20);
            this.lblMaxStudents.TabIndex = 6;
            this.lblMaxStudents.Text = "Najviše moguće studenata";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Location = new System.Drawing.Point(672, 510);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(235, 79);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRoom.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btnCreateRoom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreateRoom.Location = new System.Drawing.Point(1015, 510);
            this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(235, 79);
            this.btnCreateRoom.TabIndex = 8;
            this.btnCreateRoom.Text = "Potvrdi";
            this.btnCreateRoom.UseVisualStyleBackColor = false;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 705);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormCreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1307, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMaxStudents);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.textBoxMaxStudents);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.lblCreateRoomText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCreateRoom";
            this.Text = "Nova soba";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateRoomText;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxMaxStudents;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblMaxStudents;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}