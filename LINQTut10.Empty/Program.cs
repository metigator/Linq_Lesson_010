using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut10.Empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = new List<Question>(); // empty list

            //1
            //...
            //1000
            foreach (var q in questions)
            {
                Console.WriteLine(q);
            }

            var questions2 = Enumerable.Empty<Question>(); // empty list

            //1
            //...
            //1000
            foreach (var q in questions2)
            {
                Console.WriteLine(q);
            }

            Console.ReadKey();
        }
    }
}
