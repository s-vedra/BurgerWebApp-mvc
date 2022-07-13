using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                FullPrice = cart.BurgerOrders.Sum(x => x.Quantity * x.Burger.Price) + cart.Extras.Sum(x => x.Quantity * x.Extra.Size.Price)
               
            };
        }
    }
}
