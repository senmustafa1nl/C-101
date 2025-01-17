using System;

public class Program
{
    public static void Main()
    {
        // 1 - 10 adet rastgele tam sayı verisi alacak bir dizi tanımlanıyor.
        int[] sayilar = new int[10];  // 10 elemanlı bir dizi oluşturuluyor.

        // 2 - Diziyi rastgele sayılarla dolduruyoruz. 
        // Her bir eleman için 0 ile 1000 arasında bir sayı üretiyoruz.
        for (int i = 0; i < 10; i++)
        {
            Random rndsyi = new Random();  // Random sınıfını kullanarak rastgele sayı üreticisi oluşturuluyor.
            int uretilenRnd = rndsyi.Next(0, 1000);  // 0 ile 1000 arasında rastgele bir tam sayı üretiliyor.
            sayilar[i] = uretilenRnd;  // Üretilen sayıyı dizinin her elemanına sırasıyla atıyoruz.
        }

        // 2 - Dizinin elemanlarını `foreach` döngüsü ile ekrana yazdırıyoruz.
        Console.WriteLine("Dizinin Elemanları (Rastgele Sayılar):");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);  // Her bir diziyi ekrana yazdırıyoruz.
        }

        // 3 - Kullanıcıdan yeni bir sayı alıyoruz ve diziyi bir eleman daha büyütüyoruz.
        // Bu yeni sayıyı dizinin 11. elemanı olarak ekliyoruz.
        Console.WriteLine("Lütfen 0 ile 1000 arasında yeni bir sayı giriniz:");
        Array.Resize(ref sayilar, sayilar.Length + 1);  // Dizinin boyutunu bir arttırıyoruz (11 elemanlı hale getiriyoruz).

        // Kullanıcıdan alınan değeri dizinin sonuna (11. eleman) ekliyoruz.
        sayilar[10] = Convert.ToInt32(Console.ReadLine());  // Kullanıcıdan alınan değeri dizinin son elemanına atıyoruz.

        Console.WriteLine("----------------------------------------");

        // 4 - Diziyi sıralıyoruz: Öncelikle küçükten büyüğe sıralıyoruz.
        Array.Sort(sayilar);  // Diziyi küçükten büyüğe sıralıyoruz.
        Array.Reverse(sayilar);  // Ardından diziyi tersine çeviriyoruz (büyükten küçüğe sıralanmış olur).

        // 4 - Dizinin elemanlarını büyükten küçüğe sıralanmış şekilde ekrana yazdırıyoruz.
        Console.WriteLine("Dizinin Elemanları (Büyükten Küçüğe Sıralanmış):");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);  // Her bir sayıyı büyükten küçüğe ekrana yazdırıyoruz.
        }
    }
}
