using System;

// Davetlilerin isimlerini tutacak bir liste oluşturuluyor
List<string> davetliler = new List<string>();

// Listeye davetli isimleri ekleniyor
davetliler.Add("Bulent Ersoy");
davetliler.Add("Ajda Pekkan");
davetliler.Add("Ebru Gundes");
davetliler.Add("Hadise");
davetliler.Add("Hande Yener");
davetliler.Add("Tarkan");
davetliler.Add("Funda Arar");
davetliler.Add("Demet Akalin");

// Davetli bilgilerini ekrana yazdırmak için fonksiyon oluşturuluyor
void davetliInfo(){
    // Başlangıçta davetli numarasını 1 olarak belirliyoruz
    int davetliNumarasi = 1;

    // Listeyi dolaşarak davetli numarası ile isimlerini yazdırıyoruz
    foreach (string i in davetliler){
        // Davetli numarasını ve ismini ekrana yazdırıyoruz
        Console.WriteLine(davetliNumarasi + " -  " + i );
        // Sonraki davetli numarasını artırıyoruz
        davetliNumarasi++;
    }
}

// İlk olarak mevcut davetlileri yazdırıyoruz
davetliInfo();

// Kullanıcıya yeni davetli eklemek isteyip istemediğini soruyoruz
Console.WriteLine("----------------------------");

// Yeni davetli eklemek için kullanıcıdan cevap alıyoruz
eklemeSOrgusu: 
Console.WriteLine("Baska davetli eklemek ister misiniz ?  Evet/Hayir");
string cevap = Console.ReadLine().ToLower();  // Kullanıcıdan "evet" ya da "hayir" cevabını alıyoruz

// Kullanıcı "evet" derse yeni davetli ekliyoruz
if (cevap == "evet"){
    // Yeni davetlinin ismini kullanıcıdan alıyoruz
    Console.WriteLine("Lutfen davetlinin adini ve soyadini giriniz ?");
    string yeniDavetli = Console.ReadLine();  // Kullanıcıdan yeni davetli ismi alınıyor
    davetliler.Add(yeniDavetli);  // Yeni davetli listeye ekleniyor
    davetliInfo();  // Güncellenmiş listeyi yazdırıyoruz
    // Kullanıcıya tekrar sorulmak üzere goto komutuyla döngüye dönüyoruz
    goto eklemeSOrgusu;
}
// Kullanıcı "hayir" derse program sonlanıyor
else if (cevap == "hayir") {
    Console.WriteLine("Iyi eglenceler");  // Eğlenceli bir veda mesajı
}
// Eğer kullanıcı geçersiz bir giriş yaparsa hata mesajı veriyoruz ve tekrar soruluyor
else{
    Console.WriteLine("Hatali bir giris yaptiniz !");  // Geçersiz giriş mesajı
    goto eklemeSOrgusu;  // Tekrar sorulacak
}
