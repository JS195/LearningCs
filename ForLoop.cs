using System;

namespace LearningCs
{
    class ForLoop
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many Fibonacci numbers do you want to see?");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=count; i++)
            {
                double result = Math.Pow(2,i);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
