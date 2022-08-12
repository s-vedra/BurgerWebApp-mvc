using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.Business.Mappers;
using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Implementation
{
    public class CartService : ICartService
    {
        private readonly IBurgerService _burgerService;
        private readonly IExtraService _extraService;
        private readonly IRepository<Cart> _cartRepository;
        private readonly IRepository<Burger> _burgerRepository;
        private readonly IRepository<Extra> _extraRepository;
        public CartService(IBurgerService burgerService, IExtraService extraService, IRepository<Cart> cartRepository, IRepository<Burger> burgerRepository, IRepository<Extra> extraRepository)
        {
            _burgerService = burgerService;
            _extraService = extraService;
            _cartRepository = cartRepository;
            _burgerRepository = burgerRepository;
            _extraRepository = extraRepository;
        }

        public int Add(CartViewModel cartModel)
        {
            List<BurgerOrder> burgerOrders = GetBurgerOrders(cartModel.BurgerOrderCheckbox.Where(x => x.Selected).ToList());
            foreach (var item in cartModel.BurgerOrders)
            {
                BurgerOrder order = new BurgerOrder()
                {
                    Burger = _burgerRepository.GetEntity(item.BurgerId),
                    BurgerId = item.BurgerId,
                    Quantity = item.Quantity,
                    Selected = item.Selected
                };
                order.Price = order.Burger.Price * order.Quantity;
                burgerOrders.Add(order);
            }
            if (cartModel.Extras.Where(x => x.Selected).ToList().Count != 0)
            {
                List<ExtrasOrder> extraOrders = GetExtraOrders(cartModel.Extras.Where(x => x.Selected).ToList());
                Cart cart = new Cart()
                {
                    BurgerOrders = burgerOrders,
                    Extras = extraOrders
                };
                cart.FullPrice = burgerOrders.Select(x => x.Price).Sum() + extraOrders.Select(x => x.Price).Sum();
                _cartRepository.Add(cart);
                return cart.Id;
            }
            else
            {
                Cart cart = new Cart()
                {
                    BurgerOrders = burgerOrders
                };
                _cartRepository.Add(cart);
                cart.FullPrice = burgerOrders.Select(x => x.Price).Sum();
                return cart.Id;
            }
        }
        private List<BurgerOrder> GetBurgerOrders(List<BurgerOrderViewModelCheckbox> burgerModelOrders)
        {
            List<BurgerOrder> burgerOrders = new List<BurgerOrder>();
            foreach (var item in burgerModelOrders)
            {
                BurgerOrder burgerOrder = new BurgerOrder()
                {
                    Burger = _burgerRepository.GetEntity(item.BurgerId),
                    BurgerId = item.BurgerId,
                    Quantity = item.Quantity,
                    Selected = item.Selected,
                };
                burgerOrder.Price = burgerOrder.Burger.Price * burgerOrder.Quantity;
                burgerOrders.Add(burgerOrder);
            }
            return burgerOrders;
        }

        private List<ExtrasOrder> GetExtraOrders(List<ExtrasOrderViewModel> extrasOrderViewModels)
        {
            List<ExtrasOrder> extraOrders = new List<ExtrasOrder>();
            foreach (var item in extrasOrderViewModels)
            {
                ExtrasOrder extraOrder = new ExtrasOrder()
                {
                    Extra = _extraRepository.GetEntity(item.ExtraId),
                    Quantity = item.Quantity,
                    Selected = item.Selected
                };
                extraOrder.Price = extraOrder.Extra.Size.Price * extraOrder.Quantity;
                extraOrders.Add(extraOrder);
            }
            return extraOrders;
        }
        public void Delete(int id)
        {
            Cart cart = _cartRepository.GetEntity(id);
            _cartRepository.Delete(cart);
        }

        public List<CartViewModel> GetAllCarts()
        {
            return _cartRepository.GetAll().Select(cart => cart.ToViewModel()).ToList();

        }

        public CartViewModel GetCart(int id)
        {
            return _cartRepository.GetEntity(id).ToViewModel();
        }

    }
}
