using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.Business.Mappers
{
    public static class ExtraMapper
    {
        public static ExtraViewModel ToViewModel(this Extra extra)
        {
            return new ExtraViewModel
            {
                Id = extra.Id,
                Image = extra.Image,
                Name = extra.Name,
                SizeId = extra.SizeId.ToViewModel()
            };
        }
    }
}
