using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Abstraction
{
    public interface IBurgerService
    {
        BurgerViewModel GetBurger(int? id);
        List<BurgerViewModel> GetAllBurgers();
        BurgerViewModel Details(BurgerViewModel burger);
        void Delete(int id);
        void Update(BurgerViewModel viewModel);
        void Add(BurgerViewModel viewModel);
        List<BurgerViewModel> RandomBurgers();

    }
}
