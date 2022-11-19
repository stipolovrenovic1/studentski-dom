namespace PresentationLayer
{
    partial class FormTransferStudentRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransferStudentRooms));
            this.dataGridViewFreeRooms = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTransferRoomText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeRooms)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFreeRooms
            // 
            this.dataGridViewFreeRooms.AllowUserToAddRows = false;
            this.dataGridViewFreeRooms.AllowUserToDeleteRows = false;
            this.dataGridViewFreeRooms.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewFreeRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFreeRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RoomNumber,
            this.Floor,
            this.StudentNumber});
            this.dataGridViewFreeRooms.Location = new System.Drawing.Point(780, 303);
            this.dataGridViewFreeRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewFreeRooms.Name = "dataGridViewFreeRooms";
            this.dataGridViewFreeRooms.ReadOnly = true;
            this.dataGridViewFreeRooms.RowTemplate.Height = 24;
            this.dataGridViewFreeRooms.Size = new System.Drawing.Size(605, 334);
            this.dataGridViewFreeRooms.TabIndex = 0;
            this.dataGridViewFreeRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFreeRooms_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // Floor
            // 
            this.Floor.DataPropertyName = "Floor";
            this.Floor.HeaderText = "Floor";
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            // 
            // StudentNumber
            // 
            this.StudentNumber.DataPropertyName = "StudentNumber";
            this.StudentNumber.HeaderText = "StudentNumber";
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.ReadOnly = true;
            // 
            // lblTransferRoomText
            // 
            this.lblTransferRoomText.AutoSize = true;
            this.lblTransferRoomText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTransferRoomText.Font = new System.Drawing.Font("Verdana", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblTransferRoomText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTransferRoomText.Location = new System.Drawing.Point(756, 136);
            this.lblTransferRoomText.Name = "lblTransferRoomText";
            this.lblTransferRoomText.Size = new System.Drawing.Size(651, 28);
            this.lblTransferRoomText.TabIndex = 1;
            this.lblTransferRoomText.Text = "Odaberite sobu u koju želite premjestiti studenta:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 865);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 169);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormTransferStudentRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1479, 816);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTransferRoomText);
            this.Controls.Add(this.dataGridViewFreeRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTransferStudentRooms";
            this.Text = "Slobodne sobe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeRooms)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFreeRooms;
        private System.Windows.Forms.Label lblTransferRoomText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
    }
}