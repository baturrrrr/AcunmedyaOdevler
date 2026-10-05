using Odev4_Miras_Tasit.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Car araba1 = new Car(1,"Toyota","Corolla",2020);
        araba1.Display();
        Car araba2 = new Car(2,"Honda","CRV",1998);
        araba2.Display();
        
    }
}
