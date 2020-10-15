using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _pageNumber;
        private string _isbn13;
        //empty constructor
        public Book() {}
        //constructor
        public Book(string Title, string Author, int pageNumber, string Isbn13)
        {
            title = Title;
            author = Author;
            pgnr = pageNumber;
            isbn13 = Isbn13;
        }

        public string title
        {
            get { return _title;}
            set
            {
                if (value.Length < 2) 
                {
                    throw new ArgumentException("Title must contain at minimum 2 chacaters");
                }

                _title = value;
            }
        }

        public string author { get; set; }

        public int pgnr
        {
            get
            {
                return _pageNumber;
            }
            set
            {
                if (value <= 10 || value > 1000)
                {
                    throw new ArgumentException(" Page number has to be between 11 and 1000");
                }

                _pageNumber = value;
            }
        }

        public string isbn13
        {
            get { return _isbn13; }
            set {
                if (value.Length != 13)
                {
                    throw new ArgumentException("ISBN has to be exactly 13 characters");
                }

                _isbn13 = value;
            }
        }

    }
}
