

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using patikaflix ;



class Program {
        static void Main(string[] args)
        
        {
            List<Patikaflix> Mustiflix = new List<Patikaflix>();

            Console.WriteLine("Patikaflix'e Hos Geldiniz!");

            bool devamEt = true;
            Console.WriteLine("Lutfen eklemek istediginiz dizileri giriniz !!!");

            while (devamEt)
            {
                string dizininAdi ;
                Console.WriteLine("Lutfen dizi adini giriniz:");
                dizininAdi = Console.ReadLine().ToString();


                int yapimYili ;
                Console.WriteLine("Lutfen yapim yilini giriniz:");
                while (!int.TryParse(Console.ReadLine(), out yapimYili))
                {
                    Console.WriteLine("Lutfen gecerli bir deger giriniz !!!");
                }
                string turu ;
                Console.WriteLine("Lutfen turunu giriniz:");
                turu = Console.ReadLine().ToString();

                Console.WriteLine("Lutfen yayinlanmaya baslama yilinni giriniz:");
                int yayinTarihi;
                while (!int.TryParse(Console.ReadLine(), out yayinTarihi))
                {
                    Console.WriteLine("Lutfen gecerli bir deger giriniz !!!");
                }
                string yonetmen;
                Console.WriteLine("Lutfen yonetmenin adini ve soyadini giriniz:");
                yonetmen = Console.ReadLine().ToString();


                string kanal; 
                Console.WriteLine("Yayinlandigi ilk platform/kanal:");
                kanal = Console.ReadLine().ToString();

                // Yeni bir Patikaflix nesnesi oluşturuluyor
                Patikaflix yeniDizi = new Patikaflix (dizininAdi, yapimYili, turu, yayinTarihi, yonetmen, kanal);
                Mustiflix.Add(yeniDizi); // Listeye ekleniyor

                Console.WriteLine("Yeni bir dizi eklemek ister misiniz? Evet/Hayir:");
                string cevap = Console.ReadLine().ToLower();

                if (cevap != "evet")
                {
                    devamEt = false;
                }
            }

            // Listeye eleman eklenip eklenmediğini kontrol edelim
            Console.WriteLine("\nMustiflix listesinde toplam {0} dizi var.", Mustiflix.Count);

            // Eğer liste boş değilse, dizileri yazdırıyoruz
            if (Mustiflix.Count > 0)
            {
                Console.WriteLine("\nEklenen Diziler:");
                foreach (var dizi in Mustiflix)
                {
                    Console.WriteLine(dizi); // ToString() metodu otomatik olarak çağrılır
                }
            }
            else
            {
                Console.WriteLine("Hiç dizi eklenmedi.");
            }

            List<KomediDizileri> komedi = Mustiflix
                                        .Where(k => k.Turu.ToLower() == "komedi")
                                        .Select(k => new KomediDizileri (k.DizininAdi , k.Turu , k.Yonetmen))
                                        .ToList();

            var komediler = komedi 
                            .OrderBy (s => s.DiziAdi)
                            .ThenBy(s => s.YonetmenAdi)
                            .ToList();

            foreach (var x in komediler){
                    Console.WriteLine(x);

            }
            



















        }
}