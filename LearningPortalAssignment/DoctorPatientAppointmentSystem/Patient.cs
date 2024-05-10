using System;
namespace DoctorPatientAppointmentSystem;
public enum Gender { Select, Male, Female}
public class Patient{
    private static int s_patientID = 0;
    public int PatientID{get;}
    private string _password="";
    public string Password {get{ return _password;}set{_password=value;}}
    public string Name {get;set;}
    public int Age {get;set;}
    public Gender Gender {get;set;}

    public Patient(string password, string name, int age, Gender gender){
        PatientID = ++s_patientID;
        Name = name;
        _password = password;
        Age = age;
        Gender = gender;
    }
}