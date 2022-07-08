using BurgerWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.Business.Abstraction
{
    public interface ILocationService
    {
        List<LocationViewModel> GetAll();
        LocationViewModel GetLocation(int? id);
        void Add(LocationViewModel viewModel);
        void Delete(int? id);
        bool ValidateInputs(LocationViewModel viewModel);
        void Update(LocationViewModel viewModel);
    }
}
