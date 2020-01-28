using System;

namespace Game.Core.Models.Stages
{
    public class StopGame : Stage
    {
        public StopGame(Character person)
            : base("Stop game", person)
        {
        }

        public override Stage Next()
        {
            Console.Write("Stop game!");
            Console.ReadLine();

            return null;
        }
    }
}
