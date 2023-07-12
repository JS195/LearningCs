using System;

namespace LearningCs
{
    class Variables
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;

            Console.WriteLine("Enter a number");
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter another number");
            num02 = Convert.ToDouble(Console.ReadLine());

            double result = num01 * num02;

            Console.WriteLine("The result is " + result);
            
            Console.ReadKey();
        }
    }
}
