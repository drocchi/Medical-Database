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
    public partial class AddAppointment : Form
    {
        /// initialize:
        public AddAppointment()
        {
            InitializeComponent();
        }

        /// appointment ID text box:
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// doctor ID text box:
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// patient ID text box:
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// date text box:
        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// time text box:
        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// specialization required text box:
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// details text box:
        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// follow up text box:
        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// current text box:
        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        // add appointment button:
        private void button1_Click(object sender, EventArgs e)
        {
            string appointment_id = maskedTextBox1.Text;
            string doctor_id = maskedTextBox2.Text;
            string patient_id = maskedTextBox3.Text;
            string date = maskedTextBox6.Text;
            string time = maskedTextBox5.Text;
            string needed_specialization = maskedTextBox4.Text;
            string details = maskedTextBox9.Text;
            string needs_follow_up = maskedTextBox8.Text;
            string current = maskedTextBox7.Text;

            MD.Appointment apt = new MD.Appointment(appointment_id, doctor_id, patient_id, date, time, needed_specialization, details, needs_follow_up, current);
            MD.Appointment.appointments.Add(apt);

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
