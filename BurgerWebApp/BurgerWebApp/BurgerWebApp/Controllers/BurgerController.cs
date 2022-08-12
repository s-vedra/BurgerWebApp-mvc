using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerWebApp.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerService _burgerService;
        private readonly IExtraService _extraService;
        public BurgerController(IBurgerService burgerService, IExtraService extraService)
        {
            _burgerService = burgerService;
            _extraService = extraService;
        }
        public IActionResult Index()
        {
            return View(_burgerService.GetAllBurgers());
        }
        public IActionResult Details(BurgerViewModel model)
        {
            ViewBag.ExtraItems = _extraService.GetAllExtraItems();
            return View(_burgerService.Details(model));
        }
        public IActionResult AddOrEditBurgerMenu(int? id)
        {
            if (id.HasValue)
            {
                BurgerViewModel? burger = _burgerService.GetBurger(id);
                if (burger == null)
                {
                    return RedirectToAction("Index", "Burger");
                }
                else
                {
                    return View(burger);
                }
            }
            return View(new BurgerViewModel());
        }
        [HttpPost]
        public IActionResult AddOrEditBurgerMenu(BurgerViewModel model)
        {
            if (ModelState.IsValid)
            {
                    if (model.Id == 0)
                    {

                        _burgerService.Add(model);
                        return RedirectToAction("Index", "Burger");
                    }
                    else
                    {
                        _burgerService.Update(model);
                        return RedirectToAction("Index", "Burger");
                    }
            }
            else
            {
                return View(model);
            }

        }
        public IActionResult DeleteBurger(int id)
        {
            _burgerService.Delete(id);
            return RedirectToAction("Index", "Burger");
        }

        public IActionResult Search(string id)
        {
            if (string.IsNullOrEmpty(id) || !_burgerService.GetAllBurgers().Any(burger => burger.Name.ToLower().Contains(id.ToLower())))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(_burgerService.GetAllBurgers().Where(burger => burger.Name.ToLower().Contains(id.ToLower())).ToList());
            }
        }

    }
}
