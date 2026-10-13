using System;

namespace Odev7_Interface.Models;

public class Customer : IIdentifiable
{
    public int Id { get;  }
    public string Name { get; set; }

    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public string GetDisplayName()
    {
        return Name;
    }

}
