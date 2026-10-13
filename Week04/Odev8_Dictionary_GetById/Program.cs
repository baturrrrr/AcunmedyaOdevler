using Odev8_Dictionary_GetById.Models;
using Odev8_Dictionary_GetById.Services;

namespace Odev8_Dictionary_GetById;

class Program
{
    static void Main(string[] args)
    {
        GymService service = new GymService();
        service.AddMember("Batur","batur@gmail.com");
        service.AddMember("Mehmet","mehmet@gmail.com");
        service.AddMember("Ahmet","ahmet@gmail.com");

        GymMember? found = service.GetById(2);
        if(found != null)
        {
            found.Display();
        }
        else
        {
            Console.WriteLine("Üye bulunamadı.");
        }

        GymMember? missing = service.GetById(99);
        if ( missing != null)
        {
            missing.Display();
        }
        else
        {
            Console.WriteLine("Üye bulunamadı. ");
        }
    }
}
