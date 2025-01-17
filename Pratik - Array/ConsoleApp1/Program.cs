using System;

public class Program
{
    public static void Main()
    {
        // 1 - 10 adet tam sayı verisi alacak bir dizi tanımlanıyor.
        int[] sayilar = new int[10];  // 10 elemanlı bir dizi oluşturuluyor.

        // 2 - Bu dizinin elemanlarını bir for döngüsü ile dolduruyoruz.
        for (int i = 0; i < 10; i++)
        {
            Random rndsyi = new Random();
             int uretilenRnd = rndsyi.Next(0,1000);
            sayilar[i] = uretilenRnd ;  // Dizinin her elemanını sırasıyla 0, 1, 2, ..., 9 olarak dolduruyoruz.
        }

        // 2 - Dizinin elemanlarını bir foreach döngüsü ile ekrana yazdırıyoruz.
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);  // Her bir sayıyı ekrana yazdırıyoruz.
        }

        // 3 - Kullanıcıdan yeni bir sayı alınıp dizinin 11. elemanı olarak ekleniyor.
        Console.WriteLine("Lütfen 0 ile 100 arasinda yeni bir sayı giriniz:");
        Array.Resize(ref sayilar, sayilar.Length + 1);  // Dizinin boyutunu 1 arttırıyoruz (11 elemanlı hale getiriyoruz).

        sayilar[10] = Convert.ToInt32(Console.ReadLine());  // Kullanıcıdan alınan değeri dizinin 11. elemanına ekliyoruz.


        Console.WriteLine("----------------------------------------");
        // 4 - Diziyi büyükten küçüğe sıralıyoruz.
        Array.Sort(sayilar);  // Diziyi küçükten büyüğe sıralıyoruz.
        Array.Reverse(sayilar);  // Diziyi tersine çeviriyoruz (büyükten küçüğe sıralanmış olur).

        // 4 - Dizinin elemanlarını büyükten küçüğe ekrana yazdırıyoruz.
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);  // Her bir sayıyı ekrana yazdırıyoruz.
        }
    }
}
