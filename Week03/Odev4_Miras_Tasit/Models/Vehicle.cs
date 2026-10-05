using System;

namespace Odev4_Miras_Tasit.Models;

public class Vehicle
{
    public int Id { get; set; }
    public String Brand { get; set; }=string.Empty;

    public virtual void Display()
    {
       Console.Write($" [{Id}] - {Brand} "); 
    }

    public Vehicle(int id,String brand)
    {
        Id = id;
        Brand = brand;
    }
}
