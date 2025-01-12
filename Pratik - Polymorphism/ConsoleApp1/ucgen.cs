using Geometri;

public class ucgen : GeometrikSekil
{
    // Ucgen sınıfı, GeometrikSekil sınıfından türetilmiştir
    // Üçgenin özel alan hesaplama fonksiyonu burada tanımlanır

    // alanHesapla metodu, GeometrikSekil sınıfındaki alanHesapla metodunu override eder
    // Bu metod, üçgenin alanını hesaplamak için genislik ve yukseklik kullanır
    public virtual void alanHesapla()
    {
        // Üçgenin alanı: (genislik * yukseklik) / 2
        int alan = (genislik * yukseklik) / 2;

        // Alan hesaplama sonucu ekrana yazdırılır
        Console.WriteLine($"Üçgenin alani :");
        Console.WriteLine($"Genislik : {genislik}");
        Console.WriteLine($"Yukseklik : {yukseklik}");
        Console.WriteLine($"Alan : {alan}");
    }
}
