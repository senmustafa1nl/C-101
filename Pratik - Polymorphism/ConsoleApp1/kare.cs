using Geometri;

// Kare sınıfı, GeometrikSekil sınıfından türetilmiştir
// Kare, bir geometrik şekil olduğu için GeometrikSekil sınıfını miras alır
public class Kare : GeometrikSekil
{
    // Kare sınıfı, GeometrikSekil sınıfındaki alanHesapla metodunu override eder
    // Burada, kare olduğu için alan hesaplama işlemi, genislik * yukseklik ile yapılır
    public virtual void alanHesapla()
    {
        // Alan, genislik ve yukseklik çarpılarak hesaplanır
        int alan = genislik * yukseklik;

        // Alan hesaplama sonucu ekrana yazdırılır
        Console.WriteLine($"Karenin alani :");
        Console.WriteLine($"Genislik : {genislik}");
        Console.WriteLine($"Yukseklik : {yukseklik}");
        Console.WriteLine($"Alan : {alan}");
    }
}
