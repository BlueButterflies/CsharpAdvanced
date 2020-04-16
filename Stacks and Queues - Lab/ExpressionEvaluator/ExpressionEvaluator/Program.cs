using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace ExpressionEvaluator
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            var result = Evaluate(expression.ToString());

            Console.WriteLine(result);
        }

        static double Evaluate(string expression)
        {
            var allowedOperators = "+-/*^";

            var numbers = new Stack<double>();
            var operations = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                var @char = expression[i];

                if(@char == '(')
                {
                    operations.Push(@char);
                }
                else if( @char == ')')
                {
                    while (operations.Peek() != '(')
                    {
                        var opers = operations.Pop();

                        var paramTwo = numbers.Pop();
                        var paramOne = numbers.Pop();

                        var newValue = ApplyOperation(opers, paramOne, paramTwo);

                        numbers.Push(newValue);
                    }
                    operations.Pop(); // '('
                }
                else if(allowedOperators.Contains(@char))
                {
                    while(operations.Count > 0 && Priority(operations.Peek()) >= Priority(@char))
                    {
                        var opers = operations.Pop();

                        var paramTwo = numbers.Pop();
                        var paramOne = numbers.Pop();

                        var newValue = ApplyOperation(opers, paramOne, paramTwo);

                        numbers.Push(newValue);
                    }
                    operations.Push(@char);
                }
                else if(char.IsDigit(@char) || @char == '.')
                {
                    var number = new StringBuilder();

                    while (char.IsDigit(@char) || @char == '.')
                    {
                        number.Append(@char);
                        i++;

                        if(i == expression.Length)
                        {
                            break;
                        }

                        @char = expression[i];
                    }

                    i--;

                    numbers.Push(double.Parse(number.ToString()));
                }
            }

            while (operations.Count > 0)
            {
                var opers = operations.Pop();

                var paramTwo = numbers.Pop();
                var paramOne = numbers.Pop();

                var newValue = ApplyOperation(opers, paramOne, paramTwo);

                numbers.Push(newValue);
            }

            return numbers.Pop();
        }
        static double ApplyOperation(char operation, double operadOne, double operadTwo)
        {
            switch (operation)
            {
                case '+':
                     return operadOne + operadTwo;
                case '-':
                    return operadOne - operadTwo;
                case '*':
                    return operadOne * operadTwo;
                case '/':
                    if (operadTwo == 0)
                    {
                        throw new Exception("Division by zero!");
                    }
                    else
                    {
                        return operadOne / operadTwo;
                    }
                case '^':
                    return Math.Pow(operadOne, operadTwo);
                default:
                    return 0.0;
            }
        }
        static int Priority(char operation)
        {
            switch (operation)
            {
                case '+':
                    return 1;
                case '-':
                    return 1;
                case '*':
                    return 2;
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
