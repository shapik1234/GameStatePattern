using System;

namespace Game.Core.Models.Stages
{
    public class WizardShop : Stage
    {
        public WizardShop(Character person)
            : base("Wizard Shop", person)
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
