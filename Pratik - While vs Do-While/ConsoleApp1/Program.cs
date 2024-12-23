using System;
					
public class Program
{
	public static void Main()
	{
		//while ile olan kodumuz
		Console.WriteLine("Sana Bir Sey Soylemek Istiyorum. Ogrenmek Icin Lutfen Bir sayi Gir !!");
		int limit = Convert.ToInt32(Console.ReadLine());
		int i = 0 ;
		while ( i <= limit )
		{
			Console.WriteLine("Ben Patika'liyim");
			i++;
		}
		//do-while ile olan kodumuz
		Console.WriteLine("Sana Bir Sey Soylemek Istiyorum. Ogrenmek Icin Lutfen Bir sayi Gir !!");		
		int limit1 = Convert.ToInt32(Console.ReadLine());
		int i1 = 0 ;
		do {
		Console.WriteLine("Ben Patika'liyim");
		i1++;
		
		}while(i1 <= limit1);
		
	}
}