using Kisi;  // Kisi isim alanını kullanıyoruz, böylece BaseKisi sınıfına erişebiliyoruz.

// Ogrenci sınıfı, BaseKisi sınıfından türetilmiştir ve öğrencilere özgü özellikler ekler.
public class Ogrenci : BaseKisi
{
    // OgrenciNumarasi, öğrencinin numarasını saklamak için kullanılan özelliktir.
    public int OgrenciNumarasi { get; set; }  // Öğrencinin numarasını tutar.

    // KisiInfo() metodu, BaseKisi sınıfında tanımlı olan metodu geçersiz kılar (override).
    // Bu metot, öğrencinin bilgilerini ekrana yazdırmak için kullanılır.
    public override void KisiInfo()
    {
        // Öğrencinin adı, soyadı ve öğrenci numarasını ekrana yazdırır.
        Console.WriteLine($"Ogrenci bilgisi : {Ad} {Soyad} \nOgrenci numarasi : {OgrenciNumarasi}");
    }
}
