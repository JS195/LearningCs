using System;

namespace LearningCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SkyNet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WindowHeight = 40;

            Console.WriteLine("Hello, whats your name?");
            Console.ReadLine();

            Console.WriteLine("I am an evil AI");

            Console.ReadKey();
        }
    }
}
