using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BurgerWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBurgerService _burgerService;
        private readonly IExtraService _extraService;

        public HomeController(ILogger<HomeController> logger, IBurgerService burgerService, IExtraService extraService)
        {
            _logger = logger;
            _burgerService = burgerService;
            _extraService = extraService;
        }

        public IActionResult Index()
        {
            ViewBag.Exras = _extraService.GetAllExtraItems().Where(x => x.Name == "Small Fries" || x.Name == "Small Coke");
            return View(_burgerService.GetAllBurgers());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}