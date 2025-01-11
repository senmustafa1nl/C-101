// Kutuphane namespace'inin kullanılması için using direktifi
using Kutuphane;

// Kitap1 adında bir KitapEkle nesnesi oluşturuluyor
KitapEkle kitap1 = new KitapEkle();

// Kitap1'in özelliklerine değer ataması yapılıyor
kitap1.yazarAd = "";  // Yazar adı boş bırakılıyor
kitap1.sayfaSayisi = 0;  // Sayfa sayısı sıfır olarak atanıyor
kitap1.yayinEvi = "";  // Yayın evi boş bırakılıyor
kitap1.kitapAdi = "";  // Kitap adı boş bırakılıyor

// Kitap1'e ait ekleme işlemi gerçekleştiriliyor (boş değerlerle)
kitap1.EklemeIslemi();

// Kitap2 adında başka bir KitapEkle nesnesi oluşturuluyor
KitapEkle kitap2 = new KitapEkle();

// Kitap2'nin özelliklerine değer ataması yapılıyor
kitap2.yazarAd = "Ayse Kulin";  // Yazar adı Ayşe Kulin olarak belirleniyor
kitap2.sayfaSayisi = 398;  // Sayfa sayısı 398 olarak belirleniyor
kitap2.yayinEvi = "Remzi Kitabevi";  // Yayın evi Remzi Kitabevi olarak belirleniyor
kitap2.kitapAdi = "Adi Aylin";  // Kitap adı "Adi Aylin" olarak belirleniyor

// Kitap2'ye ait ekleme işlemi gerçekleştiriliyor
kitap2.EklemeIslemi();


