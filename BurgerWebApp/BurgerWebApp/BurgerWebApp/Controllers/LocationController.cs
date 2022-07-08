using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerWebApp.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        public IActionResult Index()
        {
            return View(_locationService.GetAll());
        }
        public IActionResult EditOrAddLocation(int? id)
        {
            if (id.HasValue)
            {
               LocationViewModel location = _locationService.GetLocation(id);
                if (location == null)
                {
                    return RedirectToAction("Index", "Location");
                }
                else
                {
                    return View(location);
                }
            }
            else
            {
                return View(new LocationViewModel());
            }
            
        }
        [HttpPost]
        public IActionResult SaveLocation(LocationViewModel model)
        {
            if (_locationService.ValidateInputs(model))
            {
                if (_locationService.GetAll().Any(l => l.Name.ToLower() == model.Name.ToLower() && l.Id != model.Id))
                {
                    return RedirectToAction("Index", "Location");
                }
                else
                {
                    if (model.Id == null)
                    {
                        _locationService.Add(model);
                    }
                    else
                    {
                        _locationService.Update(model);
                    }
                    return RedirectToAction("Index", "Location");
                }
            }
            else
            {
                throw new Exception("All inputs must be filled");
            }
            
            
        }
        public IActionResult DeleteLocation(int id)
        {
            LocationViewModel location = _locationService.GetLocation(id);
            _locationService.Delete(location.Id);
            return RedirectToAction("Index","Location");
        }
        public IActionResult Details(int id)
        {
            return View(_locationService.GetLocation(id));
        }
    }
}
