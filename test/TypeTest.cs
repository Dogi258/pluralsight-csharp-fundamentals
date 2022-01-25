using System;
using Xunit;

namespace GradeBook.Test{
    public class TypeTest
    {
        [Fact]
        public void StringsBehaveLilkeValueTypes(){
            string name = "Daniel";

            var upper = MakeUppercase(name);

            Assert.Equal("Daniel", name);
            Assert.Equal("DANIEL", upper);
        }

        public string MakeUppercase(string parameter){
            return parameter.ToUpper();
        }

        [Fact]
        public void ValueTypeAlsoPassByReference()
        {
            // Given
            var x = GetInt();
            SetInt(ref x);
            // When
        
            // Then
            Assert.Equal(42, x);
        }

        private void SetInt(ref int x) {
            x = 42;
        }

        private int GetInt(){
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            // Arrange
            Book book1 = GetBook("Book 1");
            GetBookAndSetName(ref book1, "New Name");

            // Act

            // Assert
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // Arrange
            Book book1 = GetBook("Book 1");
            GetBookAndSetName(book1, "New Name");

            // Act

            // Assert
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookAndSetName(Book book, string name)
        {
            book  = new Book(name);
        }
        private void GetBookAndSetName(ref Book book, string name)
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
 