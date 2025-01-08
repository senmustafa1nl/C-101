// Program.cs
using System;
using SchoolApp;  // Person sınıfını kullanmak için namespace'i dahil ediyoruz.

class Program
{
    static void Main(string[] args)
    {
        // Öğrenciler ve öğretmenler için örnek nesneler
        Person student1 = new Person("Ahmet", "Yılmaz", new DateTime(2005, 5, 20));
        Person student2 = new Person("Ayşe", "Kara", new DateTime(2004, 8, 15));

        Person teacher1 = new Person("Mehmet", "Öztürk", new DateTime(1980, 3, 10));
        Person teacher2 = new Person("Fatma", "Demir", new DateTime(1975, 12, 5));

        // Öğrenci ve öğretmen bilgilerini ekrana yazdırma
        Console.WriteLine("Öğrenciler:");
        student1.DisplayInfo();
        Console.WriteLine();
        student2.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Öğretmenler:");
        teacher1.DisplayInfo();
        Console.WriteLine();
        teacher2.DisplayInfo();
    }
}
