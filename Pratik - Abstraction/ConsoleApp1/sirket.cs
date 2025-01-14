namespace Sirket  // Sirket ad alanını başlatıyoruz, bu alan içerisinde tüm sınıflarımız bulunacak.
{
    // Calisan sınıfı, bir çalışanın temel özelliklerini ve işlevlerini tanımlar.
    // Bu sınıf abstract olduğundan doğrudan örneği oluşturulamaz, sadece türemiş sınıflar kullanılır.
    public abstract class Calisan
    {
        // Çalışanın adı
        public string Ad;

        // Çalışanın soyadı
        public string Soyad;

        // Çalışanın departmanı
        public string Departman;

        // Çalışanın genel bilgilerini ekrana yazdıran metot
        public void CalisanInfo()
        {
            // Çalışanın adı, soyadı ve departmanını ekrana yazdırıyoruz
            Console.WriteLine($"{Ad} {Soyad} sirketin {Departman} departmaninda calismaktadir");
        }

        // Çalışanın görevini belirleyen soyut metot (her alt sınıf bu metodu implement etmelidir)
        public abstract void Gorev();
    }

    // YazilimGelistirici sınıfı, Calisan sınıfından türetilmiştir ve yazılım geliştiricisini temsil eder.
    public class YazilimGelistirici : Calisan
    {
        // Yazılım geliştiricisinin görevini tanımlayan metot
        public override void Gorev()
        {
            // Yazılım geliştiricisinin ne iş yaptığını belirten mesajı ekrana yazdırıyoruz
            Console.WriteLine("Yazilim gelistrici olarak calisiyorum.");
        }
    }

    // ProjeYonetici sınıfı, Calisan sınıfından türetilmiştir ve proje yöneticisini temsil eder.
    public class ProjeYonetici : Calisan
    {
        // Proje yöneticisinin görevini tanımlayan metot
        public override void Gorev()
        {
            // Proje yöneticisinin ne iş yaptığını belirten mesajı ekrana yazdırıyoruz
            Console.WriteLine("Proje yoneticisi olarak calisıyorum.");
        }
    }

    // SatisTemsilcisi sınıfı, Calisan sınıfından türetilmiştir ve satış temsilcisini temsil eder.
    public class SatisTemsilcisi : Calisan
    {
        // Satış temsilcisinin görevini tanımlayan metot
        public override void Gorev()
        {
            // Satış temsilcisinin ne iş yaptığını belirten mesajı ekrana yazdırıyoruz
            Console.WriteLine("Satis Temsilcisi olarak calisiyorum.");
        }
    }
}
