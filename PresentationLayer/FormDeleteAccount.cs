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
    public partial class FormDeleteAccount : Form
    {
        private UserRepository _userRepository = new UserRepository();

        private BindingSource _tableBindingSource = new BindingSource();

        private List<User> usersException = new List<User>();

        public FormDeleteAccount(string username)
        {
            InitializeComponent();

            dataGridViewUsers.AutoGenerateColumns = false;
            dataGridViewUsers.DataSource = _tableBindingSource;

            usersException = _userRepository.GetUsers();
            for(int i = 0; i < usersException.Count(); i++)
            {
                if(username == usersException[i].Username)
                {
                    usersException.RemoveAt(i);
                    break;
                }
            }

            _tableBindingSource.DataSource = usersException;

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("E:/Faks/PNO-KV/StudentskiDomSustav/icondelete.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewUsers.Columns.Add(oDeleteButton);

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                int nUserId = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString());

                var deletedUser = usersException.Where(x => x.Id == nUserId).First();

                _userRepository.DeleteUser(deletedUser);
                MessageBox.Show("Korisnik uspješno izbrisan!");

                this.Hide();
            }
        }
    }
}
