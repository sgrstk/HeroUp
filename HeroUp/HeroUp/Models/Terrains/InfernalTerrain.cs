using HeroUp.Models.Heroes;
using HeroUp.Terrains.Enums;
using System.Collections.Generic;

namespace HeroUp.Models.Terrains
{
    public class InfernalTerrain : TerrainBase
    {
        public InfernalTerrain()
        {
            TerrainCategory = TerrainCategory.infernal;
        }

        public override void ApplyEffects(List<HeroBase> heroes)
        {
            foreach(var hero in heroes)
            {
                hero.HP += 10;
                hero.MP += 10;
                hero.Def += 10;
                hero.Power += 10;
                hero.Agility += 10;
                hero.Intelligence += 10;
                hero.Dexterity += 10;
            }
        }
    }
}
