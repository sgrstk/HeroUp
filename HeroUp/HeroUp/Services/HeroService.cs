using HeroUp.Models;
using HeroUp.Models.Enums;
using HeroUp.Models.Heroes;
using HeroUp.Repository;
using HeroUp.Services.Interfaces;
using System.Collections.Generic;

namespace HeroUp.Services
{
    public class HeroService : IHeroService
    {
        private readonly IRepository<HeroBase> _heroRepository;

        public HeroService(IRepository<HeroBase> heroRepository)
        {
            _heroRepository = heroRepository;
        }

        public HeroBase CreateAssasin(string name)
        {
            var newAssasin = new Assasin(name);
            _heroRepository.Insert(newAssasin);
            return newAssasin;
        }

        public HeroBase CreateBruiser(string name)
        {
            var newBruiser = new Bruiser(name);
            _heroRepository.Insert(newBruiser);
            return newBruiser;
        }

        public HeroBase CreateMage(string name)
        {
            var newMage = new Mage(name);
            _heroRepository.Insert(newMage);
            return newMage;
        }

        public HeroBase CreateSupport(string name)
        {
            var newSupport = new Support(name);
                _heroRepository.Insert(newSupport);
            return newSupport;
        }

        public HeroBase CreateTank(string name)
        {
            var newTank = new Tank(name);
            _heroRepository.Insert(newTank);
            return newTank;
        }
        public void Fight(HeroBase champ1, HeroBase champ2)
        {
            champ2.Defence(champ1);
            champ1.Defence(champ2);
        }

        public List<HeroBase> GetAllAssassins()
        {
            return _heroRepository.GetAllBy(h => h.HeroCategory == HeroCategory.Assasin);
        }
    }
}
