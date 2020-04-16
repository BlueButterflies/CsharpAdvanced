using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        private T Value;

        public Box(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            string result = $"{this.Value.GetType().FullName}: {this.Value}";

            return result;
        }
    }
}
