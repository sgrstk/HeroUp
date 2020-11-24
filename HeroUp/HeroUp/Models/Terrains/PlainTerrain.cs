using HeroUp.Models.Heroes;
using HeroUp.Terrains.Enums;
using System.Collections.Generic;

namespace HeroUp.Models.Terrains
{
    public class PlainTerrain : TerrainBase
    {
        public PlainTerrain()
        {
            TerrainCategory = TerrainCategory.infernal;
        }

        public override void ApplyEffects(List<HeroBase> heroes)
        {
        }
    }
}
