using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.Business.Abstraction
{
    public interface IBurgerService
    {
         BurgerViewModel GetBurger(int? id);
         List<BurgerViewModel> GetAllBurgers();
         BurgerViewModel Details(BurgerViewModel burger);
        bool ValidateInputs(BurgerViewModel viewModel);
        void Delete(int id);
        void Update(BurgerViewModel viewModel);
        void Add(BurgerViewModel viewModel);
        List<BurgerViewModel> SearchOption(string name);

    }
}
