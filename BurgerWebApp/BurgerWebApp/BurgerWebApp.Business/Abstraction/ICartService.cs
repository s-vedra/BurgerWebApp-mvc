using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Abstraction
{
    public interface ICartService
    {
        CartViewModel GetCart(int? id);
        List<CartViewModel> GetAllCarts();
        List<ExtrasOrderViewModel> GetExtraOrders(CartViewModel cart);
        List<BurgerOrderViewModel> GetBurgerOrders(CartViewModel cart);
        bool ValidateInputChecks(CartViewModel viewModel);
        void Delete(int id);
        int Add(CartViewModel burger);
        List<BurgerViewModel> GetBurgers(CartViewModel viewModel);
        List<ExtraViewModel> GetExtraItems(CartViewModel viewModel);
    }
}
