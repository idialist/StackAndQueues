using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            Queue<int> result = new Queue<int>();

            foreach (var item in queue)
            {

                if (item % 2 == 0)
                {
                    result.Enqueue(item);
                }
            }
            Console.Write(string.Join(", ", result));
        }
    }
}
