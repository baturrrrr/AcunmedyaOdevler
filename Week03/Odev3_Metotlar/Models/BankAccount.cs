using System;

namespace Odev3_Metotlar.Models;

public class BankAccount
{
    public string OwnerName { get; set; }=string.Empty;
    public Decimal Balance { get; set; }

    public void Display()
    {
        Console.WriteLine($"Hesap sahibi: {OwnerName}\nBakiyesi: {Balance}TL");
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Hata: Tutar pozitif olmalı.");
        }
        else
        {
            Balance += amount;
        }
    }
    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Yetersiz bakiye.");
        }else if (amount < 0)
        {
            Console.WriteLine("Pozitif tutar giriniz.");
        }
        else
        {
            Balance -= amount;
        }   
    }
    public string GetSummary()
    {
        return $"Özet: {OwnerName} - {Balance}";
    }

}
