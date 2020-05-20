using System;
using System.Collections;
using System.Collections.Generic;

namespace StackExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                var @char = input[i];
                if (@char == '(')
                {
                    stack.Push(i);
                }
                else if (@char == ')')
                {
                   var leftIndex = stack.Pop();
                    var esspresion = input.Substring(leftIndex, i - leftIndex + 1);
                    Console.WriteLine(esspresion);
                }
            }

        }
    }
}
