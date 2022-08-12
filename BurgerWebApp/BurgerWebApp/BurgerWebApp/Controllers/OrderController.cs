using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace BurgerWebApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IBurgerService _burgerService;
        private readonly ICartService _cartService;
        private readonly IExtraService _extraService;
        private readonly ILocationService _locationService;
        public OrderController(IOrderService orderService,
                               IBurgerService burgerService,
                               ICartService cartService,
                               IExtraService extraService,
                               ILocationService locationService)
        {
            _orderService = orderService;
            _burgerService = burgerService;
            _cartService = cartService;
            _extraService = extraService;
            _locationService = locationService;
        }
        public IActionResult Index()
        {
            ViewBag.Locations = _locationService.GetAll();
            return View(_orderService.GetAllOrders());
        }
        public IActionResult GetBurgerOrder(int id)
        {
            return RedirectToAction("CreateCartModel", new BurgerOrderViewModel() { BurgerId = id});
        }
        public IActionResult CreateCartModel(BurgerOrderViewModel model)
        {
            ViewBag.BurgerViewModels = _burgerService.GetAllBurgers().Where(x => x.Id != model.BurgerId).ToList();
            ViewBag.ExtraViewModels = _extraService.GetAllExtraItems();
            return View(new CartViewModel() { BurgerOrders = new List<BurgerOrderViewModel>() { _orderService.ReturnBurgerOrderModel(model) } });
        }

        [HttpPost]
        public IActionResult AddToCart(CartViewModel model)
        {
            int id = _cartService.Add(model);
            ViewBag.Locations = _locationService.GetAll().Select(item => new SelectListItem(item.Name, item.Id.ToString())).ToList();
            return View(new OrderViewModel() { CartId = id});

        }
        public IActionResult AddToCart(OrderViewModel model)
        {
            ViewBag.Locations = _locationService.GetAll().Select(item => new SelectListItem(item.Name, item.Id.ToString())).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult SaveOrder(OrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                _orderService.Add(model);
                return RedirectToAction("Index", "Order");
            }
            else
            {
                return RedirectToAction("AddToCart", model);
            }

        }
        public IActionResult Details(int id)
        {
            return View(_orderService.GetOrder(id));
        }
        public IActionResult DeleteOrder(int id)
        {
            OrderViewModel order = _orderService.GetOrder(id);
            _cartService.Delete(order.CartId);
            return RedirectToAction("Index", "Order");
        }
        public IActionResult ConfirmDelivery(int id)
        {
            OrderViewModel order = _orderService.GetOrder(id);
            _orderService.Update(order);
            
            return RedirectToAction("Details" , new {id = order.Id });
        }
        public IActionResult Search(string id)
        {
            if (!int.TryParse(id, out int output))
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (_orderService.GetAllOrders().Any(x => x.Id == output))
                {
                    return View(_orderService.GetOrder(output));
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
    }

}
