using HeroUp.Models.Generic;
using HeroUp.Models.Enums;
using Microsoft.AspNetCore.SignalR;
using HeroUp.Terrains.Enums;

namespace HeroUp.Models.Terrains
{
    public class TerrainBase : Entity
    {
        public TerrainBase(string name)
        {
            Name = name;

        }
        public string Name { get; set; }
        public TerrainCategory TerrainCategory {get; set;}

        
    }
}
