using System;

namespace bebek
//clasimizi bebek olarak ayarliyoruz
{
public class Bebek {
//classi tanimliyoruz
public string ad {get; set;}
public string soyad {get; set;}
public DateTime  dogumTarihi {get; set ;}



public Bebek(){

    Console.WriteLine("Ingaaaaa");

    ad = "bilinmiyor";
    soyad = "bilinmiyor";
    dogumTarihi = DateTime.MinValue;
}

public Bebek(string bebekIsmi, string bebekSoyismi, DateTime bebekDogumTarihi ){

ad  =  bebekIsmi;
soyad = bebekSoyismi ;
dogumTarihi = bebekDogumTarihi ; 

}
public void bebekBilgileri()
{
Console.WriteLine($"Ad: {ad} {soyad}");
Console.WriteLine($"Dogum Tarihi : {dogumTarihi.ToShortDateString()}");


}



}
}