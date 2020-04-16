using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> Elements;
        private int Index;

        public ListyIterator(List<T> elements)
        {
            this.Elements = elements;
            this.Index = 0;
        }

        public bool Move()
        {
            bool hasNext = this.HasNext();

            if (hasNext)
            {
                this.Index++;
            }

            return hasNext;
        }

        public bool HasNext()
        {
            if (this.Index < this.Elements.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.Elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.Elements[this.Index]);
        }
    }
}
