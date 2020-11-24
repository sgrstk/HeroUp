using System;


namespace HeroUp.Models.Heroes
{
    public class Mage : HeroBase
    {
        public Mage(string name) : base(name)
        {
            HP = 1200;
            MP = 850;
            Def = 85;
            Power = 120;
            Agility = 40;
            Intelligence = 75;
            Dexterity = 25;
            HeroCategory = Enums.HeroCategory.Mage;
        }
        public override void Defence(HeroBase attackerHero)
        {
            // this is an ability
            // 10% dodge chance
            var dodgeChange = new Random(99);
            if (dodgeChange.Next() >= 5)
            {
                HP += ((Def * 0.20) - attackerHero.Power);
            }
        }
    }
}
