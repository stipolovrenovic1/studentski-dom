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
    public partial class FormEditStudent : Form
    {
        private StudentRepository _studentRepository = new StudentRepository();

        private string sOIB;

        public FormEditStudent(string OIB)
        {
            InitializeComponent();

            sOIB = OIB;
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            bool bExistingOIB = false;
            var students = _studentRepository.GetStudents();
            var roomlessStudents = _studentRepository.GetRoomlessStudents();

            if(string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text) || string.IsNullOrEmpty(textBoxOIB.Text) || string.IsNullOrEmpty(textBoxCourse.Text))
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
            else
            {
                foreach(Student student in students)
                {
                    if(textBoxOIB.Text == student.OIB && textBoxOIB.Text != sOIB)
                    {
                        bExistingOIB = true;
                        break;
                    }
                }

                foreach(StudentRoomless studentRoomless in roomlessStudents)
                {
                    if(textBoxOIB.Text == studentRoomless.OIB)
                    {
                        bExistingOIB = true;
                        break;
                    }
                }

                if(bExistingOIB == true)
                {
                    MessageBox.Show("Već postoji student s tim OIB-om!");
                }
                else
                {
                    Student updatedStudent = new Student()
                    {
                        Id = Convert.ToInt32(textBoxId.Text),
                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text,
                        OIB = textBoxOIB.Text,
                        Course = textBoxCourse.Text,
                        Year = Convert.ToInt32(numericUpDownYear.Value)
                    };

                    _studentRepository.EditStudent(updatedStudent);
                    MessageBox.Show("Student uspješno ažuriran!");
                    this.Hide();
                }
            }
        }
    }
}
