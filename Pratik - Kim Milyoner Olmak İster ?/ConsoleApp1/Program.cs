using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Kim Milyoner Olmak Ister Yarismasina Hos Geldiniz!!");
	
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("1 -> Kizinca Tukuren Hayvan Hangisidir ?");
		Console.WriteLine("");
		Console.WriteLine("a) Lama       b) Deve");
		string cevap1 = "a";
		string verilenCevap1 = Console.ReadLine();
		verilenCevap1.ToLower();
		if (cevap1 == verilenCevap1) {
		Console.WriteLine("Tebrikler Dogru Cevap :) !!!");
		}
		else{
		Console.WriteLine("Uzgunum , Yanlis Cevap :( !!!");
		}
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ? ");
		Console.WriteLine("");
		Console.WriteLine("a) Venüs      b) Mars");
		string cevap2 = "a";
		string verilenCevap2 = Console.ReadLine();
		verilenCevap2.ToLower();
		if (cevap2 == verilenCevap2) {
		Console.WriteLine("Tebrikler Dogru Cevap :) !!!");
		}
		else{
		Console.WriteLine("Uzgunum , Yanlis Cevap :( !!!");
		}
		if(cevap1 != verilenCevap1 && cevap2 != verilenCevap2 ){
			Console.WriteLine("Uzgunum 3. Soruyu Soramam. Yarismayi Kaybettin :( !!!");
		}else{
		
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? ");
		Console.WriteLine("");
		Console.WriteLine("a)7           b)12");
		string cevap3 = "b";
		string verilenCevap3 = Console.ReadLine();
		verilenCevap3.ToLower();
		if (cevap3 == verilenCevap3) {
		Console.WriteLine("Tebrikler Dogru Cevap :) !!!");
			if(cevap1 == verilenCevap1 && cevap2 == verilenCevap2 && cevap3 == verilenCevap3){
			Console.WriteLine("Tebrikler Milyonersiniz . Buyuk Odulu Kazandiniz !!!");
		
		
		}else{
		Console.WriteLine("Teselli Ikramiyesini Kazandiniz");
		}
		}
		else{
		Console.WriteLine("Uzgunum , Yanlis Cevap :( !!!");
			Console.WriteLine("Teselli Ikramiyesini Kazandiniz");
		}
			
		
		
		}
		
		
		
		
		
		
	}
}