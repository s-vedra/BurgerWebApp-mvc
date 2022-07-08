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
                Extras = cart.Extras.Select(extra => extra.ToViewModel()).ToList(),
            };
        }
    }
}
