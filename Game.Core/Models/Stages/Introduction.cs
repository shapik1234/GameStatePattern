using System;

namespace Game.Core.Models.Stages
{
    public class Introduction : Stage
    {
        public Introduction(Character person)
            : base("Introduction", person)
        {
        }

        public override Stage Next()
        {
            Console.WriteLine("The Game!");
            if (Character is Wizard)
            {
                Console.WriteLine("You're Wizard!");
            }
            else if(Character is SwordMaster)
            {
                Console.WriteLine("You're Sword Master!");
            }

            Console.Write("Start gaming!");
            Console.ReadLine();

            return new Road(Character);
        }
    }
}
