using System;
using System.Collections.Generic;
using System.Reflection;
using Otopark;

class Program
{
    public static void Main()
    {
        // Arabaların tutulacağı bir liste oluşturuluyor
        List<Araba> arabalar = new List<Araba>();

        // Kullanıcıya hoşgeldiniz mesajı gösteriliyor
        Console.WriteLine("Patika Araba Fabrikasi'na Hos Geldiniz !");

        // Kullanıcıdan araba üretmek isteyip istemediği soruluyor
        sorgu:
        Console.WriteLine("Araba uretmek istiyorsaniz 'E' ; \nistemiyorsaniz 'H' harfini yaziniz ! ");
        string kullaniciGirdi = Console.ReadLine().ToLower(); // Kullanıcı girişi alınıyor ve küçük harfe dönüştürülüyor

        // Eğer kullanıcı 'E' harfine basarsa, araba üretim süreci başlar
        if (kullaniciGirdi == "e")
        {
            // Yeni bir araba nesnesi oluşturuluyor
            Araba araba = new Araba();
            araba.uretimTarihi = DateTime.Now;  // Üretim tarihi şu anki tarih olarak ayarlanıyor

            // Kullanıcıdan arabanın seri numarasını alıyoruz
            Console.WriteLine("Arabanin 4 haneli seri numarasini giriniz");
            araba.seriNumarasi = Convert.ToInt32(Console.ReadLine());  // Seri numarası kullanıcıdan alınır ve tam sayıya dönüştürülür

            // Kullanıcıdan arabanın markasını alıyoruz
            Console.WriteLine("Arabanin markasini giriniz");
            araba.marka = Console.ReadLine();  // Marka bilgisi alınır

            // Kullanıcıdan arabanın modelini alıyoruz
            Console.WriteLine("Arabanin modelini giriniz ");
            araba.model = Console.ReadLine();  // Model bilgisi alınır

            // Kullanıcıdan arabanın rengini alıyoruz
            Console.WriteLine("Arabanin rengini giriniz");
            araba.renk = Console.ReadLine();  // Renk bilgisi alınır

            // Kapı sayısını kontrol etmek için bir kontrol değişkeni oluşturuluyor
            bool arabaKapisiDogru = false;

            // Kapı sayısı doğrulama döngüsü
        tekrar:
            while (arabaKapisiDogru == false)
            {
                try
                {
                    // Kullanıcıya kaç kapı olacağını soruyoruz
                    Console.WriteLine("Arabada kac kapi olmasini istersiniz?\n2 veya 4 ?");
                    araba.kapiSayisi = Convert.ToInt32(Console.ReadLine());  // Kapı sayısı kullanıcıdan alınır ve tam sayıya dönüştürülür

                    // Eğer kapı sayısı 2 veya 4 ise, doğrulama yapılmış olur
                    if (araba.kapiSayisi == 2 || araba.kapiSayisi == 4)
                    {
                        arabaKapisiDogru = true;  // Kapı sayısı doğruysa döngü sonlanır
                        arabalar.Add(araba);  // Araba listeye eklenir
                        Console.WriteLine(araba);  // Arabayı ekrana yazdırıyoruz
                    }
                    else
                    {
                        // Kapı sayısı yanlışsa tekrar sorulacak
                        arabaKapisiDogru = false;
                    }
                }
                catch (FormatException ex)
                {
                    // Eğer kullanıcı yanlış bir format girerse (örneğin harf veya başka bir şey)
                    Console.WriteLine("Arac kapisi icin 2 veya 4 degerini girmelisiniz !");
                    goto tekrar;  // Hata olduğunda tekrar aynı soruyu sorar
                }
            }
        }
        // Eğer kullanıcı 'H' harfine basarsa, teşekkür mesajı gösterilir
        else if (kullaniciGirdi == "h")
        {
            Console.WriteLine("Araba siparis etmek istediginiz bir vakitte gorusmek uzere!");
        }
        // Kullanıcı yanlış bir giriş yaparsa, hata mesajı verilir ve tekrar giriş yapılması istenir
        else
        {
            Console.WriteLine("Yanlis bir deger girdiniz!");
            goto sorgu;  // Yanlış bir değer girildiyse, kullanıcıya tekrar doğru seçim yapması hatırlatılır
        }
    }
}
