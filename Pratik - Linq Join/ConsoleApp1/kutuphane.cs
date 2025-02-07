using System.Security.Cryptography.X509Certificates;

namespace Kutuphane ;


public class Yazarlar {

public int AuthorId {get;set;}
public string Name {get;set;}



public Yazarlar(int authorId , string name ){
AuthorId = authorId;
Name = name ;

}



}
public class Kitaplar {
 public int BookId {get;set;}
public string Title {get;set;}
public int AuthorId {get;set;}

public Kitaplar(int bookID , string title , int authorId)
{
    BookId = bookID ;
    Title = title ;
    AuthorId = authorId ;
}

}