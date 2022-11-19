using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class FormRemoveStudent : Form
    {
        private StudentRepository _studentRepository = new StudentRepository();
        private RoomRepository _roomRepository = new RoomRepository();

        private BindingSource _tableBindingSource = new BindingSource();

        private int nRoomId;

        public FormRemoveStudent(int Id)
        {
            InitializeComponent();

            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.DataSource = _tableBindingSource;

            _tableBindingSource.DataSource = _studentRepository.GetRoomStudents(Id);

            DataGridViewImageColumn oRemoveButton = new DataGridViewImageColumn();
            oRemoveButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconmoveout.png");
            oRemoveButton.Width = 20;
            oRemoveButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewStudents.Columns.Add(oRemoveButton);

            nRoomId = Id;
        }      

        private void dataGridViewStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudents.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                int nStudentId = (Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString()));

                var students = _studentRepository.GetRoomStudents(nRoomId);
                var leavingStudent = students.Where(x => x.Id == nStudentId).First();

                _studentRepository.MoveOut(leavingStudent, leavingStudent.RoomId);
                MessageBox.Show("Student uspješno izbrisan iz sobe!");

                this.Hide();
            }
        }
    }
}
