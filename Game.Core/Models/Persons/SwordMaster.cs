namespace Game.Core.Models
{
    public class SwordMaster : Character
    {
        public SwordMaster(int life, int mana)
            : base(life, mana, new Sword(), new Bag(25000))
        {
        }

        public int SwordLevel { get; } = 1;
    }
}
