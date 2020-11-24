using System;

namespace HeroUp.Models.Heroes
{
    public class Assasin : HeroBase
    {
        public Assasin(string name) : base(name)
        {
            HP = 1100;
            MP = 700;
            Def = 100;
            Power = 140;
            Agility = 45;
            Intelligence = 45;
            Dexterity = 20;
            HeroCategory = Enums.HeroCategory.Assasin;
        }

        public override void GetToFullStats()
        {
            HP = 1100 + (70 * (Level - 1));
            MP = 700 + (40 * (Level - 1));
            Def = 100 + (20 * (Level - 1));
            Power = 140 + (20 * (Level - 1));
            Agility = 45;
            Intelligence = 45 + (20 * (Level - 1));
            Dexterity = 20;
        }

        public override void Defence(HeroBase attackerHero)
        {
            // this is an ability
            // 10% dodge chance
            var dodgeChange = new Random(99);
            if (dodgeChange.Next() >= 10)
            {
                HP += ((Def * 0.15) - attackerHero.Power);
            }
        }

        public override void LevelUp()
        {
            HP += 70 * Level;
            MP += 40 * Level;
            Def += 20 * Level;
            Power += 20 * Level;
            Intelligence += 20 * Level;
            base.LevelUp();
        }
    }
}
