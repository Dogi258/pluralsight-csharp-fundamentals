using Xunit;

namespace GradeBook.Test{
    public class BookTest
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // Arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            
            // Act
            var results = book.GetStatistics();

            // Assert
            Assert.Equal(85.6, results.Average, 1);
            Assert.Equal(90.5, results.Max, 1);
            Assert.Equal(77.3, results.Min, 1);
        }
    }
}
