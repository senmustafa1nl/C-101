using System;

class Program
{
    public static void Main()
    {
        // Kullanıcının doğru giriş yapıp yapmadığını kontrol etmek için bir değişken
        bool dogruGirdi = false;

        // Kullanıcı doğru bir giriş yapana kadar döngü çalışacak
        while(dogruGirdi == false)
        {
            try
            {
                // Kullanıcıdan bir sayı girmesini istiyoruz
                Console.WriteLine("Lütfen bir sayı giriniz!");
                
                // Kullanıcının girdiği değeri tam sayıya dönüştürüyoruz
                int sayi = Convert.ToInt32(Console.ReadLine());  // Kullanıcıdan sayı alıyoruz

                // Girilen sayının karesini hesaplıyoruz
                int sonuc = sayi * sayi;  // Sayının karesini alıyoruz

                // Hesaplanan sonucu ekrana yazdırıyoruz
                Console.WriteLine("Sonuç: " + sonuc);  // Sonucu ekrana yazdırıyoruz

                // Kullanıcı doğru bir giriş yaptıysa döngü sonlanır
                dogruGirdi = true; // Geçerli bir giriş yapıldı, döngü sonlandırılır
            }
            catch (FormatException ex)
            {
                // Eğer kullanıcı geçersiz bir değer girerse (örneğin harf veya sembol),
                // bu blok devreye girer ve hata mesajı yazdırılır.
                Console.WriteLine("Yanlış giriş. Lütfen bir sayı giriniz!");
            }
        }
    }
}
