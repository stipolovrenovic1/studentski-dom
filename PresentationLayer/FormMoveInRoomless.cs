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
    public partial class FormMoveInRoomless : Form
    {
        private RoomRepository _roomRepository = new RoomRepository();
        private StudentRepository _studentRepository = new StudentRepository();

        private BindingSource _tableBindingSource = new BindingSource();

        private int nId;

        public FormMoveInRoomless(int nStudentId)
        {
            InitializeComponent();

            dataGridViewFreeRooms.AutoGenerateColumns = false;
            dataGridViewFreeRooms.DataSource = _tableBindingSource;

            _tableBindingSource.DataSource = _roomRepository.GetAvailableRooms();

            DataGridViewImageColumn oMoveInButton = new DataGridViewImageColumn();
            oMoveInButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconmovein.png");
            oMoveInButton.Width = 20;
            oMoveInButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFreeRooms.Columns.Add(oMoveInButton);

            nId = nStudentId;
        }

        private void dataGridViewFreeRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFreeRooms.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                int nRoomId = (Convert.ToInt32(dataGridViewFreeRooms.Rows[e.RowIndex].Cells[0].Value.ToString()));

                var students = _studentRepository.GetRoomlessStudents();

                StudentRoomless movingStudent = students.Where(x => x.Id == nId).First();

                _studentRepository.MoveIntoRoom(movingStudent, nRoomId);
                MessageBox.Show("Student uspješno dodan u sobu!");

                this.Hide();
            }
        }
    }
}
