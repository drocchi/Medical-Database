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
    public partial class OutputText : Form
    {
        /// initialize:
        public OutputText()
        {
            InitializeComponent();
        }

        /// list box for output:
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // add all doctors to list box:
        public void AddAllDoctorToListBox(MD.Doctor doctor)
        {
            listBox1.Items.Add(doctor);
        }

        // add all patients to list box:
        public void AddAllPatientToListBox(MD.Patient patient)
        {
            listBox1.Items.Add(patient);
        }

        // add all appointments to list box:
        public void AddAllAppointmentToListBox(MD.Appointment appointment)
        {
            listBox1.Items.Add(appointment);
        }

        // add search doctors to list box:
        public void AddSearchDoctorToListBox(MD.Doctor doctor)
        {
            listBox1.Items.Add(doctor);
        }

        // add search patients to list box:
        public void AddSearchPatientToListBox(MD.Patient patient)
        {
            listBox1.Items.Add(patient);
        }

        // add search appointments to list box:
        public void AddSearchAppointmentToListBox(MD.Appointment appointment)
        {
            listBox1.Items.Add(appointment);
        }

        // entry does not exist:
        public void DoesNotExist()
        {
            listBox1.Items.Add("Entry does not exist in database, try again!");
        }
    }
}
