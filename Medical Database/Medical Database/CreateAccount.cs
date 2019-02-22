using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_Database
{
    public partial class CreateAccount : Form
    {
        /// initialize:
        public CreateAccount()
        {
            InitializeComponent();
        }
        
        /// username text box:
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string doctor_id = maskedTextBox1.Text;
        }

        /// password text box:
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// email text box:
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// first name text box:
        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// last name text box:
        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// phone number text box:
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        // create account button:
        private void button1_Click(object sender, EventArgs e)
        {
            string username = maskedTextBox1.Text;
            string password = maskedTextBox2.Text;
            string email = maskedTextBox3.Text;
            string first_name = maskedTextBox6.Text;
            string last_name = maskedTextBox5.Text;
            string phone_number = maskedTextBox4.Text;

            MD.User usr = new MD.User(username, password, first_name, last_name, email, phone_number);
            MD.User.users.Add(usr);

            // add new user to file:
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("users.txt", true))
            {
                string line = "\n" + username + "," + password + "," + first_name + "," + last_name + "," + email + "," + phone_number;
                file.WriteLine(line);
            }

            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox6.Clear();
            maskedTextBox5.Clear();
            maskedTextBox4.Clear();
        }
        
        // exit button:
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
