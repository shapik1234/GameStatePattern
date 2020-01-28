using System;

namespace Game.Core.Models
{
    public class Road : Stage
    {
        public Road(Character person)
            : base("Road", person)
        {
        }

        public override Stage Next()
        {
            Console.Write($"You're on {Name} and payed 30 gold.");
            Console.ReadLine();

            return new City(Character);
        }
    }
}
