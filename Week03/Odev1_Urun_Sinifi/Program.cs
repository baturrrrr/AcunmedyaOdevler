
using System.ComponentModel.DataAnnotations;


Telefon telefon1 = new Telefon { Id = 1, Name = "Iphone", Price = 80000};
Telefon telefon2 = new Telefon();
telefon2.Id = 2;
telefon2.Name = "Samsung";
telefon2.Price = 70000;
Telefon telefon3 = new Telefon { Id = 1, Name = "Oppo", Price = 30000};
telefon1.Display();
telefon2.Display();
telefon3.Display();