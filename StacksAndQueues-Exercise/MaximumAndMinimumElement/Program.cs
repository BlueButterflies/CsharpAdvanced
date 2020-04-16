using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {

            // It can also be solved with everything that has been designated.


            Stack<int> stack = new Stack<int>();

            //int max = int.MinValue;
            //int min = int.MaxValue;

            int countQueries = int.Parse(Console.ReadLine());

            for (int i = 0; i < countQueries; i++)
            {
                int[] commandOfElements = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int commandIndex = commandOfElements[0];

                switch (commandIndex)
                {
                    case 1:
                        int addNum = commandOfElements[1];

                        stack.Push(addNum);

                        //if(addNum < min)
                        //{
                        //    min = addNum;
                        //}

                        //if(addNum > max)
                        //{
                        //    max = addNum;
                        //}
                        break;
                    case 2:
                        if (stack.Count > 0) // or if (stack.Count == 0) {continue;}
                        {
                            /*int remouveElements = stack.Pop()*/
                            stack.Pop();

                            //if (remouveElements == max)
                            //{
                            //    if (stack.Count > 0)
                            //    {
                            //        max = stack.Max();
                            //    }
                            //    else
                            //    {
                            //        max = int.MinValue;
                            //    }
                            //}

                            //if (remouveElements == min)
                            //{
                            //    if (stack.Count > 0)
                            //    {
                            //        min = stack.Min();
                            //    }
                            //    else
                            //    {
                            //        min = int.MaxValue;
                            //    }
                            //}
                        }
                            //stack.Pop();
                        
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
