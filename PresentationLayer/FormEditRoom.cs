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
    public partial class FormEditRoom : Form
    {
        private RoomRepository _roomRepository = new RoomRepository();

        private int nStudentNumber;
        private int nRoomNumber;

        public FormEditRoom(int nStudents, int nRoom)
        {
            InitializeComponent();

            nStudentNumber = nStudents;
            nRoomNumber = nRoom;
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            var rooms = _roomRepository.GetRooms();

            bool bExistingNumber = false;

            if(string.IsNullOrEmpty(textBoxNumber.Text) || string.IsNullOrEmpty(textBoxFloor.Text) || string.IsNullOrEmpty(textBoxMax.Text))
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
            else
            {
                if(Convert.ToInt32(textBoxMax.Text) < nStudentNumber)
                {
                    MessageBox.Show("Broj najviše mogućih studenata nemože biti manji od trenutnog broja studenata u sobi!");
                }
                else
                {
                    foreach(Room room in rooms)
                    {
                        if(Convert.ToInt32(textBoxNumber.Text) == room.RoomNumber && Convert.ToInt32(textBoxNumber.Text) != nRoomNumber)
                        {
                            bExistingNumber = true;
                            break;
                        }
                    }

                    if(bExistingNumber == true)
                    {
                        MessageBox.Show("Broj sobe ne smije već postojati!");
                    }
                    else
                    {
                        Room updatedRoom = new Room()
                        {
                            Id = Convert.ToInt32(textBoxId.Text),
                            RoomNumber = Convert.ToInt32(textBoxNumber.Text),
                            Floor = Convert.ToInt32(textBoxFloor.Text),
                            MaxStudents = Convert.ToInt32(textBoxMax.Text)
                        };

                        _roomRepository.EditRoom(updatedRoom);

                        MessageBox.Show("Soba uspješno ažurirana!");
                        this.Hide();
                    }
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
