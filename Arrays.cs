using System;

namespace LearningCs
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // Creating an empty string array of size 4
            string[] movies = new string[4];

            Console.WriteLine("Type in your four movies");

            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }

            Console.WriteLine("In Alphabetical order: ");
            Array.Sort(movies);
            for (int i =0; i<movies.Length; i ++)
            {
                Console.WriteLine(movies[i]);
            }

            
            Console.ReadKey();
        }
    }
}
