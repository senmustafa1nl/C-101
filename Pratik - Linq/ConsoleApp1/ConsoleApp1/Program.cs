using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sayılardan oluşan bir liste oluşturuluyor
        List<int> sayilar = new List<int>(){-15, -20, 5, 18, 19, 25, 10, -4, 20, 35};

        // Listeyi küçükten büyüğe sıralıyoruz
        sayilar.Sort();
        Console.WriteLine("----------------SAYILAR-----------------");

        // Listeyi ekrana yazdırıyoruz
        foreach(int infoSayilar in sayilar){
            Console.WriteLine(infoSayilar);
        }

        // Çift sayıları filtreliyoruz
        Console.WriteLine("--------------CIFT SAYILAR--------------");
        var ciftSayilar = sayilar.Where(x => x % 2 == 0).ToList();

        // Çift sayıları ekrana yazdırıyoruz
        foreach (int cift in ciftSayilar)
        {
            Console.WriteLine(cift);
        }

        // Tek sayıları filtreliyoruz
        Console.WriteLine("--------------TEK SAYILAR---------------"); 
        var tekSayilar = sayilar.Where(x => x % 2 == 1 || x % 2 == -1).ToList();

        // Tek sayıları ekrana yazdırıyoruz
        foreach(int tek in tekSayilar){
            Console.WriteLine(tek);
        }

        // Negatif sayıları filtreliyoruz
        Console.WriteLine("-----------NEGATIF SAYILAR---------------");
        var negatif = sayilar.Where(x => x < 0).ToList();

        // Negatif sayıları ekrana yazdırıyoruz
        foreach(int negatifSayilar in negatif){
            Console.WriteLine(negatifSayilar);
        }

        // Pozitif sayıları filtreliyoruz
        Console.WriteLine("------------POZITIF SAYILAR--------------");
        var pozitif = sayilar.Where(x => x >= 0).ToList();

        // Pozitif sayıları ekrana yazdırıyoruz
        foreach(int pozitifSayilar in pozitif){
            Console.WriteLine(pozitifSayilar);
        }

        // 15'ten büyük ve 22'den küçük sayıları filtreliyoruz
        Console.WriteLine("---15'ten BUYUK ve 22'den KUCUK SAYILAR---");
        var yeniSayilar = sayilar.Where(x => x > 15 && x < 22).ToList();

        // Bu sayıları ekrana yazdırıyoruz
        foreach(int i in yeniSayilar){
            Console.WriteLine(i);
        }

        // Sayıların karelerini alıyoruz
        Console.WriteLine("-------------SAYILARIN KARESI-------------");

        List<int> kareSayilar = new List<int>();

        // Fonksiyon tanımlıyoruz: Sayının karesini alacak
        Func<int,int> kare = x => (x * x);

        // Her sayının karesini hesaplıyoruz ve kareSayilar listesine ekliyoruz
        foreach(int sqr in sayilar){
            kareSayilar.Add(kare(sqr));
        }

        // Karesi alınan sayıları ekrana yazdırıyoruz
        foreach(int x in kareSayilar){
            Console.WriteLine(x);
        }


    }
}

/* 
Sayılar Listesi: İlk olarak bir liste tanımlanır ve rastgele sayılar eklenir. Bu sayılar hem pozitif hem de negatif değerlere sahip olabilir.
Sort() Metodu: sayilar.Sort(); komutu, listeyi küçükten büyüğe sıralar.
Where() Metodu ile Filtreleme: Where metodunu kullanarak çeşitli koşullara göre listeyi filtreliyoruz:
Çift sayılar: x % 2 == 0 koşulu ile çift sayılar seçilir.
Tek sayılar: x % 2 == 1 || x % 2 == -1 koşulu ile tek sayılar seçilir. (Negatif tek sayılar da dahil.)
Negatif sayılar: x < 0 koşuluyla negatif sayılar filtrelenir.
Pozitif sayılar: x >= 0 koşuluyla pozitif sayılar filtrelenir.
Özel aralık (15'ten büyük, 22'den küçük): x > 15 && x < 22 koşuluyla, 15'ten büyük ve 22'den küçük sayılar seçilir.
Kare Hesaplama: Func<int, int> kare = x => (x * x); ifadesi ile sayının karesini hesaplayan bir fonksiyon tanımlanır. 
Daha sonra her bir sayının karesi hesaplanır ve kareSayilar listesine eklenir. 
*/