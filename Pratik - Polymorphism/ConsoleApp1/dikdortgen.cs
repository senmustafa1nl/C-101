using Geometri;

// Dikdortgen sınıfı, GeometrikSekil sınıfından türetilmiştir
// Dikdörtgenin özel özellikleri ve alan hesaplama fonksiyonu burada tanımlanır
public class dikdortgen : GeometrikSekil
{
    // Dikdörtgen sınıfı, GeometrikSekil sınıfındaki alanHesapla metodunu override eder
    // Bu metod, dikdörtgenin alanını hesaplamak için genislik ve yukseklik kullanır
    public virtual void alanHesapla()
    {
        // Alan, genislik ve yukseklik çarpılarak hesaplanır
        int alan = genislik * yukseklik;

        // Alan hesaplama sonucu ekrana yazdırılır
        Console.WriteLine($"Dikdörtgenin alani :");
        Console.WriteLine($"Genislik : {genislik}");
        Console.WriteLine($"Yukseklik : {yukseklik}");
        Console.WriteLine($"Alan : {alan}");
    }
}
