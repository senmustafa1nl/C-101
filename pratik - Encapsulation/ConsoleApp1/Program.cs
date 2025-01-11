using encapsulation_pratik4;  // encapsulation_pratik4 isim alanını kullanarak Araba sınıfına erişiyoruz.

class Program
{
    static void Main(string[] args)
    {
        // Parametreli yapıcıyı kullanarak araba1 nesnesi oluşturuluyor.
        // Bu araba "Ford" markasında, "Focus" modelinde, "Mavi" renkte ve 4 kapı ile tanımlanıyor.
        Araba araba1 = new Araba("Ford", "Focus", "Mavi", 4);

        // Parametreli yapıcıyı kullanarak araba2 nesnesi oluşturuluyor.
        // Bu araba "Audi" markasında, "A6" modelinde, "gri" renkte ve 4 kapı ile tanımlanıyor.
        Araba araba2 = new Araba("Audi", "A6", "gri", 4);

        // araba2 nesnesi için kapı sayısını öğreniyoruz ve ekrana yazdırıyoruz.
        // KapiSayisiniSoyle() metodu, geçerli bir kapı sayısı olup olmadığını kontrol eder ve doğruysa yazdırır.
        araba2.KapiSayisiniSoyle();
        araba2.ArabayiTanit();

        // araba1 nesnesi için kapı sayısını kontrol ediyoruz.
        // KapiSayisi property'si kullanılarak, araba1'in geçerli kapı sayısını ekrana yazdırıyoruz.
        Console.WriteLine("-----------------------------------");


        // araba1 nesnesinin kapı sayısını tekrar yazdırıyoruz.
        // Bu metod, geçerli bir kapı sayısı varsa yazdırılmasını sağlar.
        araba1.KapiSayisiniSoyle();
        araba1.ArabayiTanit();
    }
}
