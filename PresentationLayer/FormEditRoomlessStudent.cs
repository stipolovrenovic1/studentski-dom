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
    public partial class FormEditRoomlessStudent : Form
    {
        private StudentRepository _studentRepository = new StudentRepository();

        private string sOIB;

        public FormEditRoomlessStudent(string OIB)
        {
            InitializeComponent();

            sOIB = OIB;
        }

        private void buttonEditCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            bool bExistingOIB = false;
            var students = _studentRepository.GetStudents();
            var roomlessStudents = _studentRepository.GetRoomlessStudents();

            if (string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text) || string.IsNullOrEmpty(textBoxOIB.Text) || string.IsNullOrEmpty(textBoxCourse.Text))
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
            else
            {
                foreach (Student student in students)
                {
                    if (textBoxOIB.Text == student.OIB)
                    {
                        bExistingOIB = true;
                        break;
                    }
                }

                foreach (StudentRoomless studentRoomless in roomlessStudents)
                {
                    if (textBoxOIB.Text == studentRoomless.OIB && textBoxOIB.Text != sOIB)
                    {
                        bExistingOIB = true;
                        break;
                    }
                }

                if (bExistingOIB == true)
                {
                    MessageBox.Show("Već postoji student s tim OIB-om!");
                }
                else
                {
                    StudentRoomless updatedStudent = new StudentRoomless()
                    {
                        Id = Convert.ToInt32(textBoxId.Text),
                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text,
                        OIB = textBoxOIB.Text,
                        Course = textBoxCourse.Text,
                        Year = Convert.ToInt32(numericUpDownYear.Value)
                    };

                    _studentRepository.EditRoomlessStudent(updatedStudent);
                    MessageBox.Show("Student uspješno ažuriran!");
                    this.Hide();
                }
            }
        }
    }
}
