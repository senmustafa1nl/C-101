using Magaza;  // 'Magaza' namespace'ini kullanıyoruz. Burada 'BaseMakine' sınıfı ve diğer sınıflar yer alıyor.

// Telefon sınıfı, BaseMakine sınıfından türemektedir. Bu sınıf, telefonların özelliklerini içerir.
public class Telefon : BaseMakine
{
    // TRLisansVarMi özelliği, telefonun Türkiye'de kayıtlı olup olmadığını belirtir.
    // True ise cihaz Türkiye'ye kaydolmuş demektir, False ise kaydolmamıştır.
    public bool TrLisansVarMi;

    // BilgileriYazdir metodu, telefonun tüm bilgilerini ekrana yazdırır.
    // Bu metot BaseMakine sınıfındaki bir metodu geçersiz kılar (override).
    public override void BilgileriYazdir()
    {
        // Telefonun adı yazdırılır.
        Console.WriteLine($"Telefonunuzun Adı: {Ad}");

        // Seri numarası yazdırılır.
        Console.WriteLine($"Seri Numarası: {SeriNumarasi}");

        // Üretim tarihi yazdırılır.
        Console.WriteLine($"Üretim Tarihi: {uretimTarihi}");

        // Telefonun kısa açıklaması yazdırılır.
        Console.WriteLine($"Açıklama: {Aciklama}");

        // Telefonun işletim sistemi yazdırılır.
        Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");

        // Telefonun TR kaydının olup olmadığı kontrol edilir ve "Evet" ya da "Hayır" olarak yazdırılır.
        Console.WriteLine($"TR Kaydı Var mı?: {(TrLisansVarMi ? "Evet" : "Hayır")}");
    }

    // UrunAdiGetir metodu, telefonun adını ekrana yazdırır.
    // Bu metot da BaseMakine sınıfındaki bir metodu geçersiz kılar (override).
    public override void UrunAdiGetir()
    {
        // Telefonun adı yazdırılır.
        Console.WriteLine($"Telefonunuzun adı: ---> {Ad}");
    }
}
