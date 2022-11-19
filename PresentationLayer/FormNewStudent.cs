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
    public partial class FormNewStudent : Form
    {
        private StudentRepository _studentRepository = new StudentRepository();

        public FormNewStudent()
        {
            InitializeComponent();
        }

        private void buttonNewCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            bool bExistingOIB = false;
            var students = _studentRepository.GetStudents();
            var roomlessStudents = _studentRepository.GetRoomlessStudents();

            if (string.IsNullOrEmpty(textBoxNewFirstName.Text) || string.IsNullOrEmpty(textBoxNewLastName.Text) || string.IsNullOrEmpty(textBoxNewOIB.Text) || string.IsNullOrEmpty(textBoxNewCourse.Text))
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
            else
            {
                foreach (Student student in students)
                {
                    if (textBoxNewOIB.Text == student.OIB)
                    {
                        bExistingOIB = true;
                        break;
                    }
                }

                foreach (StudentRoomless studentRoomless in roomlessStudents)
                {
                    if (textBoxNewOIB.Text == studentRoomless.OIB)
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
                    StudentRoomless newStudent = new StudentRoomless()
                    {
                        FirstName = textBoxNewFirstName.Text,
                        LastName = textBoxNewLastName.Text,
                        OIB = textBoxNewOIB.Text,
                        Course = textBoxNewCourse.Text,
                        Year = Convert.ToInt32(numericUpDownNewYear.Value)
                    };

                    _studentRepository.NewStudent(newStudent);
                    MessageBox.Show("Student uspješno dodan!");
                    this.Hide();
                }
            }
        }
    }
}
