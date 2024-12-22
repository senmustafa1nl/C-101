using System;
					
public class Program
{
	public static void Main()
	{
		
		Console.WriteLine("Lutfen Bir Sayi Giriniz :");
		 int Sayi = Convert.ToInt32(Console.ReadLine());
		if  (Sayi >= 10 )
		{
		Console.WriteLine("Girilen Sayi 10'dan Buyuktur. ");
		
		}else if(Sayi <= 10 && Sayi >= 0){
			Console.WriteLine("Girilen Sayi 10'dan Kucuktur.");
	
		}
		else{
			Console.WriteLine("Gecersiz Sayi Girdiniz.");
		}
		if ( Sayi % 2 == 0){
			Console.WriteLine("Girdiginiz Sayi Cifttir.");
	
			
		}else {
			Console.WriteLine("Girdiginiz Sayi Tektir.");
		
		}
	}
}
