using HeroUp.Models.Heroes;
using HeroUp.Models.Terrains;
using HeroUp.Services.Interfaces;
using System.Collections.Generic;

namespace HeroUp.Services
{
    public class FightingService : IFigthingService
    {
        public HeroBase Fight(HeroBase hero1, HeroBase hero2)
        {
            while (!hero1.IsDead || !hero2.IsDead)
            {
                hero2.Defence(hero1);
                if (hero2.IsDead)
                {
                    break;
                }
                hero1.Defence(hero2);
            }

            if (hero1.IsDead)
            {
                hero2.GainExp(25);
            }
            else
            {
                hero1.GainExp(25);
            }

            hero1.GetToFullStats();
            hero2.GetToFullStats();

            return hero1.IsDead ? hero2 : hero1;
        }

        public HeroBase Fight(HeroBase hero1, HeroBase hero2, TerrainBase terrain)
        {
            terrain.ApplyEffects(new List<HeroBase> { hero1, hero2 });
            return Fight(hero1, hero2);
        }
    }
}
