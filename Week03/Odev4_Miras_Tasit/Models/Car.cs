using System;

namespace Odev4_Miras_Tasit.Models;

public class Car:Vehicle
{
    public  Car(int ıd,string brand,string model,int year): base(ıd,brand){
        Model = model;
        Year = year;
    }

    public string Model { get; set; }=string.Empty;
    public int Year { get; set; }
    
    
    public override void Display()
    {
        Console.Write($"{Model} ");
        base.Display();
        Console.WriteLine($" {Year}");
    }
}
