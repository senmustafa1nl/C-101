using System;
					
public class Program
{
	public static void Main()
	{
	



        Console.WriteLine ("Patika Turizm'e Hos Geldiniz ! Lutfen Gitmek Istediginiz Destinasyonu seciniz !!");
       	Console.WriteLine("Lutfen Adinizi ve Soyadinizi Giriniz !") ;
		string adSoyad =Console.ReadLine() ;
		Console.WriteLine("Paketlerimiz Su Sekildedir :\n 1- Bodrum (Paket baslangic fiyati 4000 TL) \n 2- Marmaris (Paket baslangic fiyati 3000TL) \n 3- Cesme (Paket baslangic fiyati 5000 TL) ");
		//istenilen lokasyonu kullanicidan aliyoruz .
		Console.WriteLine("Lutfen gitmek istediginiz destinasyonu YAZARAK Belirtiniz ");
		string istenilenLokasyon = Console.ReadLine().ToLower() ;
		int fiyat = 0 ;
		//lokasyon girdisine gore fiyat degiskenini switch-case metodu kullanarak guncelliyoruz
		switch(istenilenLokasyon)
		{
			case "bodrum" :
				fiyat += 4000 ;
				break ;
				
			case "marmaris" :
				fiyat += 3000 ;
				break;
			case "cesme" :
				fiyat += 5000;
					break;
				default : Console.WriteLine("Hatali bir giris yaptiniz !!!") ;
				break ; 
		}
		//eger lokasyon girdisi alindiysa fiyat guncellenecektir ve 0'dan buyuk olacaktir . bu nedenle ziyaretci sayisini sorabiliyoruz
		
		if (fiyat > 0 ){
		Console.WriteLine("Ziyaretci Sayisini Girin Lutfen !") ;
			//ziyaretci sayisini kullanicidan aliyoruz 
		int ziyaretciSayisi =Convert.ToInt32(Console.ReadLine());
		int ziyaretciliFiyat = fiyat * ziyaretciSayisi ;
			Console.WriteLine($"{istenilenLokasyon} tatili icin {ziyaretciSayisi} kisilik rezervasyon {adSoyad} adina yapilmistir.\n Konaklamanizda 7 gunluk hersey dahil otel hizmetinden faydalanabileceksiniz.\n ");
			Console.WriteLine("Ulasiminizi Nasil Saglamak Istersiniz ?\n 1-> Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\n 2 -> Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\n Lutfen Rakam Olarak Giriniz !");
			//ulasim seklini kullanicidan alip fiyati guncelliyoruz
			int ulasim = Convert.ToInt32(Console.ReadLine());
			if (ulasim == 1){
			fiyat = ziyaretciSayisi * (fiyat + 1500);
			
			}else if (ulasim == 2){
			
			fiyat = ziyaretciSayisi * (fiyat + 4000) ;
			
			
			} else {
				
				Console.WriteLine("Yanlis bir rakam girdiniz !") ;
			}
			
		}
		// enson kullaniciya girdigi bilgiler dogrultusunda fiyat verip musteri temsilcisine aktariyoruz
		Console.WriteLine($"Patika Turizm'i sectiginiz icin Iyi Tatiller Diler ve Tesekkur Ederiz!\n Toplam Fiyat {fiyat} TL\n Odeme icin Lutfen Musteri temsilcimiz ile iletisime geciniz!  ");
		
		
		
		
		
		
    }
}

	
