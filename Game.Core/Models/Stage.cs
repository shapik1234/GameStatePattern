namespace Game.Core.Models
{
    public abstract class Stage
    {
        protected Stage(string name, Character character)
        {
            Name = name;
            Character = character;
        }

        public string Name { get; }

        protected Character Character { get; }

        public abstract Stage Next();
    }
}
