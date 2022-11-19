namespace PresentationLayer
{
    partial class FormStudentskiDom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentskiDom));
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlStudentskiDom = new System.Windows.Forms.TabControl();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageRoomlessStudents = new System.Windows.Forms.TabPage();
            this.dataGridViewRoomlessStudents = new System.Windows.Forms.DataGridView();
            this.RoomlessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomlessFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomlessLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomlessOIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomlessCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomlessYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrišiRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novaSobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.tabControlStudentskiDom.SuspendLayout();
            this.tabPageRooms.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabPageRoomlessStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomlessStudents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RoomNumber,
            this.Floor,
            this.StudentNumber,
            this.MaxStudents});
            resources.ApplyResources(this.dataGridViewRooms, "dataGridViewRooms");
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowTemplate.Height = 24;
            this.dataGridViewRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            resources.ApplyResources(this.RoomNumber, "RoomNumber");
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // Floor
            // 
            this.Floor.DataPropertyName = "Floor";
            resources.ApplyResources(this.Floor, "Floor");
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            // 
            // StudentNumber
            // 
            this.StudentNumber.DataPropertyName = "StudentNumber";
            resources.ApplyResources(this.StudentNumber, "StudentNumber");
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.ReadOnly = true;
            // 
            // MaxStudents
            // 
            this.MaxStudents.DataPropertyName = "MaxStudents";
            resources.ApplyResources(this.MaxStudents, "MaxStudents");
            this.MaxStudents.Name = "MaxStudents";
            this.MaxStudents.ReadOnly = true;
            // 
            // tabControlStudentskiDom
            // 
            this.tabControlStudentskiDom.Controls.Add(this.tabPageRooms);
            this.tabControlStudentskiDom.Controls.Add(this.tabPageStudents);
            this.tabControlStudentskiDom.Controls.Add(this.tabPageRoomlessStudents);
            resources.ApplyResources(this.tabControlStudentskiDom, "tabControlStudentskiDom");
            this.tabControlStudentskiDom.Name = "tabControlStudentskiDom";
            this.tabControlStudentskiDom.SelectedIndex = 0;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.dataGridViewRooms);
            resources.ApplyResources(this.tabPageRooms, "tabPageRooms");
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            resources.ApplyResources(this.tabPageStudents, "tabPageStudents");
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.FirstName,
            this.LastName,
            this.OIB,
            this.Course,
            this.Year,
            this.RoomId});
            resources.ApplyResources(this.dataGridViewStudents, "dataGridViewStudents");
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "Id";
            resources.ApplyResources(this.StudentId, "StudentId");
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            resources.ApplyResources(this.FirstName, "FirstName");
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            resources.ApplyResources(this.LastName, "LastName");
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // OIB
            // 
            this.OIB.DataPropertyName = "OIB";
            resources.ApplyResources(this.OIB, "OIB");
            this.OIB.Name = "OIB";
            this.OIB.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            resources.ApplyResources(this.Course, "Course");
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            resources.ApplyResources(this.Year, "Year");
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            resources.ApplyResources(this.RoomId, "RoomId");
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            // 
            // tabPageRoomlessStudents
            // 
            this.tabPageRoomlessStudents.Controls.Add(this.dataGridViewRoomlessStudents);
            resources.ApplyResources(this.tabPageRoomlessStudents, "tabPageRoomlessStudents");
            this.tabPageRoomlessStudents.Name = "tabPageRoomlessStudents";
            this.tabPageRoomlessStudents.UseVisualStyleBackColor = true;
            this.tabPageRoomlessStudents.Click += new System.EventHandler(this.tabPageRoomlessStudents_Click);
            // 
            // dataGridViewRoomlessStudents
            // 
            this.dataGridViewRoomlessStudents.AllowUserToAddRows = false;
            this.dataGridViewRoomlessStudents.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewRoomlessStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomlessStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomlessId,
            this.RoomlessFirstName,
            this.RoomlessLastName,
            this.RoomlessOIB,
            this.RoomlessCourse,
            this.RoomlessYear});
            resources.ApplyResources(this.dataGridViewRoomlessStudents, "dataGridViewRoomlessStudents");
            this.dataGridViewRoomlessStudents.Name = "dataGridViewRoomlessStudents";
            this.dataGridViewRoomlessStudents.RowTemplate.Height = 24;
            this.dataGridViewRoomlessStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoomlessStudents_CellContentClick);
            // 
            // RoomlessId
            // 
            this.RoomlessId.DataPropertyName = "Id";
            resources.ApplyResources(this.RoomlessId, "RoomlessId");
            this.RoomlessId.Name = "RoomlessId";
            // 
            // RoomlessFirstName
            // 
            this.RoomlessFirstName.DataPropertyName = "FirstName";
            resources.ApplyResources(this.RoomlessFirstName, "RoomlessFirstName");
            this.RoomlessFirstName.Name = "RoomlessFirstName";
            // 
            // RoomlessLastName
            // 
            this.RoomlessLastName.DataPropertyName = "LastName";
            resources.ApplyResources(this.RoomlessLastName, "RoomlessLastName");
            this.RoomlessLastName.Name = "RoomlessLastName";
            // 
            // RoomlessOIB
            // 
            this.RoomlessOIB.DataPropertyName = "OIB";
            resources.ApplyResources(this.RoomlessOIB, "RoomlessOIB");
            this.RoomlessOIB.Name = "RoomlessOIB";
            // 
            // RoomlessCourse
            // 
            this.RoomlessCourse.DataPropertyName = "Course";
            resources.ApplyResources(this.RoomlessCourse, "RoomlessCourse");
            this.RoomlessCourse.Name = "RoomlessCourse";
            // 
            // RoomlessYear
            // 
            this.RoomlessYear.DataPropertyName = "Year";
            resources.ApplyResources(this.RoomlessYear, "RoomlessYear");
            this.RoomlessYear.Name = "RoomlessYear";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem,
            this.oProgramuToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviRačunToolStripMenuItem,
            this.izbrišiRačunToolStripMenuItem,
            this.izlazToolStripMenuItem});
            resources.ApplyResources(this.izbornikToolStripMenuItem, "izbornikToolStripMenuItem");
            this.izbornikToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            // 
            // noviRačunToolStripMenuItem
            // 
            this.noviRačunToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.noviRačunToolStripMenuItem.Name = "noviRačunToolStripMenuItem";
            resources.ApplyResources(this.noviRačunToolStripMenuItem, "noviRačunToolStripMenuItem");
            this.noviRačunToolStripMenuItem.Click += new System.EventHandler(this.noviRačunToolStripMenuItem_Click);
            // 
            // izbrišiRačunToolStripMenuItem
            // 
            this.izbrišiRačunToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.izbrišiRačunToolStripMenuItem.Name = "izbrišiRačunToolStripMenuItem";
            resources.ApplyResources(this.izbrišiRačunToolStripMenuItem, "izbrišiRačunToolStripMenuItem");
            this.izbrišiRačunToolStripMenuItem.Click += new System.EventHandler(this.izbrišiRačunToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            resources.ApplyResources(this.izlazToolStripMenuItem, "izlazToolStripMenuItem");
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click_1);
            // 
            // oProgramuToolStripMenuItem
            // 
            resources.ApplyResources(this.oProgramuToolStripMenuItem, "oProgramuToolStripMenuItem");
            this.oProgramuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaSobaToolStripMenuItem,
            this.noviStudentToolStripMenuItem,
            this.izlazToolStripMenuItem1,
            this.izlazToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // novaSobaToolStripMenuItem
            // 
            resources.ApplyResources(this.novaSobaToolStripMenuItem, "novaSobaToolStripMenuItem");
            this.novaSobaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.novaSobaToolStripMenuItem.Name = "novaSobaToolStripMenuItem";
            this.novaSobaToolStripMenuItem.Click += new System.EventHandler(this.novaSobaToolStripMenuItem_Click);
            // 
            // noviStudentToolStripMenuItem
            // 
            resources.ApplyResources(this.noviStudentToolStripMenuItem, "noviStudentToolStripMenuItem");
            this.noviStudentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.noviStudentToolStripMenuItem.Name = "noviStudentToolStripMenuItem";
            this.noviStudentToolStripMenuItem.Click += new System.EventHandler(this.noviStudentToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem1
            // 
            resources.ApplyResources(this.izlazToolStripMenuItem1, "izlazToolStripMenuItem1");
            this.izlazToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.izlazToolStripMenuItem1.Name = "izlazToolStripMenuItem1";
            this.izlazToolStripMenuItem1.Click += new System.EventHandler(this.izlazToolStripMenuItem1_Click_1);
            // 
            // izlazToolStripMenuItem2
            // 
            resources.ApplyResources(this.izlazToolStripMenuItem2, "izlazToolStripMenuItem2");
            this.izlazToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.izlazToolStripMenuItem2.Name = "izlazToolStripMenuItem2";
            this.izlazToolStripMenuItem2.Click += new System.EventHandler(this.izlazToolStripMenuItem2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tabControlStudentskiDom);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FormStudentskiDom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStudentskiDom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.tabControlStudentskiDom.ResumeLayout(false);
            this.tabPageRooms.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabPageRoomlessStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomlessStudents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.TabControl tabControlStudentskiDom;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.TabPage tabPageRoomlessStudents;
        private System.Windows.Forms.DataGridView dataGridViewRoomlessStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomlessId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomlessFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomlessLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomlessOIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomlessCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomlessYear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbrišiRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaSobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxStudents;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

