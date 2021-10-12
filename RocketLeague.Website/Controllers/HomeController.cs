using Microsoft.AspNetCore.Mvc;
using RocketLeague.Website.Interactors;

namespace RocketLeague.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRocketLeagueInteractor _rocketLeagueInteractor;

        public HomeController(IRocketLeagueInteractor rocketLeagueInteractor)
        {
            _rocketLeagueInteractor = rocketLeagueInteractor;
        }

        public IActionResult Index()
        {
            var vm = _rocketLeagueInteractor.GetViewModel();
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
