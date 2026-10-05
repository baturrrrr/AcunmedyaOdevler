using Odev2_Constructor.Models;

namespace Odev2_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1,"Batur","251550");
            Student student2 = new Student(2,"MehmetAli","251551");
            Student student3 = new Student();
            student3.Id = 3;
            student3.FullName = "Ahmet";
            student3.StudentNumber = "251552";
            Student student4 = new Student{Id=4,FullName = "Kerem",StudentNumber = "251552"};
            student1.Display();
            student2.Display();
            student3.Display();
            student4.Display();
        }
        
    }
}
