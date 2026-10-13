using System;

namespace Odev7_Interface.Models;

public class Product : IIdentifiable
{
    public int Id { get;  }
    public string Name { get; set; }

    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public string GetDisplayName()
    {
        return Name;
    }
}
