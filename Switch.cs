using System;

namespace LearningCs
{
    class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number between 1 and 5");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num){

                case 1:
                    Console.WriteLine("You have chosen 1");
                    break;
                case 2:
                    Console.WriteLine("You have chosen 2");
                    break;
                case 3:
                    Console.WriteLine("You have chosen 3");
                    break;
                case 4:
                    Console.WriteLine("You have chosen 4");
                    break;
                case 5:
                    Console.WriteLine("You have chosen 5");
                    break;
                default:
                    Console.WriteLine("You have chosen a number outside of the range");
                    break;
            }
            Console.ReadKey();
        }
    }
}
