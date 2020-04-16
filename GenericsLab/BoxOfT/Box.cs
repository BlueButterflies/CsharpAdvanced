using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> boxes;

        public Box() => this.boxes = new List<T>();

        public void Add(T elements) => this.boxes.Add(elements);

        public T Remove()
        {
            var result = this.boxes.Last();
            this.boxes.RemoveAt(this.boxes.Count - 1);
            return result;
        }

        
        public int Count => this.boxes.Count;
    }
}
