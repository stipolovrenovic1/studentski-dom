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
    public partial class FormTransferStudentRooms : Form
    {
        private RoomRepository _roomRepository = new RoomRepository();
        private StudentRepository _studentRepository = new StudentRepository();

        private BindingSource _tableBindingSource = new BindingSource();

        private int nStudentId;

        public FormTransferStudentRooms(int id)
        {
            InitializeComponent();

            dataGridViewFreeRooms.AutoGenerateColumns = false;
            dataGridViewFreeRooms.DataSource = _tableBindingSource;

            var student = _studentRepository.GetStudents().Where(x => x.Id == id).First();

            var availableRooms = _roomRepository.GetAvailableRooms();

            for(int i = 0; i < availableRooms.Count(); i++)
            {
                if(student.RoomId == availableRooms[i].Id)
                {
                    availableRooms.RemoveAt(i);
                    break;
                }
            }

            _tableBindingSource.DataSource = availableRooms;

            DataGridViewImageColumn oAddButton = new DataGridViewImageColumn();
            oAddButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconmovein.png");
            oAddButton.Width = 20;
            oAddButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFreeRooms.Columns.Add(oAddButton);

            nStudentId = id;
        }

        private void dataGridViewFreeRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFreeRooms.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                int nRoomId = (Convert.ToInt32(dataGridViewFreeRooms.Rows[e.RowIndex].Cells[0].Value.ToString()));

                var students = _studentRepository.GetStudents();

                Student transferingStudent = students.Where(x => x.Id == nStudentId).First();

                _studentRepository.Transfer(transferingStudent, nRoomId);

                MessageBox.Show("Student uspješno premješten!");

                this.Hide();
            }
        }
    }
}
