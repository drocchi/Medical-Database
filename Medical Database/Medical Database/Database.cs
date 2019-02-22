using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Medical_Database
{
    public class MD
    {
        // class for doctors:
        public class Doctor
        {
            public String doctor_id;
            public String first_name;
            public String last_name;
            public String specialization;
            public String email;
            public String phone_number;
            public String address;
            public String ssn;
            public String current;

            // constructor:
            public Doctor(String doctor_id, String first_name, String last_name, String specialization, 
                String email, String phone_number, String address, String ssn, String current)
            {
                this.doctor_id = doctor_id;
                this.first_name = first_name;
                this.last_name = last_name;
                this.specialization = specialization;
                this.email = email;
                this.phone_number = phone_number;
                this.address = address;
                this.ssn = ssn;
                this.current = current;
            }

            // override ToString() for printing:
            public override string ToString()
            {
                return "Doctor ID: " + doctor_id + ", Name: " + first_name + " " + last_name + ", Specialization: " + specialization + ", Email: " + 
                    email + ", Phone Number: " + phone_number + ", Address: " + address + ", SSN: " + ssn + ", Current Employee: " + current;
            }

            // container:
            public static IList<Doctor> doctors = new List<Doctor>();
        }

        // class for patients:
        public class Patient
        {
            public String patient_id;
            public String first_name;
            public String last_name;
            public String needed_specialization;
            public String email;
            public String phone_number;
            public String address;
            public String ssn;
            public String current;

            // constructor:
            public Patient(String patient_id, String first_name, String last_name, String needed_specialization, 
                String email, String phone_number, String address, String ssn, String current)
            {
                this.patient_id = patient_id;
                this.first_name = first_name;
                this.last_name = last_name;
                this.needed_specialization = needed_specialization;
                this.email = email;
                this.phone_number = phone_number;
                this.address = address;
                this.ssn = ssn;
                this.current = current;
            }

            // override ToString() for printing:
            public override string ToString()
            {
                return "Patient ID: " + patient_id + ", Name: " + first_name + " " + last_name + ", Specialization Required: " + needed_specialization + ", Email: " + 
                    email + ", Phone Number " + phone_number + ", Address: " + address + ", SSN: " + ssn + "Current Patient: " + current;
            }

            // container:
            public static IList<Patient> patients = new List<Patient>();
        }

        // class for appointments:
        public class Appointment
        {
            public String appointment_id;
            public String doctor_id;
            public String patient_id;
            public String date;
            public String time;
            public String needed_specialization;
            public String details;
            public String needs_follow_up;
            public String current;

            // constructor:
            public Appointment(String appointment_id, String doctor_id, String patient_id, String date, String time, 
                String needed_specialization, String details, String needs_follow_up, String current)
            {
                this.appointment_id = appointment_id;
                this.doctor_id = doctor_id;
                this.patient_id = patient_id;
                this.date = date;
                this.time = time;
                this.needed_specialization = needed_specialization;
                this.details = details;
                this.needs_follow_up = needs_follow_up;
                this.current = current;
            }

            // override ToString() for printing:
            public override string ToString()
            {
                return "Appointment ID: " + appointment_id + ", Doctor ID: " + doctor_id + ", Patient ID: " + patient_id + ", Date: " + date + ", Time: " + time + ", Specialization Required: " + 
                    needed_specialization + ", Details: " + details + ", Follow Up Required: " + needs_follow_up + ", Current Appointment: " + current;
            }

            // container:
            public static IList<Appointment> appointments = new List<Appointment>();
        }

        // class for users:
        public class User
        {
            public String username;
            public String password;
            public String first_name;
            public String last_name;
            public String email;
            public String phone_number;

            // constructor:
            public User(String username, String password, String first_name, String last_name, String email, String phone_number)
            {
                this.username = username;
                this.password = password;
                this.first_name = first_name;
                this.last_name = last_name;
                this.email = email;
                this.phone_number = phone_number;
            }

            // container:
            public static IList<User> users = new List<User>();
        }
    }
}
