using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_1;

namespace Assignment1UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BookTitleSmallerThan2()
        {
            //Arrange
            var book = new Book();
            //Act
            book.title = "A";
            //Assert
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PageNumberSmallerThan10()
        {
            //Arrange
            var book = new Book();
            //Act
            book.pgnr = 7;
            //Assert
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PageNumberGreaterThan1000()
        {
            //Arrange
            var book = new Book();
            //Act
            book.pgnr = 1007;
            //Assert
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ISBNSmaller13()
        {
            //Arrange
            var book = new Book();
            //Act
            book.isbn13 = "asdfghjklqwe";
            //Assert
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ISBNGreater13()
        {
            //Arrange
            var book = new Book();
            //Act
            book.isbn13 = "asdfghjklqwe123";
            //Assert
            Assert.Fail();
        }

        [TestMethod]
        public void BookTitleIsGoodTest()
        {
            //Arrange
            Book book = new Book();

            //Act
            book.title = "Heidi";
            string result = book.title;

                //Assert
                Assert.AreEqual(result, book.title);
        }

        [TestMethod]
        public void AuthorUT()
        {
            //Arrange
            Book book = new Book();

            //Act
            book.author = "Van Gogh";
            string result = book.author;

            //Assert
            Assert.AreEqual(result, book.author);
        }

        [TestMethod]
        public void PGtest()
        {
            //Arrange
            Book book = new Book();

            //Act
            book.pgnr = 877;
            int result = book.pgnr;

            //Assert
            Assert.AreEqual(result, book.pgnr);
        }


    }
}
