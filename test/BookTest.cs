using Xunit;

namespace GradeBook.Test{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            
            // Act
            

            // Assert


        }
    }
}
