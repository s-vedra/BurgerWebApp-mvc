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
        public static ExtrasOrderViewModel ToViewModel(this ExtrasOrder extraorder)
        {
            return new ExtrasOrderViewModel
            {
                Id = extraorder.Id,
                ExtraId = extraorder.ExtraId,
                Selected = extraorder.Selected,
                Quantity = extraorder.Quantity,
                FullPrice = extraorder.FullPrice
            };
        }
    }
}
