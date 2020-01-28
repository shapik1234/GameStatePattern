using Game.Core.Models.Stages;
using System;
using System.Text;

namespace Game.Core.Models
{
    public class City : Stage
    {
        public City(Character person)
            : base("City", person)
        {
        }

        public override Stage Next()
        {
            Stage nextStage = new StopGame(Character);

            Console.WriteLine($"You're in {Name}!");
            StringBuilder builder = new StringBuilder();
            builder.Append("Do you want to visit: ").Append("WizardShop (1)");
            if(Character is SwordMaster)
            {
                builder.Append(", Blacksmith (2)");
            }
            builder.Append(", or go to Arena(0)");
            Console.Write(builder);

            string answer = Console.ReadLine();

            if(int.TryParse(answer, out int nextStageId))
            {
                nextStage = 
                    (nextStageId == 0)
                        ? (Stage) new Arena(Character)
                        : (nextStageId == 1) ? (Stage) new WizardShop(Character) : new Blacksmith(Character);
            }

            return nextStage;
        }
    }
}
