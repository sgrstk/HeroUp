namespace HeroUp.Models.Heroes
{
    public class Bruiser : HeroBase
    {
        public Bruiser(string name): base(name)
        {
            HP = 1300;
            MP = 700;
            Def = 150;
            Power = 80;
            Dexterity = 60;
            HeroCategory = Enums.HeroCategory.Bruiser;
        }

        public override void Defence(HeroBase attackerHero)
        {
            HP += ((Def * 0.2) - attackerHero.Power);
        }
    }
}
