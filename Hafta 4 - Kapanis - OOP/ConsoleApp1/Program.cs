using Magaza;  // 'Magaza' adlı namespace'i kullanmak için eklenmiş.



// Programın başlangıcında kullanıcıya hoş geldin mesajı veriliyor.
Console.WriteLine("Patika Teknoloji Atölyesi'ne Hoş geldiniz!");
 void urunOlusturma(){

// Kullanıcıya hangi tür ürün üretmek istediği soruluyor.
Console.WriteLine("Telefon üretmek için ---> 1\nBilgisayar üretmek için ---> 2 yazınız!");

// Kullanıcının girdiği değeri alıyoruz (Telefon veya Bilgisayar).
int kullaniciGirdisi = Convert.ToInt32(Console.ReadLine());

// Eğer kullanıcı 1 girerse, telefon üretme işlemi başlar.
if (kullaniciGirdisi == 1)
{
    // Telefon sınıfından bir nesne oluşturuluyor.
    Telefon telefon = new Telefon();

    // Telefon için gerekli bilgileri kullanıcıdan alıyoruz.
    Console.WriteLine("Telefon Oluşturuldu. Lütfen telefonun adını giriniz!");
    telefon.Ad = Console.ReadLine(); // Telefonun adı kullanıcıdan alınıyor.

    // Telefonun seri numarasını alıyoruz (8 haneli olması bekleniyor).
    Console.WriteLine("Lütfen 8 haneli seri numarası tanımlayınız!");
    telefon.SeriNumarasi = Convert.ToInt32(Console.ReadLine()); // Seri numarası sayıya dönüştürülüp alınıyor.

    // Telefonun üretim tarihi, şu anki tarih olarak atanıyor.
    telefon.uretimTarihi = DateTime.Now;

    // Telefonun kısa açıklamasını alıyoruz.
    Console.WriteLine("Lütfen telefonu kısaca açıklayınız");
    telefon.Aciklama = Console.ReadLine();

    // Telefonun işletim sistemini alıyoruz.
    Console.WriteLine("Lütfen telefonun işletim sistemini giriniz.");
    telefon.IsletimSistemi = Console.ReadLine();

    // Kullanıcıdan telefonun yurt içi kaydını sorgulayan bir giriş alıyoruz.
    Console.WriteLine("Cihaz yurt içi kayıtlı mı? (True/False)");
    telefon.TrLisansVarMi = Convert.ToBoolean(Console.ReadLine()); // Kullanıcıdan Boolean değeri alınır.

    Console.WriteLine(""); // Boş bir satır ekleniyor.

    // Kullanıcının girdiği bilgileri yazdırmak için telefon nesnesinin metodları çağrılıyor.
    telefon.UrunAdiGetir();  // Telefonun adı yazdırılıyor.
    telefon.BilgileriYazdir();  // Telefon bilgileri yazdırılıyor.
}
// Eğer kullanıcı 2 girerse, bilgisayar üretme işlemi başlar.
else if (kullaniciGirdisi == 2)
{
    // Bilgisayar sınıfından bir nesne oluşturuluyor.
    Bilgisayar bilgisayar = new Bilgisayar();

    // Bilgisayar için gerekli bilgileri kullanıcıdan alıyoruz.
    Console.WriteLine("Bilgisayar Oluşturuldu. Lütfen bilgisayarın adını giriniz!");
    bilgisayar.Ad = Console.ReadLine(); // Bilgisayarın adı kullanıcıdan alınıyor.

    // Bilgisayarın seri numarasını alıyoruz (8 haneli olması bekleniyor).
    Console.WriteLine("Lütfen 8 haneli seri numarası tanımlayınız!");
    bilgisayar.SeriNumarasi = Convert.ToInt32(Console.ReadLine()); // Seri numarası sayıya dönüştürülüp alınıyor.

    // Bilgisayarın üretim tarihi, şu anki tarih olarak atanıyor.
    bilgisayar.uretimTarihi = DateTime.Now;

    // Bilgisayarın kısa açıklamasını alıyoruz.
    Console.WriteLine("Lütfen bilgisayarı kısaca açıklayınız");
    bilgisayar.Aciklama = Console.ReadLine();

    // Bilgisayarın işletim sistemini alıyoruz.
    Console.WriteLine("Lütfen bilgisayarın işletim sistemini giriniz.");
    bilgisayar.IsletimSistemi = Console.ReadLine();

    // Bilgisayarın USB giriş sayısını alıyoruz.
    Console.WriteLine("USB giriş sayısı?");
    bilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine()); // USB giriş sayısı kullanıcıdan alınıyor.

    // Bilgisayarın Bluetooth olup olmadığını soruyoruz.
    Console.WriteLine("Bluetooth var mı? (True/False)");
    bilgisayar.BluetoothVarMi = Convert.ToBoolean(Console.ReadLine()); // Bluetooth bilgisi kullanıcıdan alınır.

    Console.WriteLine(""); // Boş bir satır ekleniyor.

    // Kullanıcının girdiği bilgileri yazdırmak için bilgisayar nesnesinin metodları çağrılıyor.
    bilgisayar.UrunAdiGetir();  // Bilgisayarın adı yazdırılıyor.
}
}
urunOlusturma();

Console.WriteLine("Yeni Urun Olusturmak Ister Misiniz ?"); 
string cevap = Console.ReadLine();

if (cevap == "evet"){
    urunOlusturma();
}else{Console.WriteLine("Hoscakalin :)"); 
};
