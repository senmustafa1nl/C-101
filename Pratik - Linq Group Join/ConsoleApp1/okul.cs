


namespace okul
{
    // Öğrenciler sınıfı
    public class students
    {
        // Öğrencinin kimliği
        public int StudentId { get; set; }

        // Öğrencinin adı
        public string StudentName { get; set; }

        // Öğrencinin sınıfı
        public int ClassId { get; set; }

        // Yapıcı metot: Öğrencinin özelliklerini başlatan metot
        public students(int studentId, string studentName, int classId)
        {
            // Öğrencinin kimliği atanıyor
            StudentId = studentId;

            // Öğrencinin adı atanıyor
            StudentName = studentName;

            // Öğrencinin sınıfı atanıyor
            ClassId = classId;
        }
    }

    // Sınıflar (dersler) sınıfı
    public class classes
    {
        // Sınıfın kimliği
        public int ClassId { get; set; }

        // Sınıfın adı
        public string ClassName { get; set; }

        // Yapıcı metot: Sınıfın özelliklerini başlatan metot
        public classes(int classId, string className)
        {
            // Sınıfın kimliği atanıyor
            ClassId = classId;

            // Sınıfın adı atanıyor
            ClassName = className;
        }
    }
}




