using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Mappers
{
    public static class ExtraOrderMapper
    {
        public static ExtrasOrderViewModel ToViewModel(this ExtrasOrder extraOrder)
        {
            return new ExtrasOrderViewModel
            {
                Id = extraOrder.Id,
                ExtraId = extraOrder.ExtraId,
                Selected = extraOrder.Selected,
                Quantity = extraOrder.Quantity,
                CartId = extraOrder.CartId,
                Price = extraOrder.Price,
                Extra = extraOrder.Extra.ToViewModel()
            };
        }
    }
}
