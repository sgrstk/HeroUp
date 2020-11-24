using HeroUp.Models.Heroes;
using HeroUp.Terrains.Enums;
using System.Collections.Generic;

namespace HeroUp.Models.Terrains
{
    public abstract class TerrainBase
    {
        public TerrainCategory TerrainCategory { get; set;}

        public abstract void ApplyEffects(List<HeroBase> heroes);
    }
}
