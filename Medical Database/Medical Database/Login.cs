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
    public partial class Login : Form
    {
        // initialize/load users:
        public Login()
        {
            InitializeComponent();

            // load users:
            string[] lines = File.ReadAllLines("users.txt");
            foreach (string line in lines)
            {
                string[] col = line.Split(new char[] {','});
                MD.User usr = new MD.User(col[0], col[1], col[2], col[3], col[4], col[5]);
                MD.User.users.Add(usr);
            }
        }

        /// more initializing:
        private void Login_Load(object sender, EventArgs e)
        {
        
        }

        /// logo image:
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// login group box:
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// staff portal label:
        private void label5_Click(object sender, EventArgs e)
        {

        }

        /// username label:
        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        /// password label:
        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        /// welcome label:
        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        /// username textbox:
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        /// password textbox:
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        // create an account link:
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount ca = new Medical_Database.CreateAccount();
            ca.ShowDialog();
        }

        // login button:
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            foreach (var data in MD.User.users)
            {
                if (username == data.username && password == data.password)
                {
                    this.Hide();
                    Menu m = new Medical_Database.Menu();
                    m.ShowDialog();
                    this.Close();
                }
            }

            // REMOVE THIS LATER (easy login for debugging):
            if (username == "" && password == "")
            {
                this.Hide();
                Menu m = new Medical_Database.Menu();
                m.ShowDialog();
                this.Close();
            }

            textBox1.Clear();
            textBox2.Clear();
        }

        // exit button:
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
