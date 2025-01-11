namespace Kisi;  // Kisi isim alanı içinde tanımlanan sınıfları kullanmak için gerekli.

public class BaseKisi 
{
    // Ad, kişinin adını tutan bir özelliktir.
    public string Ad;

    // Soyad, kişinin soyadını tutan bir özelliktir.
    public string Soyad;

    // KisiInfo() metodu, kişinin bilgilerini ekrana yazdıran bir metottur.
    // Bu metot, BaseKisi sınıfında tanımlanmış ve geçersiz kılınabilir (virtual).
    public virtual void KisiInfo()
    {
        // Kişinin adı ve soyadını ekrana yazdırır.
        // Bu metodu, alt sınıflarda geçersiz kılmak (override) mümkündür.
        Console.WriteLine($"Kisi bilgisi : {Ad}  {Soyad}");
    }
}
