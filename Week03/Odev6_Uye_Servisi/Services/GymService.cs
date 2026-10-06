using System;
using Odev6_Uye_Servisi.Models;

namespace Odev6_Uye_Servisi.Services;

public class GymService
{
    private readonly List<GymMember> _members = new();
    private int _nextId = 1;

    public void AddMember(string name , string email)
    {
        if (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Hata: Ad boş olamaz.");
        return;
    }
        GymMember member = new GymMember(_nextId,name,email);
        _nextId++;
        _members.Add(member);
        Console.WriteLine("Üye eklendi");

    }
    public void ListMembers()
    {
        if (_members.Count == 0)
        {
            Console.WriteLine("Kayıt yok.");
        }
        else
        {
            Console.WriteLine("----- ÜYE LİSTESİ -----");
            foreach(GymMember member in _members)
            {
                member.Display();
            }
        }
    }

    public GymMember? FindByName(string search)
    {
        foreach (GymMember member in _members)
        {
            if (member.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
            {
                return member;
            }
        }
        return null;
    }
}
