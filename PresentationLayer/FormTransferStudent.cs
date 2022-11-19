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
    public partial class FormTransferStudent : Form
    {
        private StudentRepository _studentRepository = new StudentRepository();

        private BindingSource _tableBindingSource = new BindingSource();

        public FormTransferStudent(int Id)
        {
            InitializeComponent();

            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.DataSource = _tableBindingSource;

            _tableBindingSource.DataSource = _studentRepository.GetRoomStudents(Id);

            DataGridViewImageColumn oTransferButton = new DataGridViewImageColumn();
            oTransferButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/icontransfer.png");
            oTransferButton.Width = 20;
            oTransferButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewStudents.Columns.Add(oTransferButton);

        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudents.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                int nId = Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString());

                FormTransferStudentRooms formTransferStudentRooms = new FormTransferStudentRooms(nId);

                formTransferStudentRooms.ShowDialog();
                this.Hide();
            }
        }
    }
}
