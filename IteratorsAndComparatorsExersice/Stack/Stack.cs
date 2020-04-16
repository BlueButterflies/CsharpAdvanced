using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> Elements;

        public Stack()
        {
            this.Elements = new List<T>();
        }

        public void Push(T[] pushElement)
        {
            foreach (var item in pushElement)
            {
                this.Elements.Add(item);
            }
        }

        public string Pop()
        {
            if (this.Elements.Count == 0)
            {
                return "No elements";
            }

            this.Elements.Remove(this.Elements.Last());
            return null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.Elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
