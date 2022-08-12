using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Abstraction
{
    public interface IOrderService
    {
        OrderViewModel GetOrder(int? id);
        List<OrderViewModel> GetAllOrders();
        BurgerOrderViewModel ReturnBurgerOrderModel(BurgerOrderViewModel model);
        void Delete(int id);
        void Add(OrderViewModel viewModel);
        void Update(OrderViewModel viewModel);
    }
}
