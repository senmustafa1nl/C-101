using System;
					
public class Program
{
	public static void Main()
	{
		
/* 1-Geriye Değer Döndürmeyen Bir void metot.

Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 

2-Geriye Tamsayı Döndüren Bir metot

Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

3- Parametre Alan ve Geriye Değer Döndüren Bir Metot

Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

4-Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.*/
		
		//1 
		//ajax isminde donguyu cagiriyoruz
		void ajax()
		{
			//ajax amsterdam marsini  ekrana yazacagi sekilde kodluyoruz
		Console.WriteLine("90 minuten lang, \nVoor onze club uit Amsterdam,\nGekkehuis op de tribune,\nNiemand die ons stoppen kan...");
		}
		//donguyu cagiriyoruz
		ajax();
		
		
		Console.WriteLine("-------------------------------------------");
		
		//2
		 int modAlma()
		{
			 //random bir sayi tanimlamak icin random methodunu kullaniyoruz
		Random rnd = new Random(); 
			 /*random sayi adinda yeni bir degisken tanimlayip next methoduyla uretilen 0-250
			 arasindaki sayiyi icine atiyoruz */
        int randomSayi = rnd.Next(0 , 250);  
        Console.WriteLine("Üretilen Sayı: " + randomSayi);  
        return randomSayi % 2;  	
		}
		//yukarida random sayi uretip degeri hafizada tuttuk ve asagida deger tutmayan void kullanarak domnguyu cagiriyoruz
		 void ekranCiktisi()
    {
       
        int cikti = modAlma();
        Console.WriteLine("2'ye bölümünden kalan: " + cikti);
    }
	     ekranCiktisi();
		
		Console.WriteLine("--------------------------------------------");
		//3
		
		// dongumuzu tanimliyoruz
		int sayiCarpim(int x, int y) {
			//dongunun icinde elde etmek istedigimiz carpma islemini sum degiskenine nasil islem yapmasi gerektigini belirterek atiyoruz
			int sum = x * y ;
			//console verecegimiz ciktiyi tanimliyoruz
			Console.WriteLine($"Girdiginiz sayilarin carpimi = {sum} ");
			// sum degiskenimizi dongunun basinda girilen degerlerle donduruyoruz
			return sum ;
		
		}
		// donguyu calistiriken manuel olarak iki sayi girip donguyu calistiriyoruz
		sayiCarpim(50,100) ; 
		
		Console.WriteLine("----------------------------------------------");
		//4
		// adSoyad isminde bir dongu tanimliyoruz
		void adSoyad (string ad , string Soyad)
		{
			//dongunun icinde yapacagi islemi belirtiyoruz
			Console.WriteLine($"Hosgeldiniz {ad} {Soyad} ");
			
		}
		//donguyu cagiriyoruz
		
		adSoyad("Sertan","BOZKUS");
		
		
		
		
		
	}
	
}