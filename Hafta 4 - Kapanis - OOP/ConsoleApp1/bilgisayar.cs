using Magaza;  // 'Magaza' namespace'ini kullanıyoruz. Buradaki BaseMakine sınıfı gibi sınıflar bu namespace altında yer alıyor.

// Bilgisayar sınıfı, BaseMakine sınıfından türetilmiştir.
// BaseMakine sınıfı büyük ihtimalle, ortak özellik ve metodları içeren bir temel sınıftır.
public class Bilgisayar : BaseMakine
{
    // _usbGirisSayisi private alanı, USB giriş sayısını saklamak için kullanılır.
    private int _usbGirisSayisi;

    // UsbGirisSayisi property'si, USB giriş sayısını alır ve ayarlar.
    // Değer yalnızca 2 veya 4 olabilir, aksi takdirde hata mesajı verilir.
    public int UsbGirisSayisi
    {
        get { return _usbGirisSayisi; }  // Giriş sayısını döndürür.
        set
        {
            if (value == 2 || value == 4)  // Yalnızca 2 veya 4 geçerlidir.
            {
                _usbGirisSayisi = value;  // Geçerli değer atanır.
            }
            else
            {
                Console.WriteLine("USB sayısı 2 veya 4 olmalıdır!");  // Geçersiz giriş için hata mesajı.
            }
        }
    }

    // BluetoothVarMi özelliği, bilgisayarın Bluetooth özelliğini belirtir.
    public bool BluetoothVarMi;

    // BilgileriYazdir metodu, bilgisayarın tüm bilgilerini ekrana yazdırır.
    public override void BilgileriYazdir()
    {
        // BaseMakine sınıfından miras alınan bazı özellikleri de kullanabiliriz, örneğin Ad, SeriNumarasi gibi.
        Console.WriteLine($"Bilgisayar Adı: {Ad}");  // Bilgisayarın adı yazdırılır.
        Console.WriteLine($"Seri Numarası: {SeriNumarasi}");  // Seri numarası yazdırılır.
        Console.WriteLine($"Üretim Tarihi: {uretimTarihi}");  // Üretim tarihi yazdırılır.
        Console.WriteLine($"Açıklama: {Aciklama}");  // Bilgisayarın açıklaması yazdırılır.
        Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");  // Bilgisayarın işletim sistemi yazdırılır.
        Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");  // USB giriş sayısı yazdırılır.
        Console.WriteLine($"Bluetooth: {(BluetoothVarMi ? "Var" : "Yok")}");  // Bluetooth var mı sorusu evet ya da hayır olarak yazdırılır.
    }

    // UrunAdiGetir metodu, bilgisayarın adını ekrana yazdırır.
    public override void UrunAdiGetir()
    {
        // Bilgisayarın adı ekrana yazdırılır.
        Console.WriteLine($"Bilgisayarınızın adı: ---> {Ad}");
    }
}
