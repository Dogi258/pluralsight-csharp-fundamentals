// See https://aka.ms/new-console-template for more information
namespace GradeBook{
    public class Book {
        private string name;
        private List<double> grades;
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public void ShowStatistics()
        {
            System.Console.WriteLine($"the lowest grade is {grades.Min()}");
            System.Console.WriteLine($"the lowest grade is {grades.Max()}");
            System.Console.WriteLine($"the lowest grade is {grades.Average()}");
        }
    }
}
