using HeroUp.Models.Heroes;

namespace HeroUp.Services.Interfaces
{
    public interface IHeroService
    {
        public HeroBase CreateBruiser(string name);
        public HeroBase CreateAssasin(string name);
        public HeroBase CreateMage(string name);
        public HeroBase CreateTank(string name);
        public HeroBase CreateSupport(string name);

        public void UpdateHero(HeroBase hero);

        public Assasin GetMyAssasin();
        public Support GetMySupport();
    }
}
