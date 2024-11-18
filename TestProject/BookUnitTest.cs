using ApplicationBook;
using Domain;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_AddNewBook_is_called_Add_New_Book()
        {
            //Arrange
            Book  BookToTest = new Book(1, "TobyBook", "Book of Toby");
            //Act
            Book bookCreated = BookMethod.AddNewBook();
            //Assert
            Assert.That(bookCreated, Is.Not.Null);
            Assert.That(bookCreated.Title , Is.EqualTo(BookToTest.Title));
            
        }
    }
}