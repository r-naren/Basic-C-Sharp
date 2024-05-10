using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorPatientAppointmentSystem
{
    public static class AppointmentManager
    {
        public static List<Doctor> doctors = new List<Doctor>();
        public static List<Patient> patients = new List<Patient>();
        public static List<Appointment> appointments = new List<Appointment>();
        public static int CheckAvailability(string department)
        {
            int count = 0;
            List<Doctor> freeDoctors = new List<Doctor>();
            foreach(Doctor doctor in doctors){
                if(doctor.Department.Equals(department)){
                    freeDoctors.Add(doctor);
                }
            }
            DateTime today = DateTime.Now;
            TimeSpan span;
            foreach (Doctor doctor in freeDoctors)
            {
                count = 0;
                
                foreach (Appointment appointment in appointments)
                {
                    span = today-appointment.Date;

                    if (appointment.DoctorID.Equals(doctor.DoctorID) && span.Days==0)
                    {
                        count++;
                        
                    }
                }
                if (count > 1)
                {
                    continue;
                }
                else if (count < 2 )
                {
                    return doctor.DoctorID;
                }
            }

            return 0;
        }
        public static int BookAppointment(int patientID, int doctorID, DateTime today, string problem)
        {

            Appointment appointment = new Appointment(patientID,doctorID, today, problem);
            appointments.Add(appointment);
            return appointment.AppointmentID;

        }
        public static List<Appointment> ViewAppointment(Patient currentUser)
        {
            List<Appointment> currentUserAppointments = new List<Appointment>();;
            foreach (Appointment appointment in appointments)
            {
                if (appointment.PatientID.Equals(currentUser.PatientID))
                {
                    currentUserAppointments.Add(appointment);
                }
            }
            return currentUserAppointments;
        }
        public static void EditPatientProfile(int patientID, string password, string name, int age, Gender gender)
        {
            foreach (Patient patient in patients)
            {
                if (patient.PatientID.Equals(patientID))
                {
                    patient.Name = name;
                    patient.Password = password;
                    patient.Age = age;
                    patient.Gender = gender;
                    break;
                }
            }

        }
    }
}