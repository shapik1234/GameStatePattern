using System;
using Game.Core.Models;
using Game.Core.Models.Stages;

namespace Game.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select personage: 1 - Wizard, 2 - SwordMaster");
            string personage = Console.ReadLine();

            int.TryParse(personage, out int personageType);

            Character person = (personageType == 1) ? (Character) new Wizard(100, 50) : new SwordMaster(150, 30);

            Console.WriteLine($"Level={person.Level}, Life={person.Life}, Mana={person.Mana}");
            Console.WriteLine($"Weapon={person.Weapon}");
            Console.WriteLine($"Bag={person.Bag}");

            Stage currentStage = new Introduction(person);
            do
            {
                currentStage = currentStage.Next();
            }
            while (!(currentStage is StopGame));

            currentStage.Next();
        }
    }
}
