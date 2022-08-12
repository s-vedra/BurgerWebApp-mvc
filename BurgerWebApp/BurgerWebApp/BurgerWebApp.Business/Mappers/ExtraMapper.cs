using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

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
                Size = extra.Size.ToViewModel()
            };
        }
    }
}
