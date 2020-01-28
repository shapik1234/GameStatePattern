namespace Game.Core.Models
{
    public class Weapon
    {
        protected Weapon(string title)
        {
            Title = title;
        }

        public string Title { get; }

        public int Damage { get; }

        public override string ToString()
        {
            return Title;
        }
    }
}
