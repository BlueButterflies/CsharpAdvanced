using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<T1 , T2>
    {
        private T1 ItemOne;
        private T2 ItemTwo;

        public Tuple(T1 itemOne, T2 itemTwo)
        {
            this.ItemOne = itemOne;
            this.ItemTwo = itemTwo;
        }

        public override string ToString()
        {
            return $"{this.ItemOne} -> {this.ItemOne}";
        }
    }
}
