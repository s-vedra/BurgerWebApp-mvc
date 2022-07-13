using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                CartId = extraOrder.CartId
            };
        }
    }
}
