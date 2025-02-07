using System ;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using Kutuphane;

class Program {
public  static void Main()
{

List<Yazarlar> authors = new List<Yazarlar>{
new Yazarlar(1,"Orhan Pamuk"),
new Yazarlar(2,"Elif Safak"),
new Yazarlar(3,"Ahmet Umit"),
};


List<Kitaplar> books = new List<Kitaplar>{
new Kitaplar (1, "Kar" , 1 ),
new Kitaplar ( 2 , "Istanbul" , 1),
new Kitaplar (3, "10 Minutes 38 Seconds in This Strange World" , 2),
new Kitaplar ( 4 , "Beyoglu Rapsodisi", 3),
};

var library = from author in authors 
                join book in books
                on author.AuthorId equals book.AuthorId 
                select new {
                    bookName = book.Title,
                    author = author.Name
                };
            
            


foreach (var x in library){

    Console.WriteLine($"Kitap Adi : {x.bookName}\nYazar Adi : {x.author}\n");
};





}
}