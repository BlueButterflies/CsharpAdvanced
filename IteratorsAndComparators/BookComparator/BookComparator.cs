using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace IteratorsAndComparators
{
    class BookComparator : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            int result = first.Title.CompareTo(second.Title);

            if (result == 0)
            {
                result = first.Year.CompareTo(second.Year);
            }

            return result;
        }
    }
}
