using System;
using System.Collections.Generic;

namespace QueuseExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int count = 0;
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        var car = queue.Dequeue();
                        count++;
                        Console.WriteLine($"{car} passed!");
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
