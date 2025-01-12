using System;
					
public class Program
{
	public static void Main()
	{
		
/*1 - Aşağıdaki çıktıyı yazan bir program.

Merhaba
Nasılsın ?
İyiyim
Sen nasılsın ?*/
		
		
		string sohbet = "Merhaba, Nasilsin ?, Iyiyim, Sen nasilsin ?";
		string[] konusma = sohbet.Split(", ");
		
		foreach(string kelimeler in konusma)
		{
		Console.WriteLine(kelimeler);
		}
		
		Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");


/*2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.*/
		string text = "Patika";
		int sayi = 13 ;
		Console.WriteLine( text);
		Console.WriteLine(sayi);
       

 Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*3 - Rastgele bir sayı üretip , ekrana yazdırınız.*/
       
		Random rnd = new Random();
		int randomSayi = rnd.Next(0,100);
		   Console.WriteLine($"Uretilen Sayi {randomSayi}");
		
			
	  	

Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.*/

   int modAlma()
  {
    Random rnd1 = new Random();
		int randomSayi1 = rnd1.Next(0,99);
	  Console.WriteLine($"Uretilen Sayi {randomSayi1}");
	  return randomSayi1 % 3;
		
  
  }
		void ekranCiktisi()
		{
		int cikti = modAlma();
			Console.WriteLine($"Sayinin 3'e bolumunden kalan {cikti}");
		}
		 ekranCiktisi();
Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.*/
	Console.WriteLine("Patika Bar'a Hos Geldiniz !\nLutfen Yasinizi Giriniz !");
		int yas = int.Parse(Console.ReadLine());
		if(yas < 18)
		{
		Console.WriteLine("Yasiniz Giris Icin Uygun Degil !");
		
		}else
		{
		Console.WriteLine("Hos Gelsiniz !") ;
		}
Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.*/
		for (int i=1 ; i<=10 ; i++)
		{
		Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
		
		}

Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.*/
		
		Console.WriteLine("Benim Isim Hafizam Cok Kotu ve Isimleri Hep Karistiririm.");
		Console.WriteLine("Iki isim Giriniz !\nDemet Evgar veya Gulse Birsel");
		Console.WriteLine("Ilk Ismi Giriniz");
		string isim1 = Console.ReadLine();
		Console.WriteLine("Ikinci Ismi Giriniz!\nDemet Evgar veya Gulse Birsel");
		string isim2 = Console.ReadLine();
		
		Console.WriteLine("SImdi Isimleri Hatirlamaya Calisacagim :)");
		Console.WriteLine($"Ilk Isim {isim2}");
		Console.WriteLine($"Ikinci Isim {isim1}");
		
		

Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.*/
		
	void degersiz()
		{
		Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
		}
		degersiz();
		

Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.*/
		static int toplam(int sayi1 , int sayi2)
		{
		return sayi1+sayi2 ;
		}
  void summary () {
 
 		Console.WriteLine("Birinci sayiyi Giriniz");
	 	int sayi1 = Convert.ToInt32(Console.ReadLine());
	 	Console.WriteLine("ikinci sayiyi Giriniz");
	 	int sayi2 = Convert.ToInt32(Console.ReadLine());
	 	int toplama = toplam(sayi1, sayi2);
	 	Console.WriteLine($"Toplamanin sonucu : {toplama}");
	 
 
 }	
		summary();
		Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

	}
		

/*10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.*/
		
		public void anahtar(){
			Console.WriteLine("Kapiyi acmak ister misin ?");
			Console.WriteLine("Lutfen cevabi 'true' yada 'false' olarak yaziniz ...");
			bool cevap = Convert.ToBoolean(Console.ReadLine());
			if (cevap == true ){
				Console.WriteLine("Kapi aciliyor");}
				else{
				Console.WriteLine("Kapi kapali kalmaya devam edecek");
				}
		
	

		
		Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/* 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.*/

		
			using System;

class Program
{
    // En yaşlı kişinin yaşını döndüren metot
    static int EnYasli(int yas1, int yas2, int yas3)
    {
        // En büyük yaşı bulmak için Math.Max metodu kullanılır
        return Math.Max(Math.Max(yas1, yas2), yas3);
    }

    static void Main(string[] args)
    {
        // Kullanıcıdan 3 kişinin yaşlarını alıyoruz
        Console.Write("1. kişinin yaşını girin: ");
        int yas1 = int.Parse(Console.ReadLine());

        Console.Write("2. kişinin yaşını girin: ");
        int yas2 = int.Parse(Console.ReadLine());

        Console.Write("3. kişinin yaşını girin: ");
        int yas3 = int.Parse(Console.ReadLine());

        // En yaşlıyı bulmak için metodu çağırıyoruz
        int enYasli = EnYasli(yas1, yas2, yas3);

        // Sonucu ekrana yazdırıyoruz
        Console.WriteLine($"En yaşlı kişinin yaşı: {enYasli}");
    }
}

		Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");



/*12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.*/


Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.*/


Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.*/


Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.*/
		

Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.*/
	 static double formulAlan(double pi , double r )
	 {
		
	 return pi * (r*r);
	 }

		void daireAlan()
		{
		Console.WriteLine("Dairenin Alanini Hesaplamak Icin Lutfen Yari Capini Giriniz !");
			double pi = 3.14 ;
			double r = Convert.ToDouble(Console.ReadLine());
			double alan2 = formulAlan(pi , r);
			Console.WriteLine($"Dairenizin Alani{alan2} ");
			
		
		
		}
			daireAlan();
Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.*/
		string soz = "Zaman bir GeRi SayIm";
		string upperCaseText = soz.ToUpper();
		string lowerCaseText = soz.ToLower();
		Console.WriteLine(upperCaseText);
		Console.WriteLine(lowerCaseText);
		
Console.WriteLine("--------------------------------");
		Console.WriteLine("--------------------------------");

/*18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.*/
		string greets = "    Selamlar   ";
		string trimmedText = greets.Trim();
		Console.WriteLine(trimmedText);
		
	}
}