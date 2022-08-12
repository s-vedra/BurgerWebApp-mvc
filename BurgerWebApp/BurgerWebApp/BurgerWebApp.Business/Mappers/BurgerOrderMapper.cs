using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Mappers
{
    public static class BurgerOrderMapper
    {
        public static BurgerOrderViewModel ToViewModel(this BurgerOrder burgerOrder)
        {
            return new BurgerOrderViewModel
            {
                Id = burgerOrder.Id,
                BurgerId = burgerOrder.BurgerId,
                Selected = burgerOrder.Selected,
                Quantity = burgerOrder.Quantity,
                CartId = burgerOrder.CartId,
                Burger = burgerOrder.Burger.ToViewModel(),
                Price = burgerOrder.Price
            };
        }
    }
}
