using Kisi;  // Kisi isim alanını kullanıyoruz, böylece BaseKisi, Ogrenci ve Ogretmen sınıflarına erişebiliriz.

// BaseKisi sınıfından bir nesne oluşturuluyor
BaseKisi kisi1 = new BaseKisi();

// kisi1 nesnesinin Ad ve Soyad özellikleri atanıyor
kisi1.Ad = "Sener";
kisi1.Soyad = "SEN";

// KisiInfo() metodu çağrılarak kişinin bilgileri ekrana yazdırılıyor
kisi1.KisiInfo();  // "Kisi bilgisi : Sener SEN" yazdırır


// Ogrenci sınıfından bir nesne oluşturuluyor
Ogrenci ogrenci1 = new Ogrenci();

// ogrenci1 nesnesinin Ad, Soyad ve OgrenciNumarasi özellikleri atanıyor
ogrenci1.Ad = "Mustafa";
ogrenci1.Soyad = "SEN";
ogrenci1.OgrenciNumarasi = 518;

// KisiInfo() metodu çağrılarak öğrencinin bilgileri ekrana yazdırılıyor
ogrenci1.KisiInfo();  // "Ogrenci bilgisi : Mustafa SEN \nOgrenci numarasi : 518" yazdırır


// Ogretmen sınıfından bir nesne oluşturuluyor
Ogretmen ogretmen1 = new Ogretmen();

// ogretmen1 nesnesinin Ad, Soyad ve MaasBilgisi özellikleri atanıyor
ogretmen1.Ad = "Sertan";
ogretmen1.Soyad = "BOZKUS";
ogretmen1.MaasBilgisi = 100000;

// KisiInfo() metodu çağrılarak öğretmenin bilgileri ekrana yazdırılıyor
ogretmen1.KisiInfo();  // "Ogretmen bilgisi : Sertan BOZKUS\n Ogretmen maasi : 100000" yazdırır
