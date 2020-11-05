using HeroUp.Models.Heroes;
using System.Collections.Generic;

namespace HeroUp.Services.Interfaces
{
    public interface IHeroService
    {
        public HeroBase CreateBruiser(string name);
        public HeroBase CreateAssasin(string name);
        public List<HeroBase> GetAllAssassins();
        public void Fight(HeroBase champ1, HeroBase champ2);
    }
}
