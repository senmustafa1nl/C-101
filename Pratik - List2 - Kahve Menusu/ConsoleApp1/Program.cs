using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Kahve listesi oluşturuluyor
        List<string> kahveler = new List<string>();

        // Kullanıcıya mesaj gösteriliyor
        Console.WriteLine("Patika Kafe'ye Hos geldiniz.");
        Console.WriteLine("Lutfen 5 farkli Kahve cesidi giriniz!");

        // 5 farklı kahve ismi giriliyor
        string kahve1 = Console.ReadLine();
        kahveler.Add(kahve1);
        Console.WriteLine("Kahve 1: " + kahve1);

        string kahve2 = Console.ReadLine();
        kahveler.Add(kahve2);
        Console.WriteLine("Kahve 2: " + kahve2);

        string kahve3 = Console.ReadLine();
        kahveler.Add(kahve3);
        Console.WriteLine("Kahve 3: " + kahve3);

        string kahve4 = Console.ReadLine();
        kahveler.Add(kahve4);
        Console.WriteLine("Kahve 4: " + kahve4);

        string kahve5 = Console.ReadLine();
        kahveler.Add(kahve5);
        Console.WriteLine("Kahve 5: " + kahve5);

        Console.WriteLine("");

        // Girilen kahve isimleri ekrana yazdırılıyor
        Console.WriteLine("Girilen Kahve Isimleri:");

        foreach (string kahve in kahveler)
        {
            Console.WriteLine(kahve);
        }
    }
}
