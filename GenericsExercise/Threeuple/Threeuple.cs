using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    class Threeuple<T1, T2, T3>
    {
        private T1 ItemOne;
        private T2 ItemTwo;
        private T3 ItemThree;


        public Threeuple(T1 itemOne, T2 itemTwo, T3 itemThree)
        {
            this.ItemOne = itemOne;
            this.ItemTwo = itemTwo;
            this.ItemThree = itemThree;
        }

        public override string ToString()
        {
            return $"{this.ItemOne} -> {this.ItemTwo} -> {this.ItemThree}";
        }
    }
}
