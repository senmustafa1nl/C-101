 namespace muzify;


 public class muzikListesi {

    public string SarkiciAdi {get; set;}
    public string MuzikTuru {get ; set;}
    public int CikisYili {get; set ;}
    public int AlbumSatislari {get;set; }

 public muzikListesi(string sarkiciAdi , string muzikTuru , int cikisYili, int albumSatislari  ){


    SarkiciAdi = sarkiciAdi ;
     MuzikTuru = muzikTuru ;
    CikisYili = cikisYili ;
    AlbumSatislari = albumSatislari ;

 }


 }


