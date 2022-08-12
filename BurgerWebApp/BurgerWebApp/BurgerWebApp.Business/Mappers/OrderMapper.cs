﻿using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

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
                CartId = order.CartId,
                Location = order.Location.ToViewModel(),
                TotalPrice = order.TotalPrice,
                IsDelivered = order.IsDelivered,
                Cart = order.Cart.ToViewModel(),
                LocationId = order.LocationId,
                Date = order.Date

            };
        }
    }
}
