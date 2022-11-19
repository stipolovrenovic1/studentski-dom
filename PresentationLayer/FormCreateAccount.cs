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
    public partial class FormCreateAccount : Form
    {
        private UserRepository _userRepository = new UserRepository();

        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var lUsers = _userRepository.GetUsers();
            User newUser = new User();

            bool bUniqueData = true;          

            foreach(User user in lUsers)
            {
                if(textBoxUsername.Text == user.Username || textBoxEmail.Text == user.EmailAdress)
                {
                    bUniqueData = false;
                    break;
                }
            }

            if(bUniqueData = false)
            {
                MessageBox.Show("Korisničko ime ili email adresa vec postoje!");
            }
            else
            {
                if(textBoxFirstName.Text == null || textBoxLastName.Text == null || textBoxUsername.Text == null || textBoxPassword.Text == null || textBoxEmail == null)
                {
                    MessageBox.Show("Niste popunili sva polja!");
                }
                else
                {
                    newUser.FirstName = textBoxFirstName.Text;
                    newUser.LastName = textBoxLastName.Text;
                    newUser.Username = textBoxUsername.Text;
                    newUser.Password = textBoxPassword.Text;
                    newUser.EmailAdress = textBoxEmail.Text;

                    _userRepository.AddUser(newUser);

                    MessageBox.Show("Račun uspješno napravljen!");
                    this.Hide();
                }
            }
        }
    }
}
