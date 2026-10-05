using System;

namespace Odev2_Constructor.Models;

public class Student
{
    public int Id { get; set; }
    public String FullName { get; set; }=string.Empty;
    public String StudentNumber { get; set; }=string.Empty;

    public Student()
    {
        
    }  
    public Student(int id,string fullName,string studentNumber)
    {
        Id = id;
        FullName = fullName;
        StudentNumber = studentNumber;
    }
    public void Display()
    {
        Console.WriteLine($"Öğrenci ID: {Id} --- İsim: {FullName} --- Öğrenci Numarası: {StudentNumber}");
    }

}
