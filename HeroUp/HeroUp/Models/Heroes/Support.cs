using System;


namespace HeroUp.Models.Heroes
{
    public class Support : HeroBase
    {
        public Support(string name) : base(name)
        {
            HP = 950;
            MP = 800;
            Def = 60;
            Power = 40;
            Agility = 35;
            Intelligence = 30;
            Dexterity = 15;
            HeroCategory = Enums.HeroCategory.Support;
        }

        public override void Defence(HeroBase attackerHero)
        {
            // this is an ability
            // 10% dodge chance
            var dodgeChange = new Random(99);
            if (dodgeChange.Next() >= 0)
            {
                HP += ((Def * 0.15) - attackerHero.Power);
            }
        }
    }
    }
