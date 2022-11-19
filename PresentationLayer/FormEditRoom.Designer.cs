namespace PresentationLayer
{
    partial class FormEditRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditRoom));
            this.lblEditText = new System.Windows.Forms.Label();
            this.lblEditNumber = new System.Windows.Forms.Label();
            this.lblEditFloor = new System.Windows.Forms.Label();
            this.lblEditMax = new System.Windows.Forms.Label();
            this.lblEditId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditText
            // 
            this.lblEditText.AutoSize = true;
            this.lblEditText.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.lblEditText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEditText.Location = new System.Drawing.Point(742, 98);
            this.lblEditText.Name = "lblEditText";
            this.lblEditText.Size = new System.Drawing.Size(467, 41);
            this.lblEditText.TabIndex = 0;
            this.lblEditText.Text = "Uredite podatke o sobi:";
            // 
            // lblEditNumber
            // 
            this.lblEditNumber.AutoSize = true;
            this.lblEditNumber.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEditNumber.Location = new System.Drawing.Point(874, 253);
            this.lblEditNumber.Name = "lblEditNumber";
            this.lblEditNumber.Size = new System.Drawing.Size(90, 20);
            this.lblEditNumber.TabIndex = 1;
            this.lblEditNumber.Text = "Broj sobe";
            // 
            // lblEditFloor
            // 
            this.lblEditFloor.AutoSize = true;
            this.lblEditFloor.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEditFloor.Location = new System.Drawing.Point(926, 314);
            this.lblEditFloor.Name = "lblEditFloor";
            this.lblEditFloor.Size = new System.Drawing.Size(38, 20);
            this.lblEditFloor.TabIndex = 2;
            this.lblEditFloor.Text = "Kat";
            // 
            // lblEditMax
            // 
            this.lblEditMax.AutoSize = true;
            this.lblEditMax.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEditMax.Location = new System.Drawing.Point(720, 372);
            this.lblEditMax.Name = "lblEditMax";
            this.lblEditMax.Size = new System.Drawing.Size(244, 20);
            this.lblEditMax.TabIndex = 3;
            this.lblEditMax.Text = "Najviše mogućih studenata";
            // 
            // lblEditId
            // 
            this.lblEditId.AutoSize = true;
            this.lblEditId.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEditId.Location = new System.Drawing.Point(888, 195);
            this.lblEditId.Name = "lblEditId";
            this.lblEditId.Size = new System.Drawing.Size(76, 20);
            this.lblEditId.TabIndex = 4;
            this.lblEditId.Text = "ID sobe";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(1002, 196);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(177, 22);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(1002, 254);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(177, 22);
            this.textBoxNumber.TabIndex = 6;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(1002, 315);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(177, 22);
            this.textBoxFloor.TabIndex = 7;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(1002, 373);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(177, 22);
            this.textBoxMax.TabIndex = 8;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCancel.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btnEditCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditCancel.Location = new System.Drawing.Point(671, 504);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(244, 80);
            this.btnEditCancel.TabIndex = 9;
            this.btnEditCancel.Text = "Odustani";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRoom.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.buttonEditRoom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEditRoom.Location = new System.Drawing.Point(986, 504);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(244, 80);
            this.buttonEditRoom.TabIndex = 10;
            this.buttonEditRoom.Text = "Potvrdi";
            this.buttonEditRoom.UseVisualStyleBackColor = false;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 681);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormEditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1292, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEditRoom);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.lblEditId);
            this.Controls.Add(this.lblEditMax);
            this.Controls.Add(this.lblEditFloor);
            this.Controls.Add(this.lblEditNumber);
            this.Controls.Add(this.lblEditText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditRoom";
            this.Text = "Ažuriraj sobu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditText;
        private System.Windows.Forms.Label lblEditNumber;
        private System.Windows.Forms.Label lblEditFloor;
        private System.Windows.Forms.Label lblEditMax;
        private System.Windows.Forms.Label lblEditId;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button buttonEditRoom;
        public System.Windows.Forms.TextBox textBoxId;
        public System.Windows.Forms.TextBox textBoxNumber;
        public System.Windows.Forms.TextBox textBoxFloor;
        public System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}