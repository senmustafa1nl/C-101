namespace Magaza
{
    // BaseMakine sınıfı, tüm makinelerin (telefonlar, bilgisayarlar vb.) ortak özelliklerini ve metodlarını tanımlayan bir sınıftır.
    // Bu sınıf, soyut (abstract) bir sınıf olup, yalnızca diğer sınıflar tarafından türetilerek kullanılabilir.
    public abstract class BaseMakine 
    {
        // Üretim tarihi, makinenin üretildiği tarihi tutan bir DateTime tipinde bir özellik.
        public DateTime uretimTarihi;

        // Seri numarası, makinenin benzersiz kimliğini belirten bir numaradır. Nullable (null olabilir).
        public int? SeriNumarasi;

        // Ad, makinenin adı. Nullable (null olabilir), yani isim verilmemiş olabilir.
        public string? Ad;

        // Açıklama, makine hakkında kısa bir bilgi veya açıklama içerir. Nullable (null olabilir).
        public string? Aciklama;

        // İşletim Sistemi, makinenin kullandığı işletim sistemini belirtir. Nullable (null olabilir).
        public string? IsletimSistemi;

        // BilgileriYazdir metodu, makinenin tüm bilgilerini ekrana yazdırır.
        // Bu metod, BaseMakine sınıfında tanımlanan genel bir metod olup, türetilen sınıflar tarafından geçersiz kılınabilir.
        public virtual void BilgileriYazdir()
        {
            // Tüm özellikler sırasıyla ekrana yazdırılır.
            // Nullable özellikler null olabilir, bu nedenle null değerler yazdırılabilir.
            Console.WriteLine($"{uretimTarihi}\n{SeriNumarasi}\n{Ad}\n{Aciklama}\n{IsletimSistemi}");
        }

        // UrunAdiGetir metodu, her bir türetilen sınıf için farklı bir şekilde uygulanacak şekilde soyut (abstract) olarak tanımlanır.
        // Bu metot, her makinenin adını ekrana yazdırmak için özelleştirilmiş olacaktır.
        public abstract void UrunAdiGetir();
    }
}
