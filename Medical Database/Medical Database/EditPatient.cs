using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_Database
{
    public partial class EditPatient : Form
    {
        /// initialize:
        public EditPatient()
        {
            InitializeComponent();
        }

        /// patient ID text box:
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// patient first name text box:
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// patient last name text box:
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// specialization required text box:
        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// email text box:
        private void maskedTextBox11_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// phone number text box:
        private void maskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// address text box:
        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        /// SSN text box:
        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// current text box:
        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new patient ID text box:
        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new first name text box:
        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new last name text box:
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new specialization required text box:
        private void maskedTextBox18_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new email text box:
        private void maskedTextBox17_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new phone number text box:
        private void maskedTextBox16_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new address text box:
        private void maskedTextBox15_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new SSN text box:
        private void maskedTextBox14_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new current text box:
        private void maskedTextBox13_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        // edit patient button:
        private void button1_Click(object sender, EventArgs e)
        {
            string patient_id = maskedTextBox1.Text;
            string first_name = maskedTextBox2.Text;
            string last_name = maskedTextBox3.Text;
            string needed_specialization = maskedTextBox12.Text;
            string email = maskedTextBox11.Text;
            string phone_number = maskedTextBox10.Text;
            string address = maskedTextBox9.Text;
            string ssn = maskedTextBox8.Text;
            string current = maskedTextBox7.Text;

            string newPatient_id = maskedTextBox6.Text;
            string newFirst_name = maskedTextBox5.Text;
            string newLast_name = maskedTextBox4.Text;
            string newNeeded_specialization = maskedTextBox18.Text;
            string newEmail = maskedTextBox17.Text;
            string newPhone_number = maskedTextBox16.Text;
            string newAddress = maskedTextBox15.Text;
            string newSsn = maskedTextBox14.Text;
            string newCurrent = maskedTextBox13.Text;

            foreach (var data in MD.Patient.patients)
            {
                if (patient_id == data.patient_id || first_name == data.first_name || last_name == data.last_name || needed_specialization == newNeeded_specialization || 
                    email == newEmail || phone_number == newPhone_number || address == newAddress || ssn == newSsn || current == newCurrent)
                {
                    data.patient_id = newPatient_id;
                    data.first_name = newFirst_name;
                    data.last_name = newLast_name;
                    data.needed_specialization = newNeeded_specialization;
                    data.email = newEmail;
                    data.phone_number = newPhone_number;
                    data.address = newAddress;
                    data.ssn = newSsn;
                    data.current = newCurrent;
                }
            }

            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
            maskedTextBox7.Clear();
            maskedTextBox8.Clear();
            maskedTextBox9.Clear();
            maskedTextBox10.Clear();
            maskedTextBox11.Clear();
            maskedTextBox12.Clear();
            maskedTextBox13.Clear();
            maskedTextBox14.Clear();
            maskedTextBox15.Clear();
            maskedTextBox16.Clear();
            maskedTextBox17.Clear();
            maskedTextBox18.Clear();
        }

        // exit button:
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
