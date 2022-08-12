using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Mappers
{
    public static class CartMapper
    {
        public static CartViewModel ToViewModel(this Cart cart)
        {
            return new CartViewModel
            {
                Id = cart.Id,
                BurgerOrders = cart.BurgerOrders.Select(burger => burger.ToViewModel()).ToList(),
                Extras = cart.Extras == null ? new List<ExtrasOrderViewModel>() : cart.Extras.Select(extra => extra.ToViewModel()).ToList(),
                FullPrice = cart.FullPrice

            };
        }
    }
}
