using System;
// To use lists 
using System.Collections.Generic;

namespace LearningCs
{
    class Lists
    {
        static void Main(string[] args)
        {
            // Lists do not need to be of predefined size
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Apples");
            shoppingList.Add("Water");
            shoppingList.Add("Oil");
            shoppingList.Add("Yoghurt");

            for (int i = 0; i<shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Apples");
            shoppingList.RemoveAt(1);

            Console.WriteLine("--------------");
            
            for (int i = 0; i<shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            Console.ReadKey();
        }
    }
}
