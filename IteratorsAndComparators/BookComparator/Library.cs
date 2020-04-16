using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private readonly SortedSet<Book> Books;

        public Library(params Book[] books)
        {
            this.Books = new SortedSet<Book>(books, new BookComparator());
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LibraryIterator(this.Books);
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly IList<Book> Books;
            private int CurrentIndex;

            public LibraryIterator(ICollection<Book> books)
            {
                this.Reset();
                this.Books = new List<Book>(books);
            }

            public Book Current => this.Books[CurrentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose() { }

            public bool MoveNext() => ++CurrentIndex < this.Books.Count;

            public void Reset() => this.CurrentIndex = -1;
        }
    }
}
