using System;

namespace Game.Core.Models.Stages
{
    public class Blacksmith : Stage
    {
        public Blacksmith(Character person)
            : base("Blacksmith", person)
        {
        }

        public override Stage Next()
        {
            Console.Write($"You're in {Name} and now you are going to Arena.");
            Console.ReadLine();

            return new Arena(Character);
        }
    }
}
