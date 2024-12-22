using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Lutfen Asagidaki Bilgileri Giriniz : ");
		Console.WriteLine("TC Kimlik Numarasi :" );
		string tckn = Console.ReadLine();
		Console.WriteLine("Adi :");
		string ad = Console.ReadLine();
		Console.WriteLine("Soyadi :" ) ;
		string soyadi= Console.ReadLine();
		Console.WriteLine("Yas :");
		string yas = Console.ReadLine();
			Console.WriteLine("Telefon Numaraniz :");
		string telno=Console.ReadLine();
		Console.WriteLine("--------------------------------------------------------------------");
		Console.WriteLine($"{tckn} TC Numarali {ad} {soyadi} isimli kisi icin kayit olusturulmustur. ");
		Console.WriteLine($"{telno} Telefon numarasina bildirim mesaji gonderilmistir.");

		
		
		
		
		
			
	}
}