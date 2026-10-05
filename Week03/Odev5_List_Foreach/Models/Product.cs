using System;
namespace Odev5_List_Foreach.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }=string.Empty;
    public Decimal Price { get; set; }
    


    public void Display()
    {
        Console.WriteLine($"Ürün #{Id}: {Name} — {Price} TL");
    }
    


    
    


}
