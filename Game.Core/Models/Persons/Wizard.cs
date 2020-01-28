namespace Game.Core.Models
{
    public class Wizard : Character
    {
        public Wizard(int life, int mana)
            : base(life, mana, new PikeStaff(), new WizardBag())
        {
        }
    }
}
