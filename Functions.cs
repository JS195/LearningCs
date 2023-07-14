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
    }
}
