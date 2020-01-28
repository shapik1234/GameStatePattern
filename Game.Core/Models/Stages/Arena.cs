using System;

namespace Game.Core.Models.Stages
{
    public class Arena : Stage
    {
        public Arena(Character person)
            : base("Arena", person)
        {
        }

        public override Stage Next()
        {
            Stage nextStage = new StopGame(Character);

            Console.WriteLine($"You're in {Name}.");
            Console.Write($"Do you want to come back to the City(1) or stop gaming(0)?");

            string answer = Console.ReadLine();

            if (int.TryParse(answer, out int nextStageId) && nextStageId == 1)
            {
                nextStage = new City(Character);
            }

            return nextStage;
        }
    }
}
