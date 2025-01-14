using Sirket;  // 'Sirket' ad alanını içeri aktarıyoruz. Bu ad alanı, çalışan sınıflarını içeriyor.

// YazilimGelistirici (Yazılım Geliştirici) sınıfının bir örneğini oluşturuyoruz
YazilimGelistirici yazilimci = new YazilimGelistirici();

// 'YazilimGelistirici' nesnesinin özelliklerini (Ad, Soyad, Departman) atıyoruz
yazilimci.Ad = "Mustafa";
yazilimci.Soyad = "SEN";
yazilimci.Departman = "Yazilim";

// 'YazilimGelistirici' çalışanının genel bilgilerini yazdıran CalisanInfo() metodunu çağırıyoruz
yazilimci.CalisanInfo();

// 'YazilimGelistirici' çalışanının görevini yazdıran Gorev() metodunu çağırıyoruz
yazilimci.Gorev();

Console.WriteLine("----------------------");  // Konsol çıktısında daha iyi bir ayrım için ayraç ekliyoruz

// ProjeYonetici (Proje Yöneticisi) sınıfının bir örneğini oluşturuyoruz
ProjeYonetici projeci = new ProjeYonetici();

// 'ProjeYonetici' nesnesinin özelliklerini (Ad, Soyad, Departman) atıyoruz
projeci.Ad = "Ahmet";
projeci.Soyad = "MUTLU";
projeci.Departman = "Proje Gelistirme";

// 'ProjeYonetici' çalışanının genel bilgilerini yazdıran CalisanInfo() metodunu çağırıyoruz
projeci.CalisanInfo();

// 'ProjeYonetici' çalışanının görevini yazdıran Gorev() metodunu çağırıyoruz
projeci.Gorev();

Console.WriteLine("----------------------");  // Konsol çıktısında daha iyi bir ayrım için ayraç ekliyoruz

// SatisTemsilcisi (Satış Temsilcisi) sınıfının bir örneğini oluşturuyoruz
SatisTemsilcisi satisci = new SatisTemsilcisi();

// 'SatisTemsilcisi' nesnesinin özelliklerini (Ad, Soyad, Departman) atıyoruz
satisci.Ad = "Zeynep";
satisci.Soyad = "SAHBAZ";
satisci.Departman = "Satis";

// 'SatisTemsilcisi' çalışanının genel bilgilerini yazdıran CalisanInfo() metodunu çağırıyoruz
satisci.CalisanInfo();

// 'SatisTemsilcisi' çalışanının görevini yazdıran Gorev() metodunu çağırıyoruz
satisci.Gorev();
