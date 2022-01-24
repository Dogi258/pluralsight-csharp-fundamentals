using System;
using Xunit;

namespace GradeBook.Test{
    public class TypeTest
    {
        [Fact]
        public void CSharpIsPassByValue()
        {
            // Arrange
            Book book1 = GetBook("Book 1");
            GetBookAndSetName(book1, "New Name");

            // Act

            // Assert
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookAndSetName(Book book, string name)
        {
            book  = new Book(name);
        }
        [Fact]
        public void CanSetNameFromReference()
        {
            // Arrange
            Book book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            // Act

            // Assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObject()
        {
            // Arrange
            Book book1 = GetBook("Book 1");
            Book book2 = GetBook("Book 2");

            // Act

            // Assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // Arrange
            Book book1 = GetBook("Book 1");
            Book book2 = book1;

            // Act

            // Assert
            Assert.Same(book1, book2);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
 