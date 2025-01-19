# IMDB Film Listesi Uygulaması

Bu, C# ile geliştirilmiş bir konsol uygulamasıdır. Kullanıcıların IMDb puanlarıyla birlikte film listesini yönetmelerini sağlar. Kullanıcılar filmler ekleyebilir, tüm filmleri görüntüleyebilir, IMDb puanına göre filtreleme yapabilir ve ismi "A" harfiyle başlayan filmleri listeleyebilir.

## Özellikler

- Kullanıcılar, filmleri adları ve IMDb puanlarıyla birlikte listeye ekleyebilir.
- Kullanıcılar, tüm filmleri listeleyebilir.
- Kullanıcılar, IMDb puanı 4 ile 9 arasında olan filmleri listeleyebilir.
- Kullanıcılar, ismi "A" harfiyle başlayan filmleri görüntüleyebilir.
- Uygulama, kullanıcıya film eklemeye devam etmesi veya bir işlem yapması için sürekli olarak soru sorar.



## Kullanım

1. Uygulama başladığında, kullanıcıya hoş geldiniz mesajı verilecek ve film adı ve IMDb puanı girmeniz istenecektir.
2. Kullanıcı, film adı ve IMDb puanını girecek.
3. Bir film girildikten sonra, kullanıcıya başka bir film eklemek isteyip istemediği sorulacaktır.
4. Kullanıcı, film eklemeye devam edebilir veya aşağıdaki seçeneklerden birini seçebilir:
    - Tüm filmleri listele.
    - IMDb puanı 4 ile 9 arasında olan filmleri listele.
    - İsmi "A" ile başlayan filmleri listele.


## Kod Yapısı

### Film Sınıfı

- **Ad**: Filmin adı.
- **ImdbPuani**: Filmin IMDb puanı.
- **ToString Metodu**: `ToString()` metodu, her film için özel bir biçim ile çıktıyı döndürür (örneğin, "The Dark Knight - IMDb Puanı: 9.0").

### Ana Program

- Ana program, film listesi (`List<Film> filmler`) yönetir.
- Kullanıcıdan film adı ve IMDb puanı alınır.
- Kullanıcıya film eklemeye devam etme veya aşağıdaki işlemlerden birini seçme imkanı tanınır.







