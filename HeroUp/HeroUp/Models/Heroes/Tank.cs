using System;


namespace HeroUp.Models.Heroes
{
    public class Tank : HeroBase
    {
        public Tank(string name) : base(name)
        {
            HP = 1400;
            MP = 650;
            Def = 100;
            Power = 45;
            Agility = 20;
            Intelligence = 30;
            Dexterity = 35;
            HeroCategory = Enums.HeroCategory.Tank;
        }

        public override void Defence(HeroBase attackerHero)
        {
            HP += ((Def * 0.10) - attackerHero.Power);
        }

        public override void LevelUp()
        {
            HP += 100;
            MP += 20;
            Def += 40;
            Power += 10;
            Intelligence += 10;
            base.LevelUp();
        }
    }
}
