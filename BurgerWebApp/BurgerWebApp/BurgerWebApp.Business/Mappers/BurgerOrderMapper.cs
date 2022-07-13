using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                CartId = burgerOrder.CartId
            };
        }
    }
}
    