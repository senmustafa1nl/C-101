namespace patikaflix 
{
    // Ana sınıf: TV şovunu temsil eder
    public class Patikaflix 
    {
        // TV şovunun özellikleri
        public string DizininAdi { get; set; } // Şovun adı
        public int YapimYili { get; set; } // Şovun yapım yılı
        public string Turu { get; set; } // Şovun türü
        public int YayinTarihi { get; set; } // Şovun yayına başlama yılı
        public string Yonetmen { get; set; } // Şovun yönetmeni
        public string Kanal { get; set; } // Şovun yayınlandığı kanal

        // Özellikleri başlatmak için yapıcı metod
        public Patikaflix(string dizininAdi, int yapimYili, string turu, int yayinTarihi, string yonetmen, string kanal) 
        {
            DizininAdi = dizininAdi;
            YapimYili = yapimYili;
            Turu = turu;
            YayinTarihi = yayinTarihi;
            Yonetmen = yonetmen;
            Kanal = kanal;
        }

        // Şovun detaylarını biçimlendirilmiş bir şekilde döndüren metod
        public override string ToString() 
        {
            return $"{DizininAdi} ({YapimYili}) - Tür: {Turu}, Yayınlanmaya Başlama Yılı: {YayinTarihi}, Yönetmen: {Yonetmen}, Kanal: {Kanal}\n-----------------------";
        }
    };

    // Komedi dizileri için sınıf, bazı özellikleri devralıyor
    public class KomediDizileri 
    {
        // Komedi dizisinin özellikleri
        public string DiziAdi { get; set; } // Komedi dizisinin adı
        public string DiziTuru { get; set; } // Komedi dizisinin türü
        public string YonetmenAdi { get; set; } // Komedi dizisinin yönetmeni

        // Komedi dizisi özelliklerini başlatmak için yapıcı metod
        public KomediDizileri(string diziAdi, string diziTuru, string yonetmenAdi) 
        {
            DiziAdi = diziAdi;
            DiziTuru = diziTuru;
            YonetmenAdi = yonetmenAdi;
        }

        // Komedi dizisinin detaylarını biçimlendirilmiş bir şekilde döndüren metod
        public override string ToString() 
        {
            return $" Dizi Adi :{DiziAdi}\n Dizi Turu :{DiziTuru}\n Yonetmen Adi : {YonetmenAdi} \n -------------------------";
        }
    }
}
