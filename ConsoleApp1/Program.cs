namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Фамилия\tПредмет\tОценка");
            List<Certificate> certificates = new List<Certificate>()
            {
                new Certificate(new Student("Иванов"), new Subject("Математика"),Mark.Пять),
                new Certificate(new Student("Дубровский"), new Subject("Информатика"),Mark.Пять),
                new Certificate(new Student("Петров"), new Subject("Русский"),Mark.Четыре),
                new Certificate(new Student("Диесперов"), new Subject("Русский"),Mark.Три),
                new Certificate(new Student("Картечко"), new Subject("Литература"),Mark.Два)
            };

            var certificatesPeople = certificates.Where(u=>u.mark == Mark.Четыре || u.mark == Mark.Пять).Select(u => u).ToList();
            var notcertificatesPeople = certificatesPeople.Where(u=>u.mark == Mark.Три || u.mark == Mark.Два).Select(u => u).ToList();  
            
            certificatesPeople.ForEach(u => Console.WriteLine($"{u.student.Name}      {u.subject.Name}     {u.mark}" ));
            Console.ReadKey();
        }
    }
}
