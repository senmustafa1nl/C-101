// Kutuphane adında bir namespace tanımlanıyor
namespace Kutuphane{
    
    // KitapEkle sınıfı, kitap bilgilerini tutan ve kitap ekleme işlemini yapan bir sınıftır
    public class KitapEkle{
        
        // Kitap bilgileri için özellikler tanımlanıyor
        public string kitapAdi;  // Kitabın adı
        public string yazarAd;   // Yazarın adı
        public string yazarSoyad; // Yazarın soyadı
        public int sayfaSayisi;   // Kitabın sayfa sayısı
        public string yayinEvi;   // Kitabın yayınevi
        public DateTime kayitTarihi;  // Kitabın kayıt tarihi (henüz kullanılmıyor)

        // Kitap ekleme işlemi gerçekleştiren metot
        public void EklemeIslemi(){
            // Kitap bilgilerini konsola yazdıran bir mesaj
            Console.WriteLine($"{yazarAd} {yazarSoyad} adli yazardan {sayfaSayisi} sayfalik, {yayinEvi} yayin evinden cikan {kitapAdi} kitabini olusturdunuz. ");
        }
    }
}