using Shared;
using System;
using System.Linq;

namespace LINQTut10.DefaultIfEmpty
{
    public class Program
    {
        static void Main(string[] args)
        {
            // int x; // x=0;
            //Console.WriteLine(default(int)); // 0
            //Console.WriteLine(default(DateTime)); // 01-01-0001 12:00:00 AM
            //Console.WriteLine(default(Object) is null ? "NULL" : default(Object) is null); // NULL
            var questions = Enumerable.Empty<Question>();

            var question2 = questions.DefaultIfEmpty();

            var question3 = questions.DefaultIfEmpty(Question.Default);
            
            question3.ToQuiz();

            Console.ReadKey();
        }
    }
}
