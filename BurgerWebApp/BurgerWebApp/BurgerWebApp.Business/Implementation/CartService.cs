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
        public CartService(IBurgerService burgerService, IExtraService extraService, IRepository<Cart> cartRepository)
        {
            _burgerService = burgerService;
            _extraService = extraService;
            _cartRepository = cartRepository;
        }

        public int Add(CartViewModel burger)
        {
            List<BurgerOrder> burgers = new List<BurgerOrder>();
            List<ExtrasOrder> extras = new List<ExtrasOrder>();
            foreach (var item in GetBurgerOrders(burger))
            {
                burgers.Add(new BurgerOrder(item.BurgerId, item.Quantity, item.Selected));
            }
            foreach (var item in GetExtraOrders(burger))
            {
                extras.Add(new ExtrasOrder(item.ExtraId, item.Quantity, item.Selected));
            }
            Cart cart = new Cart( burgers, extras);
            _cartRepository.Add(cart);
            return cart.Id;
        }

        public void Delete(int id)
        {
            Cart cart = _cartRepository.GetEntity(id);
            _cartRepository.Delete(cart);
        }

        public List<CartViewModel> GetAllCarts()
        {
            List<CartViewModel> carts = _cartRepository.GetAll().Select(cart => cart.ToViewModel()).ToList();
            if (carts.Count != 0)
            {
                return carts;
            }
            else
            {
                throw new Exception("Cart doesn't exist");
            }
        }

        public List<BurgerOrderViewModel> GetBurgerOrders(CartViewModel cart)
        {
            return cart.BurgerOrders.Where(b => b.Selected).ToList();
        }

        public List<BurgerViewModel> GetBurgers(CartViewModel viewModel)
        {
            List<BurgerViewModel> burgerViewModels = new List<BurgerViewModel>();
            foreach (var item in GetBurgerOrders(viewModel))
            {
                burgerViewModels.Add(_burgerService.GetBurger(item.BurgerId));
            }
            return burgerViewModels;
        }

        public CartViewModel GetCart(int? id)
        {
            Cart? cart = _cartRepository.GetEntity(id);
            if (cart == null)
            {
                throw new Exception("Item doesn't exist");
            }
            else
            {
                return cart.ToViewModel();
            }
        }

        public List<ExtraViewModel> GetExtraItems(CartViewModel viewModel)
        {
            List<ExtraViewModel> extrasViewModel = new List<ExtraViewModel>();
            foreach (var item in GetExtraOrders(viewModel))
            {
                extrasViewModel.Add(_extraService.GetExtraItem(item.ExtraId));
            }
            return extrasViewModel;
        }

        public List<ExtrasOrderViewModel> GetExtraOrders(CartViewModel cart)
        {
            return cart.Extras.Where(e => e.Selected).ToList();
        }

        public bool ValidateInputChecks(CartViewModel viewModel)
        {
            if (viewModel.BurgerOrders.Where(b => b.Selected).Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
