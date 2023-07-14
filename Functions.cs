using System;

namespace LearningCs
{
    public class Functions
    {
        static void Main(string[] args)
        {
            Functions voidInstance = new Functions();
            voidInstance.PrintNumber();
            Console.ReadKey();
        }

        public void PrintNumber()
        {
            Random numGen = new Random();
            int number = numGen.Next(0, 10);
            Console.WriteLine(number);
        }
    }
}
