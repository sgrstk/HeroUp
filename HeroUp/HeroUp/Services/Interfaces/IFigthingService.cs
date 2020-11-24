using HeroUp.Models.Heroes;

namespace HeroUp.Services.Interfaces
{
    public interface IFigthingService
    {
        public HeroBase Fight(HeroBase hero1, HeroBase hero2);
        //public void Fight(Team team1, Team team2)
    }
}
