using Odev3_Metotlar.Models;

BankAccount hesap1 = new BankAccount();
hesap1.OwnerName = "Batur";
hesap1.Balance = 5000;
hesap1.Deposit(2000);
hesap1.Withdraw(1500);
hesap1.Withdraw(100000);
hesap1.Deposit(-50);
hesap1.Display();
string özet = hesap1.GetSummary();
Console.WriteLine(özet);