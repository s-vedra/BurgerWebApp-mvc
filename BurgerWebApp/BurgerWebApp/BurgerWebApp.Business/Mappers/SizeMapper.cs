using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Mappers
{
    public static class SizeMapper
    {
        public static SizeViewModel ToViewModel(this Size size)
        {
            return new SizeViewModel
            {
                Id = size.Id,
                Description = size.Description,
                Price = size.Price
            };
        }
    }
}
