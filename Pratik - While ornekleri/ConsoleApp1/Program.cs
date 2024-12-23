using System;
					
public class Program
{
	public static void Main()
	{
		//Pratik While Ornekleri
		//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
		int i = 0;
		while (i <= 10)
		{
			Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
			i ++ ;
		}
		//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
		int sayi2 = 1;
		while (sayi2 <= 20)
		{
		Console.WriteLine(sayi2);
			sayi2 ++ ;
		}
		//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
		int sayi3 = 1;
		while (sayi3 <=20)
		{
		if (sayi3 % 2 == 0)
		{
			Console.WriteLine(sayi3);
			sayi3 ++ ;
		}else {
		sayi3 ++ ;
		}
		}
		//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız
		int sayi4 = 50;
		int toplam = 0;
		while (sayi4 <= 150)
		{
			toplam += sayi4;
			sayi4 ++ ;
		}
		Console.WriteLine(toplam);
		
		//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
		int tekSayi = 0;
		int ciftSayi = 0;
		int sayi5 = 1;
		while (sayi5 <= 120)
		{
		if (sayi5 %2 == 0)
		{
			ciftSayi += sayi5;
			sayi5 ++ ;
		}else 
		{
		tekSayi += sayi5;
			sayi5 ++ ;
		}
		}
	
		Console.WriteLine($"Tek Sayilarin Toplami {tekSayi} ") ;
		Console.WriteLine($"Cift Sayilarin Toplami {ciftSayi}");

	}
}