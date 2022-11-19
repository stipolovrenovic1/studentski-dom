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
    public partial class FormAddStudent : Form
    {
        private StudentRepository _studentRepository = new StudentRepository();
        private RoomRepository _roomRepository = new RoomRepository();

        private BindingSource _tableBindingSource = new BindingSource();

        private int roomId;

        public FormAddStudent(int nRoomId)
        {
            InitializeComponent();

            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.DataSource = _tableBindingSource;

            _tableBindingSource.DataSource = _studentRepository.GetRoomlessStudents(); 

            DataGridViewImageColumn oAddButton = new DataGridViewImageColumn();
            oAddButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconmovein.png");
            oAddButton.Width = 20;
            oAddButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewStudents.Columns.Add(oAddButton);

            roomId = nRoomId;
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudents.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                int nStudentId = (Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString()));

                var roomlessStudents = _studentRepository.GetRoomlessStudents();
                var movingStudent = roomlessStudents.Where(x => x.Id == nStudentId).First();

                _studentRepository.MoveIntoRoom(movingStudent, roomId);
                MessageBox.Show("Student uspješno dodan u sobu!");

                this.Hide();
            }
        }
    }
}
