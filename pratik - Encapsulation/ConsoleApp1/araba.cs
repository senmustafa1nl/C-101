using System;

namespace encapsulation_pratik4
{
    // Araba sınıfı, araba nesnelerinin özelliklerini ve davranışlarını temsil eder.
    public class Araba
    {
        // _kapiSayisi, private olarak tanımlanmış, dışarıdan erişilemez.
        private int _kapiSayisi;

        // KapiSayisi özelliği, kapiSayisi değişkenine dışarıdan erişimi sağlar.
        public int KapiSayisi
        {
            get
            {
                // KapiSayisi özelliği çağrıldığında, private _kapiSayisi değerini döner.
                return _kapiSayisi;
            }
            set
            {
                // Eğer girilen kapı sayısı 2 veya 4 değilse, hatalı bir giriş olduğunu belirtir.
                if (value != 2 && value != 4)
                {
                    // Kullanıcıyı uyarır ve kapiSayisi'ni -1 olarak ayarlar.
                    Console.WriteLine("Girilen değerde bir kapı sayısı yoktur. Yanlış girdi.");
                    _kapiSayisi = -1;  // Geçersiz bir değer girildiğinde, kapı sayısını -1 yapıyoruz.
                }
                else
                {
                    // Geçerli bir kapı sayısı girildiğinde, _kapiSayisi'ni bu değere ayarlıyoruz.
                    _kapiSayisi = value;
                }
            }
        }

        // Model, marka ve renk gibi araba bilgilerini saklamak için public özellikler.
        public string Model { get; set; }  // Arabanın modeli.
        public string Marka { get; set; }  // Arabanın markası.
        public string Renk { get; set; }  // Arabanın rengi.

        // Parametresiz yapıcı metot: Varsayılan değerler ile bir araba nesnesi oluşturur.
        public Araba()
        {
            KapiSayisi = 4;  // Varsayılan olarak, 4 kapı değeri atanır.
        }

        // Parametreli yapıcı metot: Kullanıcı tarafından verilen bilgilerle bir araba nesnesi oluşturur.
        public Araba(string model, string marka, string renk, int kapiSayisi)
        {
            Model = model;     // Model özelliği, parametre olarak verilen model ile ayarlanır.
            Marka = marka;     // Marka özelliği, parametre olarak verilen marka ile ayarlanır.
            Renk = renk;       // Renk özelliği, parametre olarak verilen renk ile ayarlanır.
            KapiSayisi = kapiSayisi;  // KapiSayisi özelliği, parametre olarak verilen kapı sayısı ile ayarlanır.
        }

        // Arabayı tanıtan bir metot: Arabaya ait bilgileri ekrana yazdırır.
        public void ArabayiTanit()
        {
            // Araba modelini, markasını ve rengini konsola yazdırır.
            Console.WriteLine($"{Model} model arabanın markası {Marka}, rengi {Renk}");
        }

        // KapiSayisiniSoyle metodu, aracın geçerli kapı sayısını ekrana yazdırır.
        public void KapiSayisiniSoyle()
        {
            // Eğer kapiSayisi -1 değilse, yani geçerli bir kapı sayısı varsa, kapı sayısını yazdırır.
            if (_kapiSayisi != -1)
                Console.WriteLine($"Kapı Sayısı: {_kapiSayisi}");
             
        }
    }
}
