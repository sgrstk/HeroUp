using HeroUp.Models.Heroes;
using HeroUp.Models.Terrains;

namespace HeroUp.Services.Interfaces
{
    public interface IFigthingService
    {
        public HeroBase Fight(HeroBase hero1, HeroBase hero2);

        public HeroBase Fight(HeroBase hero1, HeroBase hero2, TerrainBase terrain);
        //public void Fight(Team team1, Team team2)
    }
}
