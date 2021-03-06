// See https://aka.ms/new-console-template for more information
namespace GradeBook{
    public class Book {
        public string Name;
        private List<double> grades;
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();

            result.Average = grades.Average();
            result.Min = grades.Min();
            result.Max = grades.Max();

            return result;
        }
    }
}
