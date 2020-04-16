using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDoubles
{
    public class Box<T> : IComparable<T>
    where T : IComparable<T>
    {
        private T Value;

        public Box(T value)
        {
            this.Value = value;
        }

        public int CompareTo(T item)
        {
            return this.Value.CompareTo(item);
        }

        public override string ToString()
        {
            string result = $"{this.Value.GetType().FullName}: {this.Value}";

            return result;
        }
    }
}
