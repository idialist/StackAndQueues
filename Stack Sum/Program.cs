using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            while (true)
            {
                string input = Console.ReadLine();
                string[] arg = input.Split(' ');
                string command = arg[0].ToLower();

                if (command == "end")
                {
                    break;
                }

                int num = int.Parse(arg[1]);

                if (command == "add")
                {
                    int secondNum = int.Parse(arg[2]);
                    stack.Push(num);
                    stack.Push(secondNum);
                }
                else if (command == "remove")
                {
                    if (stack.Count > num)
                    {
                        for (int i = 0; i < num; i++)
                        {                         
                                stack.Pop();                       
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
