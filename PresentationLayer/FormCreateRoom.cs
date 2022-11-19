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
    public partial class FormCreateRoom : Form
    {
        private RoomRepository _roomRepository = new RoomRepository();

        public FormCreateRoom()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxFloor.Text) || string.IsNullOrEmpty(textBoxNumber.Text) || string.IsNullOrEmpty(textBoxMaxStudents.Text))
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
            else
            {
               
                int nRoomNumber = Convert.ToInt32(textBoxNumber.Text);

                var rooms = _roomRepository.GetRooms();

                bool existingRoomNumber = false;
                
                foreach(Room room in rooms)
                {
                    if(nRoomNumber == room.RoomNumber)
                    {
                        existingRoomNumber = true;
                        break;
                    }
                }

                if(existingRoomNumber == true)
                {
                    MessageBox.Show("Već postoji soba s tim brojem!");
                }
                else
                {
                    Room newRoom = new Room();

                    newRoom.Floor = Convert.ToInt32(textBoxFloor.Text);
                    newRoom.RoomNumber = nRoomNumber;
                    newRoom.StudentNumber = 0;
                    newRoom.MaxStudents = Convert.ToInt32(textBoxMaxStudents.Text);

                    _roomRepository.CreateRoom(newRoom);
                    MessageBox.Show("Soba uspješno stvorena!");
                    this.Hide();
                }

            }
        }
    }
}
