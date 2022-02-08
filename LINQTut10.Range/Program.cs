using Shared;
using System;
using System.Linq;

namespace LINQTut10.Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = Enumerable.Range(1, 10);

            //int[] range2 = new int[10];

            //for (int i = 0; i < range2.Length; i++)
            //    range2[i] = i;

            //for (int i = 0; i < range2.Length; i++)
            //    Console.Write($" {i}");

            //foreach (var i in range) 
            //    Console.Write($" {i}");

            var questions = QuestionBank.GetQuestionRange(range);

            questions.ToQuiz();




            Console.ReadKey();
        }
    }
}
