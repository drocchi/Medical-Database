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
    public partial class EditAppointment : Form
    {
        /// initialize:
        public EditAppointment()
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
        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// time text box:
        private void maskedTextBox11_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// specialization required text box:
        private void maskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        /// new appointment ID text box:
        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new doctor ID text box:
        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new patient ID text box:
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new date text box:
        private void maskedTextBox18_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new time text box:
        private void maskedTextBox17_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new specialization required text box:
        private void maskedTextBox16_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new details text box:
        private void maskedTextBox15_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new follow up text box:
        private void maskedTextBox14_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// new current text box:
        private void maskedTextBox13_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        /// edit appointment button:
        private void button1_Click(object sender, EventArgs e)
        {
            string appointment_id = maskedTextBox1.Text;
            string doctor_id = maskedTextBox2.Text;
            string patient_id = maskedTextBox3.Text;
            string date = maskedTextBox12.Text;
            string time = maskedTextBox11.Text;
            string needed_specialization = maskedTextBox10.Text;
            string details = maskedTextBox9.Text;
            string needs_follow_up = maskedTextBox8.Text;
            string current = maskedTextBox7.Text;

            string newAppointment_id = maskedTextBox6.Text;
            string newDoctor_id = maskedTextBox5.Text;
            string newPatient_id = maskedTextBox4.Text;
            string newDate = maskedTextBox18.Text;
            string newTime = maskedTextBox17.Text;
            string newNeeded_specialization = maskedTextBox16.Text;
            string newDetails = maskedTextBox15.Text;
            string newNeeds_follow_up = maskedTextBox14.Text;
            string newCurrent = maskedTextBox13.Text;

            foreach (var data in MD.Appointment.appointments)
            {
                if (appointment_id == data.appointment_id || doctor_id == data.doctor_id || patient_id == data.patient_id || date == data.date || time == data.time || 
                    needed_specialization == data.needed_specialization || details == data.details || needs_follow_up == data.needs_follow_up || current == data.current)
                {
                    data.appointment_id = newAppointment_id;
                    data.doctor_id = newDoctor_id;
                    data.patient_id = newPatient_id;
                    data.date = newDate;
                    data.time = newTime;
                    data.needed_specialization = newNeeded_specialization;
                    data.details = newDetails;
                    data.needs_follow_up = newNeeds_follow_up;
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
