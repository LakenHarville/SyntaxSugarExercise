using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var answer = 4;
            string response;

            response = (answer < 9) ? $"{answer} less than nine." : $"{answer} is greater than or equal to nine.";
            Console.WriteLine(response);
        }
    }
}
