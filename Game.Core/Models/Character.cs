namespace Game.Core.Models
{
    public abstract class Character
    {
        protected Character(int life, int mana, Weapon weapon, Bag bag)
        {
            Life = life;
            Mana = mana;
            Weapon = weapon;
            Bag = bag;
        }

        public int Life { get; }

        public int Mana { get; }

        public int Level { get; } = 1;

        public Weapon Weapon { get; }

        public Bag Bag { get; }
    }
}
