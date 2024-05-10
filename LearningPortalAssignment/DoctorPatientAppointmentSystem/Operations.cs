using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DoctorPatientAppointmentSystem
{

    public static class Operations
    {
        public static Patient currentuser;
        public static void AddDefaultValues()
        {
            Doctor doctor1 = new Doctor("Nancy", "Anaesthesiology");
            Doctor doctor2 = new Doctor("Andrew", "Cardiology");
            Doctor doctor3 = new Doctor("Janet", "Diabetology");
            Doctor doctor4 = new Doctor("Margaret", "Neonatology");
            Doctor doctor5 = new Doctor("Steven", "Nephrology");
            AppointmentManager.doctors.Add(doctor1);
            AppointmentManager.doctors.Add(doctor2);
            AppointmentManager.doctors.Add(doctor3);
            AppointmentManager.doctors.Add(doctor4);
            AppointmentManager.doctors.Add(doctor5);

            Patient patient1 = new Patient("welcome", "Robert", 40, Gender.Male);
            Patient patient2 = new Patient("welcome", "Laura", 36, Gender.Female);
            Patient patient3 = new Patient("welcome", "Anne", 42, Gender.Female);
            AppointmentManager.patients.Add(patient1);
            AppointmentManager.patients.Add(patient2);
            AppointmentManager.patients.Add(patient3);
            Appointment appointment1 = new Appointment(1, 2, new DateTime(2012, 03, 08), "Heart problem");
            Appointment appointment2 = new Appointment(1, 5, new DateTime(2012, 03, 08), "Spinal cord injury");
            Appointment appointment3 = new Appointment(2, 2, new DateTime(2012, 03, 08), "Heart attack");
            AppointmentManager.appointments.Add(appointment1);
            AppointmentManager.appointments.Add(appointment2);
            AppointmentManager.appointments.Add(appointment3);
        }
        public static void MainMenu()
        {
            int choice;
            do
            {
                Console.WriteLine($"Main Menu");
                Console.WriteLine($"\t1. Login");
                Console.WriteLine($"\t2. Register");
                Console.WriteLine($"\t3. Exit");
                Console.Write($"Enter your choice :");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Login();
                            break;
                        }
                    case 2:
                        {
                            Register();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Exiting");
                            break;

                        }
                    default:
                        {
                            Console.WriteLine($"Enter valid option");
                            break;
                        }
                }

            } while (choice != 3);
        }
        public static void Login()
        {
            bool isPresent = false;
            Console.Write($"Enter your user name : ");
            string name = Console.ReadLine();
            Console.Write($"Enter your password : ");
            string password = Console.ReadLine();
            foreach (Patient patient in AppointmentManager.patients)
            {
                if (patient.Name.Equals(name) && patient.Password.Equals(password))
                {
                    isPresent = true;
                    Console.WriteLine($"Logged in successfully");
                    currentuser = patient;
                    PatientMenu();
                    break;
                }
            }
            if (!isPresent)
            {
                Console.WriteLine($"Sorry, your record is invalid. Please register your profile and log in again.");

            }
        }
        public static void PatientMenu()
        {
            int choice;
            do
            {
                Console.WriteLine($"Patient Menu");
                Console.WriteLine($"\t1. Book Appointment");
                Console.WriteLine($"\t2. View Appointment details");
                Console.WriteLine($"\t3. Edit my profile");

                Console.WriteLine($"\t4. Exit");
                Console.Write($"Enter your choice :");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            BookAppointment();
                            break;
                        }
                    case 2:
                        {
                            ViewAppointment();
                            break;
                        }
                    case 3:
                        {
                            EditPatientProfile();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Exiting to main menu");
                            break;

                        }
                    default:
                        {
                            Console.WriteLine($"Enter valid option");
                            break;
                        }
                }

            } while (choice != 4);
        }
        public static void BookAppointment()
        {
            int choice;
            int doctorID = 0 ;
            Console.WriteLine($"Select the department from the below List:");
            Console.WriteLine($"\t1. Anaesthesiology");
            Console.WriteLine($"\t2. Cardiology");
            Console.WriteLine($"\t3. Diabetology");
            Console.WriteLine($"\t4. Neonatology");
            Console.WriteLine($"\t5. Nephrology");
      
            Console.Write($"Enter your choice :");
            choice = int.Parse(Console.ReadLine());
            if(choice>0 && choice<6){
                string[] departments =new string[]{"","Anaesthesiology","Cardiology","Diabetology","Neonatology","Nephrology"};
            
                doctorID = AppointmentManager.CheckAvailability(departments[choice]);
            }
            if(doctorID!=0){
                 Console.WriteLine($"Appointment is confirmed for the date – {DateTime.Now.ToString("d/M/yyyy")}. To book press \"Y\", to cancel press \"N\".");
                char option = char.Parse(Console.ReadLine());
                if(option=='Y'){
                    Console.Write($"Enter problem : ");
                    string problem = Console.ReadLine();
                    int appointmentID = AppointmentManager.BookAppointment(currentuser.PatientID,doctorID, DateTime.Now, problem);
                    Console.WriteLine($"Appointment booked successfully and Appointment ID {appointmentID}");
                    
                }
                else{
                    Console.WriteLine($"Entering patient Menu");
                    
                }
            }
            else{
                Console.WriteLine($"Doctor is not available");
                
            }
           

        }
        public static void ViewAppointment()
        {
            List<Appointment> currentUserAppointments = AppointmentManager.ViewAppointment(currentuser);
            if (currentUserAppointments.Count > 0)
            {
                string line = "-------------------------------------------------------------------------------";
                Console.WriteLine(line);

                Console.WriteLine($"|{"Appointment ID",-14}|{"Patient ID",-10}|{"Doctor ID",-9}|{"Date",-10}|{"Problem",-30}|");

                Console.WriteLine(line);

                foreach (Appointment appointment in currentUserAppointments)
                {
                    Console.WriteLine($"|{appointment.AppointmentID,-14}|{appointment.PatientID,-10}|{appointment.DoctorID,-9}|{appointment.Date.ToString("d/M/yyyy"),-10}|{appointment.Problem,-30}|");
                    Console.WriteLine(line);

                }
            }
            else{
                Console.WriteLine($"There is no history for this patient");
                
            }
        }
        public static void Register()
        {
            Console.Write($"Enter your name : ");
            string name = Console.ReadLine();
            Console.Write($"Enter your password : ");
            string password = Console.ReadLine();
            Console.Write($"Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write($"Enter your gender (Male, Female) : ");
            bool temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out Gender gender);
            Patient patient = new Patient(password,name, age, gender);
            AppointmentManager.patients.Add(patient);
            Console.WriteLine($"Added patient successfully and patient ID {patient.PatientID}");

        }
        public static void EditPatientProfile()
        {
            Console.WriteLine($"Enter all the below details to edit your profile");

            Console.Write($"Enter your name : ");
            string name = Console.ReadLine();
            Console.Write($"Enter your password : ");
            string password = Console.ReadLine();
            Console.Write($"Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write($"Enter your gender (Male, Female) : ");
            bool temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out Gender gender);
            AppointmentManager.EditPatientProfile(currentuser.PatientID, name, password, age, gender);
            Console.WriteLine($"Profile edited successfully and patient ID {currentuser.PatientID}");

        }
    }
}