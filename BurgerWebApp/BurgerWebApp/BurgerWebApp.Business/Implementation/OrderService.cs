using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.Business.Mappers;
using BurgerWebApp.DataAccess;
using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;


namespace BurgerWebApp.Business.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly ICartService _cartService;
        public OrderService(IRepository<Order> orderRepository, ICartService cartService)
        {
            _orderRepository = orderRepository;
            _cartService = cartService;
        }
        public void Add(OrderViewModel viewModel)
        {
            Order order = new Order();
            order.Name = viewModel.Name;
            order.LastName = viewModel.LastName;
            order.CartId = viewModel.CartId;
            order.Address = viewModel.Address;
            order.TotalPrice = _cartService.GetCart(viewModel.CartId).FullPrice;
            order.LocationId = viewModel.LocationId;
            order.IsDelivered = viewModel.IsDelivered;
          _orderRepository.Add(order);
        }

        public void Delete(int id)
        {
          Order order =  _orderRepository.GetEntity(id);
            _orderRepository.Delete(order);
        }

        public List<OrderViewModel> GetAllOrders()
        {
            return _orderRepository.GetAll().Select(order => order.ToViewModel()).ToList();
        }

        public OrderViewModel GetOrder(int? id)
        {
            Order? order = _orderRepository.GetEntity(id);
            if (order == null)
            {
                throw new Exception("Item doesn't exist");
            }
            else
            {
                return order.ToViewModel();
            }
        }
        public bool ValidateInputs(OrderViewModel viewModel)
        {
            if (string.IsNullOrEmpty(viewModel.Name) || string.IsNullOrEmpty(viewModel.LastName) || string.IsNullOrEmpty(viewModel.Address) || viewModel.LocationId == 0)
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
