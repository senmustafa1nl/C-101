using System;
using okul;
using System.Collections.Generic;
using System.Linq;

class Program {
    public static void Main() {
        
        // Öğrenciler listesi oluşturuluyor
        List<students> student = new List<students> {
            new students(1, "Ali", 1),  // Öğrenci 1
            new students(2, "Ayse", 2), // Öğrenci 2
            new students(3, "Mehmet", 1), // Öğrenci 3
            new students(4, "Fatma", 3), // Öğrenci 4
            new students(5, "Ahmet", 2)  // Öğrenci 5
        };

        // Sınıflar (dersler) listesi oluşturuluyor
        List<classes> classes = new List<classes> {
            new classes(1, "Matematik"),  // Sınıf 1 (Matematik)
            new classes(2, "Türkçe"),     // Sınıf 2 (Türkçe)
            new classes(3, "Kimya")       // Sınıf 3 (Kimya)
        };

        // Group Join işlemi: Her sınıf için o sınıfa ait öğrencileri grupla
        var okul = from lesson in classes
                   join condidate in student
                   on lesson.ClassId equals condidate.ClassId into condidateGroup // Öğrenciler sınıf id'sine göre gruplandı
                   select new {
                       className = lesson.ClassName,  // Sınıf adı
                       studentss = condidateGroup.Select(s => s.StudentName) // O sınıfa ait öğrencilerin isimleri
                   };

        // Sonuçları ekrana yazdırma
        foreach (var x in okul) {
            Console.WriteLine($"Sınıf: {x.className}"); // Sınıf adı yazdırılıyor
            foreach (var studentName in x.studentss) { 
                Console.WriteLine($"    Öğrenci: {studentName}"); // O sınıfa ait öğrencilerin isimleri yazdırılıyor
            }
            Console.WriteLine(); // Arada boşluk bırakmak için
        }
    }
}
