namespace PresentationLayer
{
    partial class FormMoveInRoomless
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoveInRoomless));
            this.lblMoveInText = new System.Windows.Forms.Label();
            this.dataGridViewFreeRooms = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeRooms)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoveInText
            // 
            this.lblMoveInText.AutoSize = true;
            this.lblMoveInText.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.lblMoveInText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMoveInText.Location = new System.Drawing.Point(730, 120);
            this.lblMoveInText.Name = "lblMoveInText";
            this.lblMoveInText.Size = new System.Drawing.Size(618, 29);
            this.lblMoveInText.TabIndex = 0;
            this.lblMoveInText.Text = "Odaberite sobu u koju želite useliti studenta:";
            // 
            // dataGridViewFreeRooms
            // 
            this.dataGridViewFreeRooms.AllowUserToAddRows = false;
            this.dataGridViewFreeRooms.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewFreeRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFreeRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RoomNumber,
            this.Floor});
            this.dataGridViewFreeRooms.Location = new System.Drawing.Point(755, 263);
            this.dataGridViewFreeRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewFreeRooms.Name = "dataGridViewFreeRooms";
            this.dataGridViewFreeRooms.RowTemplate.Height = 24;
            this.dataGridViewFreeRooms.Size = new System.Drawing.Size(527, 334);
            this.dataGridViewFreeRooms.TabIndex = 1;
            this.dataGridViewFreeRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFreeRooms_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.Name = "RoomNumber";
            // 
            // Floor
            // 
            this.Floor.DataPropertyName = "Floor";
            this.Floor.HeaderText = "Floor";
            this.Floor.Name = "Floor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 727);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormMoveInRoomless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1398, 722);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewFreeRooms);
            this.Controls.Add(this.lblMoveInText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMoveInRoomless";
            this.Text = "Useli studenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeRooms)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoveInText;
        private System.Windows.Forms.DataGridView dataGridViewFreeRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}