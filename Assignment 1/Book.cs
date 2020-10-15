using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Book
    {
        private string _title;
        private string _author;
        private int _pageNumber;
        private string _isbn13;

        public Book(string Title, string Author, int pageNumber, string isbn13)
        {
            _title = Title;
            _author = Author;
            _pageNumber = pageNumber;
            _isbn13 = isbn13;
        }
    }
}
