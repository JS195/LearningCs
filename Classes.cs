using System;

namespace LearningCs
{
    class Wizard
    {
        public string name;
        public string favouriteSpell;
        public int spellSlots;
        public float experience;

        public static int Count;

        public Wizard(string _name, string _favouriteSpell)
        {
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0f;
            Count++;
        }

        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name+ " casts " + favouriteSpell);
                spellSlots--;
                experience += 0.3f;            
            }
            else 
            {
                Console.WriteLine(name + " is out of spell slots.");
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots.");
            spellSlots = 3;
        }

    }

    class Classes
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Ronald Weasley","Retardo");
            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("Tony Soprano", "Magic");
            wizard02.CastSpell();

            Console.WriteLine(Wizard.Count);

            Console.ReadKey();
        }
    }
}