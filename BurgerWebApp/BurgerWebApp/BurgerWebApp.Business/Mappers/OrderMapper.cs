using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.Business.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToViewModel(this Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                Name = order.Name,
                LastName = order.LastName,
                Address = order.Address,
                LocationId = order.LocationId,
                CartId = order.CartId,
                TotalPrice = order.TotalPrice
            };
        }
    }
}
