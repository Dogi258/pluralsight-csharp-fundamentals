

namespace GradeBook 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("My Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            Statistics stats = book.GetStatistics();

            System.Console.WriteLine($"the lowest grade is {stats.Min}");
            System.Console.WriteLine($"the lowest grade is {stats.Max}");
            System.Console.WriteLine($"the lowest grade is {stats.Average}");
        }
    }
}