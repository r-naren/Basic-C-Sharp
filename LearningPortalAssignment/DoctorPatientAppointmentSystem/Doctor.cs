using System;
namespace DoctorPatientAppointmentSystem;
public class Doctor{
    private static int s_doctorID = 0;
    public int DoctorID{get;}
    public string Name {get;set;}
    public string Department {get;set;}
    public Doctor(string name, string department){
        DoctorID = ++s_doctorID;
        Name = name;
        Department = department;
    }
}