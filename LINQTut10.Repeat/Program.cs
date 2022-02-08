using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut10.Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var q = QuestionBank.PickOne();

            var questions2 = new List<Question>();
            for (int i = 0; i < 10; i++)
            {
                questions2.Add(new Question());
            }

            Console.WriteLine(ReferenceEquals(questions2[0], questions2[1]));
            var questions = Enumerable.Repeat(q, 10).ToList();

            Console.WriteLine(ReferenceEquals(questions[0], questions[1]));
            //questions.ToQuiz();
          Console.ReadKey();
        }
    }
}
