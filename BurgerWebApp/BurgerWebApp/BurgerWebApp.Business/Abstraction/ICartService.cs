using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Abstraction
{
    public interface ICartService
    {
        CartViewModel GetCart(int id);
        List<CartViewModel> GetAllCarts();
        void Delete(int id);
        int Add(CartViewModel cart);
    }
}
