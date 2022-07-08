using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerWebApp.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerService _burgerService;
        public BurgerController(IBurgerService burgerService)
        {
            _burgerService = burgerService;
        }
        public IActionResult Index()
        {
            return View(_burgerService.GetAllBurgers());
        }
        public IActionResult Details(BurgerViewModel model)
        {
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
        public IActionResult SaveBurgerMenu(BurgerViewModel model)
        {
            if (_burgerService.ValidateInputs(model))
            {
                if (_burgerService.GetAllBurgers().Any(burger => burger.Name.ToLower() == model.Name.ToLower() && burger.Id != model.Id))
                {
                    return RedirectToAction("Index", "Burger");
                }
                else
                {
                    if (model.Id == 0)
                    {

                        _burgerService.Add(model);
                    }
                    else
                    {
                        _burgerService.Update(model);
                    }
                }
                return RedirectToAction("Index", "Burger");
            }
            else
            {
                throw new Exception("All inputs must be filled");
            }

        }
        public IActionResult DeleteBurger(int id)
        {
            _burgerService.Delete(id);
            return RedirectToAction("Index", "Burger");
        }

        public IActionResult Search(string id)
        {
            return View(_burgerService.SearchOption(id));
        }

    }
}
