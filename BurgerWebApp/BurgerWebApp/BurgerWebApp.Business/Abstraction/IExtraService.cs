using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
