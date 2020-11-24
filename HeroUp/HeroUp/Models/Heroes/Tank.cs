﻿using System;


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
            // this is an ability
            // 10% dodge chance
            var dodgeChange = new Random(99);
            if (dodgeChange.Next() >= 0)
            {
                HP += ((Def * 0.10) - attackerHero.Power);
            }
        }
    }
}
