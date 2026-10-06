
using System.ComponentModel;
using Odev6_Uye_Servisi.Models;
using Odev6_Uye_Servisi.Services;
GymService service = new GymService();
service.AddMember("Batur","baturbulut@gmail.com");
service.AddMember("Mehmet","mehmet@gmail.com");
service.AddMember("Ahmet","ahmet@gmail.com");
service.AddMember("Ata","ata@gmail.com");
service.AddMember("","abc@gmail.com");
service.ListMembers();
service.FindByName("Batur");
service.FindByName("Ayşe");
