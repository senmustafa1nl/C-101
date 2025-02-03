using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
namespace muzify;

class program {

static void Main(){

   List<muzikListesi> spotify = new List<muzikListesi>
            {
                new muzikListesi("Ajda Pekkan", "Pop", 1968 , 20000000),
                new muzikListesi("Sezen Aksu" , "Türk Halk Müziği/Pop" , 1971, 10000000),
                new muzikListesi("Funda Arar", "Pop", 1999, 300000),
                new muzikListesi("Sertab Erener", "Pop", 1994, 1000000),
                new muzikListesi("Sıla", "Pop", 2009, 3000000),
                new muzikListesi("Serdar Ortaç", "Pop", 1994, 10000000),
                new muzikListesi("Tarkan", "Pop", 1992, 40000000),
                new muzikListesi("Hande Yener", "Pop", 1999, 7000000),
                new muzikListesi("Hadise", "Pop", 2005, 5000000),
                new muzikListesi("Gülben Ergen", "Türk Halk Müziği/Pop", 1997, 10000000),
                new muzikListesi("Neşet Ertaş", "Türk Halk Müziği/Türk Sanat Müziği", 1960, 20000000),
            };

            // 1. Adı 'S' ile başlayan şarkıcıları filtrelemek
            var sIleBaslayan = spotify.Where(s => s.SarkiciAdi.StartsWith("S")).ToList();

            // 'S' ile başlayan şarkıcıları ekrana yazdırıyoruz
            foreach (var artist in sIleBaslayan)
            {
                Console.WriteLine(artist.SarkiciAdi);  // Şarkıcının adını yazdır
            }

            Console.WriteLine("---------------------------");

            // 2. 10 milyon satıştan fazla albümü olan şarkıcıları filtrelemek
            var satis = spotify.Where(x => x.AlbumSatislari > 10000000);

            // Satışları yüksek olan şarkıcıları ekrana yazdırıyoruz
            foreach (var i in satis)
            {
                Console.WriteLine(i.SarkiciAdi);  // Şarkıcının adını yazdır
            }

            Console.WriteLine("---------------------------");

            // 3. 2000'den önce pop müzik türünde çıkan sanatçıları sıralamak ve gruplayarak yazdırmak
            var popSanatcisi = spotify.Where(sanatci => sanatci.CikisYili < 2000 && sanatci.MuzikTuru.Contains("Pop"))
                                      .OrderBy(sanatci => sanatci.SarkiciAdi)  // Şarkıcı adıyla sıralama
                                      .GroupBy(sanatci => sanatci.CikisYili); // Çıkış yılına göre gruplayarak yazdırmak

            // Grupları ve içindeki sanatçıları ekrana yazdırıyoruz
            foreach (var grup in popSanatcisi)
            {
                // Her grup için şarkıcıların bilgilerini yazdırıyoruz
                foreach (var artis in grup)
                {
                    Console.WriteLine($"{artis.SarkiciAdi} - {artis.CikisYili}"); // Şarkıcı adı ve çıkış yılı
                }
            }

            Console.WriteLine("---------------------------");

            // 4. En çok albüm satan şarkıcıyı buluyoruz
            var enCokSatis = spotify.OrderBy(satis => satis.AlbumSatislari).Last();  // En büyük satışa sahip olanı alıyoruz

            // En çok satan şarkıcının ismini ve satış sayısını yazdırıyoruz
            Console.WriteLine($"{enCokSatis.SarkiciAdi} - {enCokSatis.AlbumSatislari}");

            Console.WriteLine("---------------------------");

            // 5. En yeni şarkıcıyı (en son çıkan) buluyoruz
            var enYeniSarkici = spotify.OrderBy(artis => artis.CikisYili).Last();  // Son çıkan şarkıcı

            // En yeni şarkıcının adını ve çıkış yılını yazdırıyoruz
            Console.WriteLine($"{enYeniSarkici.SarkiciAdi} - {enYeniSarkici.CikisYili}");

            Console.WriteLine("---------------------------");

            // 6. En eski şarkıcıyı (ilk çıkan) buluyoruz
            var enEskiSarkici = spotify.OrderBy(artis => artis.CikisYili).First();  // İlk çıkan şarkıcı

            // En eski şarkıcının adını ve çıkış yılını yazdırıyoruz
            Console.WriteLine($"{enEskiSarkici.SarkiciAdi} - {enEskiSarkici.CikisYili}");
        }
    }

    
