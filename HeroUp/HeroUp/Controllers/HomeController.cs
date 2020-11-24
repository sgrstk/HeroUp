using HeroUp.Models;
using HeroUp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace HeroUp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHeroService _heroService;

        public HomeController(ILogger<HomeController> logger, IHeroService heroService)
        {
            _logger = logger;
            _heroService = heroService;
        }

        public IActionResult Index()
        {
            //var assasin = _heroService.CreateAssasin("dorel");
            //var bruiser = _heroService.CreateBruiser("ionut");
            //_heroService.Fight(assasin, bruiser);

            return View(_heroService.GetAllAssassins());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        /// Nota: sa iti instalezi SSMS(lasai pagina deschisa), iti facui eu clona la repo, nu trebuia sa ii dai download ci clone
        ///         intre timp, poti sa vezi tabelele si din visual studio
        ///Homework
        /// - implement all hero classes DONE
        /// - implement attack and defence based on different stats(see dodge chance) (DONE)
        /// - add fighting terrain 
        /// - enrich Fight from service using terrain
        /// - add terrain effects
        /// - add gain xp on win
        /// - implement level up 
        /// extra: think about match history

    }
}
