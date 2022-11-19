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
    public partial class FormStudentskiDom : Form
    {
        private RoomRepository _roomRepository = new RoomRepository();
        private StudentRepository _studentRepository = new StudentRepository();
        private UserRepository _userRepository = new UserRepository();

        private BindingSource _tableBindingSourceRooms = new BindingSource();
        private BindingSource _tableBindingSourceStudents = new BindingSource();
        private BindingSource _tableBindingSourceRoomless = new BindingSource();

        private string sUsername;


        public FormStudentskiDom(string username)
        {
            InitializeComponent();

            dataGridViewRooms.AutoGenerateColumns = false;
            dataGridViewRooms.DataSource = _tableBindingSourceRooms;

            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.DataSource = _tableBindingSourceStudents;

            dataGridViewRoomlessStudents.AutoGenerateColumns = false;
            dataGridViewRoomlessStudents.DataSource = _tableBindingSourceRoomless;

            _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
            _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
            _tableBindingSourceRoomless.DataSource = _studentRepository.GetRoomlessStudents();

            sUsername = username;

            this.ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.Show();

            DataGridViewImageColumn oViewButton = new DataGridViewImageColumn();
            oViewButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconview.png");
            oViewButton.Width = 20;
            oViewButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRooms.Columns.Add(oViewButton);
            dataGridViewRooms.Columns[5].Name = "ViewStudents";

            DataGridViewImageColumn oAddButton = new DataGridViewImageColumn();
            oAddButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconmovein.png");
            oAddButton.Width = 20;
            oAddButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRooms.Columns.Add(oAddButton);
            dataGridViewRooms.Columns[6].Name = "AddStudent";

            DataGridViewImageColumn oRemoveButton = new DataGridViewImageColumn();
            oRemoveButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconmoveout.png");
            oRemoveButton.Width = 20;
            oRemoveButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRooms.Columns.Add(oRemoveButton);
            dataGridViewRooms.Columns[7].Name = "RemoveStudent";         

            DataGridViewImageColumn oTransferButton = new DataGridViewImageColumn();
            oTransferButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/icontransfer.png");
            oTransferButton.Width = 20;
            oTransferButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRooms.Columns.Add(oTransferButton);
            dataGridViewRooms.Columns[8].Name = "TransferStudent";

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/icondelete.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRooms.Columns.Add(oDeleteButton);
            dataGridViewRooms.Columns[9].Name = "DeleteRoom";

            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();
            oEditButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconedit.png");
            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRooms.Columns.Add(oEditButton);
            dataGridViewRooms.Columns[10].Name = "EditRoom";

            DataGridViewImageColumn oTransferStudentButton = new DataGridViewImageColumn();
            oTransferStudentButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/icontransfer.png");
            oTransferStudentButton.Width = 20;
            oTransferStudentButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewStudents.Columns.Add(oTransferStudentButton);
            dataGridViewStudents.Columns[7].Name = "Transfer";

            DataGridViewImageColumn oRemoveRoomButton = new DataGridViewImageColumn();
            oRemoveRoomButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconmoveout.png");
            oRemoveRoomButton.Width = 20;
            oRemoveRoomButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewStudents.Columns.Add(oRemoveRoomButton);
            dataGridViewStudents.Columns[8].Name = "RemoveFromRoom";

            DataGridViewImageColumn oRemoveStudentButton = new DataGridViewImageColumn();
            oRemoveStudentButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/icondelete.png");
            oRemoveStudentButton.Width = 20;
            oRemoveStudentButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewStudents.Columns.Add(oRemoveStudentButton);
            dataGridViewStudents.Columns[9].Name = "Remove";

            DataGridViewImageColumn oEditStudentButton = new DataGridViewImageColumn();
            oEditStudentButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconedit.png");
            oEditStudentButton.Width = 20;
            oEditStudentButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewStudents.Columns.Add(oEditStudentButton);
            dataGridViewStudents.Columns[10].Name = "EditStudent";

            DataGridViewImageColumn oAddRoomButton = new DataGridViewImageColumn();
            oAddRoomButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconmovein.png");
            oAddRoomButton.Width = 20;
            oAddRoomButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRoomlessStudents.Columns.Add(oAddRoomButton);
            dataGridViewRoomlessStudents.Columns[6].Name = "MoveIn";

            DataGridViewImageColumn oRemoveRoomlessButton = new DataGridViewImageColumn();
            oRemoveRoomlessButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/icondelete.png");
            oRemoveRoomlessButton.Width = 20;
            oRemoveRoomlessButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRoomlessStudents.Columns.Add(oRemoveRoomlessButton);
            dataGridViewRoomlessStudents.Columns[7].Name = "Remove";

            DataGridViewImageColumn oEditRoomlessStudentButton = new DataGridViewImageColumn();
            oEditRoomlessStudentButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/iconedit.png");
            oEditRoomlessStudentButton.Width = 20;
            oEditRoomlessStudentButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRoomlessStudents.Columns.Add(oEditRoomlessStudentButton);
            dataGridViewRoomlessStudents.Columns[8].Name = "EditStudent";
        }

        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewRooms.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                int nId = Convert.ToInt32(dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString());

                var room = _roomRepository.GetRooms().Where(x => x.Id == nId).First();

                if(room.StudentNumber == 0)
                {
                    MessageBox.Show("Soba je prazna!");
                }
                else
                {
                    FormRoomStudents formRoomStudents = new FormRoomStudents(nId);

                    formRoomStudents.lblFloorValue.Text = dataGridViewRooms.Rows[e.RowIndex].Cells[2].Value.ToString();
                    formRoomStudents.lblNumberValue.Text = dataGridViewRooms.Rows[e.RowIndex].Cells[1].Value.ToString();

                    formRoomStudents.ShowDialog();
                }
            }

            if (dataGridViewRooms.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                int nId = Convert.ToInt32(dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString());

                var rooms = _roomRepository.GetRooms();

                var room = rooms.Where(x => x.Id == nId).First();

                if(room.StudentNumber < room.MaxStudents)
                {
                    if(_studentRepository.GetRoomlessStudents().Count > 0)
                    {
                        FormAddStudent formAddStudent = new FormAddStudent(nId);

                        formAddStudent.ShowDialog();

                        _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
                        _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
                        _tableBindingSourceRoomless.DataSource = _studentRepository.GetRoomlessStudents();
                    }
                    else
                    {
                        MessageBox.Show("Nema studenata koji nemaju sobu!");
                    }
                }
                else
                {
                    MessageBox.Show("Soba je puna!");
                }
            }

            if (dataGridViewRooms.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                int nId = Convert.ToInt32(dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString());

                var rooms = _roomRepository.GetRooms();

                var room = rooms.Where(x => x.Id == nId).First();

                if (room.StudentNumber > 0)
                {
                    FormRemoveStudent formRemoveStudent = new FormRemoveStudent(nId);
                
                    formRemoveStudent.ShowDialog();

                    _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
                    _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
                    _tableBindingSourceRoomless.DataSource = _studentRepository.GetRoomlessStudents();

                }
                else
                {
                    MessageBox.Show("Soba je prazna!");
                }
            }

            if (dataGridViewRooms.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                int nId = Convert.ToInt32(dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString());

                var rooms = _roomRepository.GetRooms();

                var room = rooms.Where(x => x.Id == nId).First();

                if (room.StudentNumber > 0)
                {
                    if(_roomRepository.GetAvailableRooms().Count > 0)
                    {
                        FormTransferStudent formTransferStudent = new FormTransferStudent(nId);

                        formTransferStudent.ShowDialog();

                        _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
                        _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
                        _tableBindingSourceRoomless.DataSource = _studentRepository.GetRoomlessStudents();
                    }
                    else
                    {
                        MessageBox.Show("Nema slobodnih soba za useljavanje!");
                    }
                }
                else
                {
                    MessageBox.Show("Soba je prazna!");
                }
            }

            if (dataGridViewRooms.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
            {
                int nId = Convert.ToInt32(dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString());

                var rooms = _roomRepository.GetRooms();

                var room = rooms.Where(x => x.Id == nId).First();

                _studentRepository.MoveOutRoomStudents(room.Id);
                _roomRepository.DeleteRoom(room);

                _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
                _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
                _tableBindingSourceRoomless.DataSource = _studentRepository.GetRoomlessStudents();

                MessageBox.Show("Soba uspješno izbrisana!");
            }

            if (dataGridViewRooms.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
            {
                int nRoomStudents = Convert.ToInt32(dataGridViewRooms.Rows[e.RowIndex].Cells[3].Value.ToString());
                int nRoomNumber = Convert.ToInt32(dataGridViewRooms.Rows[e.RowIndex].Cells[1].Value.ToString());

                var rooms = _roomRepository.GetRooms();

                int nMaxStudents = rooms.Where(x => x.Id == Convert.ToInt32(dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString())).Select(x => x.MaxStudents).First();

                FormEditRoom formEditRoom = new FormEditRoom(nRoomStudents, nRoomNumber);

                formEditRoom.textBoxId.Text = dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                formEditRoom.textBoxNumber.Text = dataGridViewRooms.Rows[e.RowIndex].Cells[1].Value.ToString();
                formEditRoom.textBoxFloor.Text = dataGridViewRooms.Rows[e.RowIndex].Cells[2].Value.ToString();
                formEditRoom.textBoxMax.Text = nMaxStudents.ToString();

                formEditRoom.ShowDialog();

                _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();

            }
        }

        private void obrišiRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteAccount formDeleteAccount = new FormDeleteAccount(sUsername);
            formDeleteAccount.ShowDialog();
            this.Hide();
        }  

        private void obrišiRačunToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDeleteAccount formDeleteAccount = new FormDeleteAccount(sUsername);
            formDeleteAccount.ShowDialog();
            this.Hide();
        }

        private void tabPageRoomlessStudents_Click(object sender, EventArgs e)
        {

        }


        private void oProgramuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Me \n Version 1.0 \n Author Me \n Year 2019 ");
        }

        private void izlazToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void izbrišiRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var users = _userRepository.GetUsers();
            for(int i = 0; i < users.Count(); i++)
            {
                if(sUsername == users[i].Username)
                {
                    users.RemoveAt(i);
                    break;
                }
            }

            if(users.Count() == 0)
            {
                MessageBox.Show("Ne postoje računi za brisanje!");
            }
            else
            {
                FormDeleteAccount formDeleteAccount = new FormDeleteAccount(sUsername);
                formDeleteAccount.ShowDialog();
            }          
        }

        private void noviRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateAccount formCreateAccount = new FormCreateAccount();
            formCreateAccount.ShowDialog();
        }

        private void izlazToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
            _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
            _tableBindingSourceRoomless.DataSource = _studentRepository.GetRoomlessStudents();
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudents.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if(_roomRepository.GetAvailableRooms().Count() > 0)
                {
                    int nStudentId = (Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString()));

                    FormTransferStudentRooms formTransferStudentRooms = new FormTransferStudentRooms(nStudentId);
                    formTransferStudentRooms.ShowDialog();

                    _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
                    _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
                }
                else
                {
                    MessageBox.Show("Nema slobodnih soba za useljavanje!");
                }
            }

            if (dataGridViewStudents.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                int nStudentId = (Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString()));

                var students = _studentRepository.GetStudents();
                var leavingStudent = students.Where(x => x.Id == nStudentId).First();

                _studentRepository.MoveOut(leavingStudent, leavingStudent.RoomId);
                MessageBox.Show("Student uspješno iseljen iz sobe!");

                _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
                _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
                _tableBindingSourceRoomless.DataSource = _studentRepository.GetRoomlessStudents();

            }

            if (dataGridViewStudents.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
            {
                int nStudentId = (Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString()));

                var students = _studentRepository.GetStudents();
                var deletedStudent = students.Where(x => x.Id == nStudentId).First();

                _studentRepository.DeleteStudent(deletedStudent);
                MessageBox.Show("Student uspješno izbrisan iz baze!");

                _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
                _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
            }

            if (dataGridViewStudents.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
            {
                string sOIB = dataGridViewStudents.Rows[e.RowIndex].Cells[3].Value.ToString();

                FormEditStudent formEditStudent = new FormEditStudent(sOIB);

                formEditStudent.textBoxId.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                formEditStudent.textBoxFirstName.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
                formEditStudent.textBoxLastName.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
                formEditStudent.textBoxOIB.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[3].Value.ToString();
                formEditStudent.textBoxCourse.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[4].Value.ToString();              

                formEditStudent.ShowDialog();

                _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
            }
        }

        private void dataGridViewRoomlessStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRoomlessStudents.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if(_roomRepository.GetAvailableRooms().Count > 0)
                {
                    int nStudentId = (Convert.ToInt32(dataGridViewRoomlessStudents.Rows[e.RowIndex].Cells[0].Value.ToString()));

                    FormMoveInRoomless formMoveInRoomless = new FormMoveInRoomless(nStudentId);

                    formMoveInRoomless.ShowDialog();

                    _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
                    _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
                    _tableBindingSourceRoomless.DataSource = _studentRepository.GetRoomlessStudents();
                }
                else
                {
                    MessageBox.Show("Nema slobodnih soba!");
                }
            }

            if (dataGridViewRoomlessStudents.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                int nStudentId = (Convert.ToInt32(dataGridViewRoomlessStudents.Rows[e.RowIndex].Cells[0].Value.ToString()));

                var roomlessStudents = _studentRepository.GetRoomlessStudents();
                var deletedStudent = roomlessStudents.Where(x => x.Id == nStudentId).First();

                _studentRepository.DeleteRoomlessStudent(deletedStudent);
                MessageBox.Show("Student uspješno izbrisan iz baze!");

                _tableBindingSourceRoomless.DataSource = _studentRepository.GetRoomlessStudents();
            }

            if (dataGridViewRoomlessStudents.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                string sOIB = dataGridViewRoomlessStudents.Rows[e.RowIndex].Cells[3].Value.ToString();

                FormEditRoomlessStudent formEditRoomlessStudent = new FormEditRoomlessStudent(sOIB);

                formEditRoomlessStudent.textBoxId.Text = dataGridViewRoomlessStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                formEditRoomlessStudent.textBoxFirstName.Text = dataGridViewRoomlessStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
                formEditRoomlessStudent.textBoxLastName.Text = dataGridViewRoomlessStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
                formEditRoomlessStudent.textBoxOIB.Text = dataGridViewRoomlessStudents.Rows[e.RowIndex].Cells[3].Value.ToString();
                formEditRoomlessStudent.textBoxCourse.Text = dataGridViewRoomlessStudents.Rows[e.RowIndex].Cells[4].Value.ToString();
   

                formEditRoomlessStudent.ShowDialog();

                _tableBindingSourceStudents.DataSource = _studentRepository.GetStudents();
            }
        }

        private void novaSobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateRoom formCreateRoom = new FormCreateRoom();
            formCreateRoom.ShowDialog();

            _tableBindingSourceRooms.DataSource = _roomRepository.GetRooms();
        }

        private void noviStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewStudent formNewStudent = new FormNewStudent();
            formNewStudent.ShowDialog();

            _tableBindingSourceRoomless.DataSource = _studentRepository.GetRoomlessStudents();
        }

        private void izlazToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
