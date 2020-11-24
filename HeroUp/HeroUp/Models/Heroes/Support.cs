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

        public override void GetToFullStats()
        {
            HP = 950 + (60 * (Level - 1));
            MP = 800 + (40 * (Level - 1));
            Def = 60 + (20 * (Level - 1));
            Power = 40 + (10 * (Level - 1));
            Agility = 35;
            Intelligence = 30 + (10 * (Level - 1));
            Dexterity = 15;
        }

        public override void Defence(HeroBase attackerHero)
        {
            HP += ((Def * 0.15) - attackerHero.Power);
        }

        public override void LevelUp()
        {
            HP += 60;
            MP += 40;
            Def += 20;
            Power += 10;
            Intelligence += 10;
            base.LevelUp();
        }
    }
}
