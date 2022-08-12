using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Abstraction
{
    public interface IExtraService
    {
        ExtraViewModel GetExtraItem(int? id);
        List<ExtraViewModel> GetAllExtraItems();
        void AddExtraItem(Extra extraItem);
        void DeleteExtraItem(Extra extraItem);
    }
}
