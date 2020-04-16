using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library
    {
        private List<Book> Books;

        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }
    }
}
