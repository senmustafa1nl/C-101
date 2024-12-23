using System;
					
public class Program
{
	public static void Main()
	{
		//konsola 10 kere Kendime Inaniyorum, Ben Bu yazilim Isini Hallederim Yazdirmqk	
		for (int i=0; i<10 ; i++)
		{
			Console.WriteLine("Kendime Inaniyorum, Ben Bu yazilim Isini Hallederim ");
		}
		//konsola 1-20 arasi sayilari yazdirma
		for (int i = 1; i <= 20; i ++)
		{
		Console.WriteLine(i);
		}
		//1-20 arasindaki cift sayilari komnsola yazdirma
		for (int i =0; i <=20 ; i+=2) 
		{
		Console.WriteLine(i);
		}
		//50-150 arasindaki sayilari konsola yazdirma
		int toplam = 0;
		for (int i=50; i <= 150 ; i++ )
			
		{
		Console.WriteLine(toplam+= i);
		}
		//1-120 arasindaki cift ve tek sayilarin toplamlarini ayri ayri ekrana yazdiracagiz
		int tekToplam = 0;
		int ciftToplam = 0;
		for (int i = 0; i <= 120 ; i++)
		{
		if (i%2==0){
			ciftToplam += i;
		}else{
		tekToplam += i;
		}
		}
		Console.WriteLine("Tek Sayilarin  Toplami" + tekToplam );
		Console.WriteLine("Cift Sayilarin Toplami"+ ciftToplam );
		
		
	}
	
}