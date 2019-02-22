using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_Database
{
    public partial class Menu : Form
    {
        /// initialize:
        public Menu()
        {
            InitializeComponent();
        }

        /// logo image:
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        /// main menu label:
        private void label5_Click(object sender, EventArgs e)
        {

        }

        /// open file dialog:
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        /// save file dialog:
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        // search doctors button:
        private void button1_Click_1(object sender, EventArgs e)
        {
            SearchDoctor sd = new Medical_Database.SearchDoctor();
            sd.ShowDialog();
        }

        // search patients button:
        private void button2_Click_1(object sender, EventArgs e)
        {
            SearchPatient sp = new Medical_Database.SearchPatient();
            sp.ShowDialog();
        }

        // search appointment button:
        private void button3_Click_1(object sender, EventArgs e)
        {
            SearchAppointment sa = new Medical_Database.SearchAppointment();
            sa.ShowDialog();
        }

        // add doctor button:
        private void button4_Click_1(object sender, EventArgs e)
        {
            AddDoctor d = new Medical_Database.AddDoctor();
            d.ShowDialog();
        }

        // add patient button:
        private void button5_Click_1(object sender, EventArgs e)
        {
            AddPatient p = new Medical_Database.AddPatient();
            p.ShowDialog();
        }

        // add appointment button:
        private void button6_Click_1(object sender, EventArgs e)
        {
            AddAppointment a = new Medical_Database.AddAppointment();
            a.ShowDialog();
        }

        // edit doctor button:
        private void button8_Click_1(object sender, EventArgs e)
        {
            EditDoctor ed = new Medical_Database.EditDoctor();
            ed.ShowDialog();
        }

        // edit patient button:
        private void button9_Click_1(object sender, EventArgs e)
        {
            EditPatient ep = new Medical_Database.EditPatient();
            ep.ShowDialog();
        }

        // edit appointments:
        private void button10_Click_1(object sender, EventArgs e)
        {
            EditAppointment ea = new Medical_Database.EditAppointment();
            ea.ShowDialog();
        }

        // list all doctors button:
        private void button11_Click_1(object sender, EventArgs e)
        {
            OutputText o = new Medical_Database.OutputText();
            o.Show();
            o.ResetText();

            foreach (var data in MD.Doctor.doctors)
            {
                o.AddAllDoctorToListBox(data);
            }
        }

        // list all patients button:
        private void button12_Click_1(object sender, EventArgs e)
        {
            OutputText o = new Medical_Database.OutputText();
            o.Show();
            o.ResetText();

            foreach (var data in MD.Patient.patients)
            {
                o.AddAllPatientToListBox(data);
            }
        }

        // list all appointments button:
        private void button13_Click_1(object sender, EventArgs e)
        {
            OutputText o = new Medical_Database.OutputText();
            o.Show();
            o.ResetText();

            foreach (var data in MD.Appointment.appointments)
            {
                o.AddAllAppointmentToListBox(data);
            }
        }

        // load file button:
        private void button7_Click_1(object sender, EventArgs e)
        {
            Boolean end_doctors = false;
            Boolean end_patients = false;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    if (line == "END DOCTORS")
                    {
                        end_doctors = true;
                        continue;
                    }

                    if (line == "END PATIENTS")
                    {
                        end_patients = true;
                        continue;
                    }

                    if (end_doctors == true && end_patients == false)
                    {
                        string[] col = line.Split(new char[] { ',' });
                        MD.Patient pat = new MD.Patient(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7], col[8]);
                        MD.Patient.patients.Add(pat);
                    }

                    if (end_patients == true)
                    {
                        string[] col = line.Split(new char[] { ',' });
                        MD.Appointment apt = new MD.Appointment(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7], col[8]);
                        MD.Appointment.appointments.Add(apt);
                    }
                    
                    if (end_doctors == false && end_patients == false)
                    {
                        string[] col = line.Split(new char[] { ',' });
                        MD.Doctor doc = new MD.Doctor(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7], col[8]);
                        MD.Doctor.doctors.Add(doc);
                    }
                }
            }
        }

        // save file button:
        private void button14_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                string path = saveFileDialog1.FileName;

                using (var sw = new StreamWriter(path))
                {
                    foreach(var data in MD.Doctor.doctors)
                    {
                        sw.WriteLine(data.doctor_id + "," + data.first_name + "," + data.last_name + "," + data.specialization + "," +
                            data.email + "," + data.phone_number + "," + data.address + "," + data.ssn + "," + data.current);
                    }
                    sw.WriteLine("END DOCTORS");

                    foreach (var data in MD.Patient.patients)
                    {
                        sw.WriteLine(data.patient_id + "," + data.first_name + "," + data.last_name + "," + data.needed_specialization + "," +
                            data.email + "," + data.phone_number + "," + data.address + "," + data.ssn + "," + data.current);
                    }
                    sw.WriteLine("END PATIENTS");

                    foreach (var data in MD.Appointment.appointments)
                    {
                        sw.WriteLine(data.appointment_id + "," + data.doctor_id + "," + data.patient_id + "," + data.date + "," + data.time + "," + 
                            data.needed_specialization + "," + data.details + "," + data.needs_follow_up + "," + data.current);
                    }        
                }
            }
        }

        // info button:
        private void button16_Click(object sender, EventArgs e)
        {

        }

        // exit button:
        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
