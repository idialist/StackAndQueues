using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            var result = Eveluate(expression);
            Console.WriteLine(result);
        }
        static double Eveluate(string expression)
        {
            var allowedOperators = "+-*/";
            var numbers = new Stack<double>();
            var operators = new Stack<char>();
            for (int i = 0; i < expression.Length; i++)
            {
                var @char = expression[i];

                if (@char == '(')
                {
                    operators.Push(@char);
                }
                else if (@char == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        var op = operators.Pop();
                        var param2 = numbers.Pop();
                        var param1 = numbers.Pop();
                        var newVavlue = ApplyOperation(op, param1, param2);
                        numbers.Push(newVavlue);
                    }
                    operators.Pop();
                }
                else if (allowedOperators.Contains(@char))
                {
                    while (operators.Count > 0 && Priority(operators.Peek()) >= Priority(@char))
                    {
                        var op = operators.Pop();
                        var param2 = numbers.Pop();
                        var param1 = numbers.Pop();
                        var newVavlue = ApplyOperation(op, param1, param2);
                        numbers.Push(newVavlue);
                    }
                    operators.Push(@char);
                }
                else if (char.IsDigit(@char) || @char == '.')
                {
                    var number = new StringBuilder();
                    while (char.IsDigit(@char) || @char == '.')
                    {
                        number.Append(@char);
                        i++;
                        if (i == expression.Length)
                        {
                            break;
                        }
                        @char = expression[i];
                    }

                    i--;

                    numbers.Push(double.Parse(number.ToString()));
                }
            }
            while (operators.Count > 0)
            {
                var op = operators.Pop();
                var param2 = numbers.Pop();
                var param1 = numbers.Pop();
                var newVavlue = ApplyOperation(op, param1, param2);
                numbers.Push(newVavlue);
            }

            return numbers.Pop();
        }
        static double ApplyOperation(char operation, double operant1, double operant2)
        {
            switch (operation)
            {
                case '+': return operant1 + operant2;
                case '-': return operant1 - operant2;
                case '*': return operant1 * operant2;
                case '/': return operant1 / operant2;
                default: return 0.0;
            }
        }
        static int Priority(char operation)
        {
            switch (operation)
            {
                case '+': return 1;
                case '-': return 1;
                case '*': return 2;
                case '/': return 2;
                default: return 0;

            }
        }
    }
}
