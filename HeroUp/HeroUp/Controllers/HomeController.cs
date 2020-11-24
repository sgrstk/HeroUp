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
        private readonly IFigthingService _figthingService;

        public HomeController(ILogger<HomeController> logger, IHeroService heroService, IFigthingService figthingService)
        {
            _logger = logger;
            _heroService = heroService;
            _figthingService = figthingService;
        }

        public IActionResult Index()
        {
            var assasin = _heroService.GetMyAssasin();
            var support = _heroService.GetMySupport();
            var winner = _figthingService.Fight(assasin, support);

            _heroService.UpdateHero(winner);
            return View();
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

        ///Homework
        /// - add dexerity to defence formula
        /// - add agility si inteliggence to attack
        /// - enrich Fight from service using terrain
        /// - add gain xp on win
        /// extra: think about match history

    }
}
