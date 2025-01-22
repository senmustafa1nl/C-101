namespace Otopark
{
    // Araba sınıfı, araç bilgilerini tutar ve ekrana yazdırmak için ToString metodunu içerir.
    public class Araba
    {
        // Üretim tarihi (DateTime türünde), arabanın üretildiği tarih
        public DateTime uretimTarihi { get; set; }

        // Seri numarası (int türünde), her araba için benzersiz 4 haneli seri numarası
        public int seriNumarasi { get; set; }

        // Marka (string türünde), arabanın markası
        public string marka { get; set; }

        // Model (string türünde), arabanın modeli
        public string model { get; set; }

        // Renk (string türünde), arabanın rengi
        public string renk { get; set; }

        // Kapi sayisi (int türünde), arabanın kaç kapısı olduğunu belirtir
        public int kapiSayisi { get; set; }

        // ToString metodu, arabayı ekrana yazdırırken anlamlı bir formatta çıktı verir
        public override string ToString()
        {
            // Arabayı kullanıcı dostu bir formatta ekrana yazdırır
            return $"Olusturdugunuz Araba Soyle :\n" +
                   $"Uretim Tarihi : {uretimTarihi}\n" +
                   $"Seri Numarasi : {seriNumarasi}\n" +
                   $"Marka : {marka}\n" +
                   $"Model : {model}\n" +
                   $"Renk : {renk}\n" +
                   $"Kapi Sayisi : {kapiSayisi}";
        }
    }
}
