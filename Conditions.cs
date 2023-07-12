using System;

namespace LearningCs
{
    class Conditions
    {
        static void Main(string[] args)
        {
            int age;
            int height;

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your height");
            height = Convert.ToInt32(Console.ReadLine());

            if(age >= 18 && height >= 160)
            {
                Console.WriteLine("You are allowed to enter");
            }
            else
            {
                Console.WriteLine("You are not allowed to enter");
            }
            Console.ReadKey();
        }
    }
}
