namespace Game.Core.Models
{
    public class Bag
    {
        public Bag(int gold)
        {
            Gold = gold;
        }

        public int Gold { get; }

        public int LifePotion { get; }

        public int ManaPotion { get; }

        public override string ToString()
        {
            return $"Gold={Gold}, Potions={LifePotion}/{ManaPotion}";
        }
    }
}
