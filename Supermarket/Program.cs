using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Queue<string> nameList = new Queue<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    nameList.Enqueue(input);
                }
                else
                {
                    Console.WriteLine(string.Join("\n",nameList));
                    nameList.Clear();
                }
            }
            Console.WriteLine($"{nameList.Count} people remaining.");
        }
    }
}
