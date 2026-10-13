using Odev7_Interface.Models;

namespace Odev7_Interface;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer(1,"Batur");
        Product product = new Product(101,"PC");
        Console.WriteLine($"{customer.Id} - {customer.GetDisplayName()}");
        Console.WriteLine($"{product.Id} - {product.GetDisplayName()}");

        IIdentifiable[] items = { customer, product };

        foreach(IIdentifiable item in items)
        {
            Console.WriteLine(item.GetDisplayName());
        }


    }
}
