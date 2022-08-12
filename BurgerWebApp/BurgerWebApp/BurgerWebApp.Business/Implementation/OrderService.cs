using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.Business.Mappers;
using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;


namespace BurgerWebApp.Business.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly ICartService _cartService;
        private readonly IRepository<Location> _locationRepository;
        private readonly IBurgerService _burgerService;
        public OrderService(IRepository<Order> orderRepository, ICartService cartService, IRepository<Location> locationRepository, IBurgerService burgerService)
        {
            _orderRepository = orderRepository;
            _cartService = cartService;
            _locationRepository = locationRepository;
            _burgerService = burgerService;
        }
        public void Add(OrderViewModel viewModel)
        {
            Order order = new Order();
            order.Name = viewModel.Name;
            order.LastName = viewModel.LastName;
            order.CartId = viewModel.CartId;
            order.Address = viewModel.Address;
            order.TotalPrice = _cartService.GetCart(viewModel.CartId).FullPrice;
            order.Location = _locationRepository.GetEntity(viewModel.LocationId);
            order.IsDelivered = viewModel.IsDelivered;
            order.Date = viewModel.Date;
            _orderRepository.Add(order);
        }

        public void Delete(int id)
        {
            Order order = _orderRepository.GetEntity(id);
            _orderRepository.Delete(order);
        }

        public List<OrderViewModel> GetAllOrders()
        {
            return _orderRepository.GetAll().Select(order => order.ToViewModel()).ToList();
        }

        public OrderViewModel GetOrder(int? id)
        {
            return _orderRepository.GetEntity(id).ToViewModel();
        }

        public BurgerOrderViewModel ReturnBurgerOrderModel(BurgerOrderViewModel model)
        {
            BurgerViewModel burgerModel = _burgerService.GetBurger(model.BurgerId);
            BurgerOrderViewModel burgerOrderModel = new BurgerOrderViewModel();
            burgerOrderModel.Selected = true;
            burgerOrderModel.BurgerId = burgerModel.Id;
            burgerOrderModel.Burger = burgerModel;
            return burgerOrderModel;
        }

        public void Update(OrderViewModel viewModel)
        {
            Order order = new Order(
                viewModel.Name,
                viewModel.LastName,
                viewModel.Address,
                true,
                viewModel.Location.Id,
                viewModel.CartId,
                viewModel.TotalPrice)
            { Id = viewModel.Id };
            _orderRepository.Update(order);
        }

    }
}
