using System;
//bebek ismiyle clasimizi cagiriyoruz
using bebek ;
{
   
//ilk bebegi default olarak tanitiyoruz 
        Bebek bebek1 = new Bebek();
        Console.WriteLine("Bebek Bilgileri");
        bebek1.bebekBilgileri();

//bebek 2 yi parametre girerek tanitiyoruz v
//ve bebegin dogum anini programin calistigi an olarak ayarliyoruz
        Bebek bebek2 = new Bebek(){
        
             ad= "Mustafa",
             soyad ="SEN",
              dogumTarihi = DateTime.Now
        };
        bebek2.bebekBilgileri();
        
        
       


    }
    


