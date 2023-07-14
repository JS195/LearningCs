using System;

namespace LearningCs
{
    public class Functions
    {
        static void Main(string[] args)
        {
            Functions voidInstance = new Functions();
            voidInstance.MeetAlien();
            Console.WriteLine("-------------------------");
            voidInstance.MeetAlien();
            Console.WriteLine("-------------------------");
            
            int num01;
            num01 = Convert.ToInt32(Console.ReadLine());

            int answer;
            answer = voidInstance.Square(num01);
            Console.WriteLine(answer);
            Console.ReadKey();
        }

        public void MeetAlien()
        {
            Random numberGen = new Random();
            string name = "X-" +numberGen.Next(10, 9999);
            int age = numberGen.Next(10,500);

            Console.WriteLine("Hi, I'm " + name);
            Console.WriteLine("I am "+age+" years old");
        }

        public int Square(int number)
        {
            int result = number*number;
            return result;
        }
    }
}
