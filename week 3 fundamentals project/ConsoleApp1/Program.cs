using System;

class RastgeleSayiOyunu
{
    static void Main()
    {
		//kullanicidan 3 farkli uygulamadan birini secmesini istiyoruz
		
		Console.WriteLine("Hangi programı çalıştırmak istersiniz -:\n1 - Rastgele Sayı Bulma Oyunu\n2 - Hesap Makinesi\n3 - Ortalama Hesaplama");
		Console.WriteLine("Lutfen rakam olarak giriniz");
		int secim = Convert.ToInt32(Console.ReadLine());
		
		
		switch (secim){
			case 1: 
				
				Console.WriteLine("Rastgele Sayı Bulma Oyununa Hoşgeldiniz!");
        Console.WriteLine("1 ile 100 arasında bir sayı seçilecektir.");
        Console.WriteLine("5 tahmin hakkınız var.");

        // Bilgisayarın rastgele bir sayı seçmesi
        Random rnd = new Random();
        int sayi = rnd.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı
        int can = 5;

        while (can > 0)
        {
            Console.Write($"Tahmininizi yapın (Kalan can: {can}): ");
            string input = Console.ReadLine();

            // Kullanıcı geçerli bir sayı girmediğinde tekrar denemesi istenir
            if (!int.TryParse(input, out int tahmin))
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin.");
                continue;
            }

            // Tahmin doğruysa
            if (tahmin == sayi)
            {
                Console.WriteLine("Tebrikler! Doğru tahmini yaptınız.");
                break;
            }
            // Tahmin yanlışsa, kullanıcıya ipucu ver
            else if (tahmin < sayi)
            {
                Console.WriteLine("Daha yüksek bir sayı deneyin.");
            }
            else
            {
                Console.WriteLine("Daha düşük bir sayı deneyin.");
            }

            // Can sayısını azalt
            can--;

            // Can biterse doğru sayıyı göster
            if (can == 0)
            {
                Console.WriteLine($"Maalesef hakkınız bitti! Doğru sayı {sayi} idi.");
                break;
            }
        }
				
				
				break;
			case 2: 
				
        Console.WriteLine("");
        Console.WriteLine("Patika hesap makinasına Hoş Geldiniz!\nİşlem Yapmak İçin Lütfen İki Adet Sayı Giriniz!");
        // sayi girislerimizi yapiyoruz
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        //kullaniciya yaptirmak istedigi islemi soruyoruz
        Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Giriniz!\n'+ , - , * , /'");
        string islem = Console.ReadLine();

        switch (islem)
        {
            case "+":
                Console.WriteLine(sayi1 + sayi2);
                break;
            case "-":
                Console.WriteLine(sayi1 - sayi2);
                break;
            case "*":
                Console.WriteLine(sayi1 * sayi2);
                break;
            case "/":
                if (sayi2 == 0) // Sıfıra bölme kontrolü
                {
                    Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz!");
                }
                
                break;
            default:
                Console.WriteLine("Geçersiz işlem.");
                break;
        }

				
				break;
			case 3: 
				 // Ortalama Hesaplama
        Console.WriteLine("Ortalama Hesaplama");
        Console.WriteLine("Lütfen 3 ders notunuzu giriniz!");
		//kullanicidan ders notlarini aliyoruz
        double not1 = Convert.ToDouble(Console.ReadLine());
        double not2 = Convert.ToDouble(Console.ReadLine());
        double not3 = Convert.ToDouble(Console.ReadLine());

        // Geçerli notlar (0-100 arası)
        if (not1 <= 100 && not1 >= 0 && not2 <= 100 && not2 >= 0 && not3 <= 100 && not3 >= 0)
        {
			//notlarin ortalamasini aliyoruz
            double ortalama = (not1 + not2 + not3) / 3;

            if (ortalama >= 90)
            {
                Console.WriteLine($"{ortalama}: AA");
            }
            else if (ortalama >= 85)
            {
                Console.WriteLine($"{ortalama}: BA");
            }
            else if (ortalama >= 80)
            {
                Console.WriteLine($"{ortalama}: BB");
            }
            else if (ortalama >= 75)
            {
                Console.WriteLine($"{ortalama}: CB");
            }
            else if (ortalama >= 70)
            {
                Console.WriteLine($"{ortalama}: CC");
            }
            else if (ortalama >= 65)
            {
                Console.WriteLine($"{ortalama}: DC");
            }
            else if (ortalama >= 60)
            {
                Console.WriteLine($"{ortalama}: DD");
            }
            else if (ortalama >= 55)
            {
                Console.WriteLine($"{ortalama}: FD");
            }
            else
            {
                Console.WriteLine($"{ortalama}: FF");
            }
        }
        else
        {
            Console.WriteLine("Notlar geçerli değil, lütfen 0 ile 100 arasında değerler giriniz.");
        }
				
				break;
		
		
		
		}
		
		
		
		
        

       
    }
}
