namespace Geometri
{
    // GeometrikSekil sınıfı, genel geometrik şekillerin özelliklerini ve alan hesaplamalarını içerir.
    public class GeometrikSekil
    {
        // Geometrik şeklin genişlik ve yükseklik özellikleri tanımlanıyor
        public int genislik;
        public int yukseklik;

        // Alan hesaplamayı gerçekleştiren sanal metod
        public virtual void alanHesapla()
        {
            // Alan, genislik ve yukseklik çarpılarak hesaplanıyor
            int alan = genislik * yukseklik;

            // Alan hesaplama sonucunu ekrana yazdırıyoruz
            Console.WriteLine($"Geometrik şeklin alanı :");
            Console.WriteLine($"Genislik: {genislik}");
            Console.WriteLine($"Yukseklik: {yukseklik}");
            Console.WriteLine($"Alan: {alan}");
        }
    }
}
