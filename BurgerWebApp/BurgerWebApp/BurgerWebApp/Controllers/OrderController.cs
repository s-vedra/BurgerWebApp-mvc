using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public IActionResult CreateCartViewCart(int? id)
        {
            ViewBag.BurgerViewModels = _burgerService.GetAllBurgers();
            ViewBag.ExtraViewModels = _extraService.GetAllExtraItems();
            if (id.HasValue)
            {
                return RedirectToAction("Details", new { id = id });
            }
            else
            {
                return View(new CartViewModel());
            }

        }

        [HttpPost]
        public IActionResult AddToCart(CartViewModel model)
        {
            if (_cartService.ValidateInputChecks(model))
            {
                ViewBag.Cart = _cartService.GetCart(_cartService.Add(model));
                List<SelectListItem> selectList = _locationService.GetAll().Select(item => new SelectListItem(item.Name, item.Id.ToString())).ToList();
                ViewBag.Locations = selectList;
                return View(new OrderViewModel());
            }
            else
            {
                throw new Exception("Please check atleast one product");
            }

        }
        public IActionResult Details(int id)
        {
            CartViewModel cart = _cartService.GetCart(id);
            ViewBag.Burgers = _cartService.GetBurgers(cart);
            ViewBag.Extras = _cartService.GetExtraItems(cart);
            return View(cart);
        }

        [HttpPost]
        public IActionResult SaveOrder(OrderViewModel model)
        {
            if (_orderService.ValidateInputs(model))
            {
                _orderService.Add(model);
                return RedirectToAction("Index", "Order");
            }
            else
            {
                throw new Exception("All inputs must be filled");
            }

        }

        public IActionResult DeleteOrder(int id)
        {
            OrderViewModel order = _orderService.GetOrder(id);
            _cartService.Delete(order.CartId);
            _orderService.Delete(id);
            return RedirectToAction("Index", "Order");
        }
    }

}
