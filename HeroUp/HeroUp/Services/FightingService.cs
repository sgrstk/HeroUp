using HeroUp.Models.Heroes;
using HeroUp.Services.Interfaces;

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
    }
}
