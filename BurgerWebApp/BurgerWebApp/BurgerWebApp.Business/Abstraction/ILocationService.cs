using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Abstraction
{
    public interface ILocationService
    {
        List<LocationViewModel> GetAll();
        LocationViewModel GetLocation(int? id);
        void Add(LocationViewModel viewModel);
        void Delete(int? id);
        void Update(LocationViewModel viewModel);
    }
}
