using Kisi;  // Kisi isim alanını kullanıyoruz, böylece BaseKisi sınıfına erişebiliyoruz.

// Ogretmen sınıfı, BaseKisi sınıfından türetilmiştir ve öğretmenlere özel özellikler ekler.
public class Ogretmen : BaseKisi 
{
    // Ogretmen sınıfına özgü olan MaasBilgisi özelliği.
    public double MaasBilgisi { get; set; }  // Öğretmenin maaş bilgisini tutar.

    // KisiInfo() metodu, BaseKisi sınıfında tanımlı olan metodu geçersiz kılar (override).
    // Bu metot, öğretmenin bilgilerini ekrana yazdırmak için kullanılır.
    public override void KisiInfo()
    {
        // Öğretmenin adı, soyadı ve maaş bilgisini ekrana yazdırır.
        Console.WriteLine($"Ogretmen bilgisi : {Ad} {Soyad}\n Ogretmen maasi : {MaasBilgisi}");
    }
}
