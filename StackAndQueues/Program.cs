using System;
using System.Linq;
using System.Collections.Generic;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> characters = new Stack<char>(input);
      
            while (characters.Count > 0)
            {
                char ch = characters.Pop();

                Console.Write(ch);
            }
        }
    }
}
