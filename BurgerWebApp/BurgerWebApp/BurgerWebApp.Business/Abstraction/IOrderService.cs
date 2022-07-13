using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Abstraction
{
    public interface IOrderService
    {
        OrderViewModel GetOrder(int? id);
        List<OrderViewModel> GetAllOrders();
        void Delete(int id);
        void Add(OrderViewModel viewModel);
        bool ValidateInputs(OrderViewModel viewModel);
        void Update(OrderViewModel viewModel);
    }
}
