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
    public partial class FormLogin : Form
    {
        private UserRepository _userRepository = new UserRepository();

        public FormLogin()
        {
            InitializeComponent();          
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            bool bLogin = false;
            var lUsers = _userRepository.GetUsers();

            if(string.IsNullOrEmpty(textBoxLoginUsername.Text) || string.IsNullOrEmpty(textBoxLoginPassword.Text))
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
            else
            {
                foreach (User user in lUsers)
                {
                    if (textBoxLoginUsername.Text == user.Username && textBoxLoginPassword.Text == user.Password)
                    {
                        MessageBox.Show("Prijava uspješna!");

                        FormStudentskiDom formStudentskiDom = new FormStudentskiDom(user.Username);
                        formStudentskiDom.Show();

                        bLogin = true;

                        this.Hide();
                        break;
                    }               
                }

                if (bLogin == false)
                {
                    MessageBox.Show("Neispravni korisnički podatci!");
                }
            }
        } 
    }
}
