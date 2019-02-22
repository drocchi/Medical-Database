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
    public partial class SearchPatient : Form
    {
        /// initialize:
        public SearchPatient()
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
        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// email text box:
        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// phone number text box:
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        // search patients button:
        private void button1_Click(object sender, EventArgs e)
        {
            string patient_id = maskedTextBox1.Text;
            string first_name = maskedTextBox2.Text;
            string last_name = maskedTextBox3.Text;
            string needed_specialization = maskedTextBox6.Text;
            string email = maskedTextBox5.Text;
            string phone_number = maskedTextBox4.Text;
            string address = maskedTextBox9.Text;
            string ssn = maskedTextBox8.Text;
            string current = maskedTextBox7.Text;

            Boolean found = false;

            OutputText o = new Medical_Database.OutputText();
            o.Show();
            o.ResetText();

            foreach (var data in MD.Patient.patients)
            {
                if (patient_id == data.patient_id || first_name == data.first_name || last_name == data.last_name ||phone_number == data.phone_number || 
                    email == data.email || phone_number == data.phone_number || address == data.address || ssn == data.ssn || current == data.current)
                {
                    found = true;
                    o.AddSearchPatientToListBox(data);
                }
            }

            if (found == false)
            {
                o.DoesNotExist();
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
        }

        // exit button:
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
