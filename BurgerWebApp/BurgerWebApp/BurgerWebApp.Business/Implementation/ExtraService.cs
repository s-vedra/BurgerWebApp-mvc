using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.Business.Mappers;
using BurgerWebApp.DataAccess;
using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.Business.Implementation
{
    public class ExtraService : IExtraService
    {
        private readonly IRepository<Extra> _extraRepository;
        public ExtraService(IRepository<Extra> extraRepository)
        {
            _extraRepository = extraRepository;
        }
        public void AddExtraItem(Extra extraItem)
        {
            _extraRepository.Add(extraItem);
        }

        public void DeleteExtraItem(Extra extraItem)
        {
            _extraRepository.Delete(extraItem);
        }
            
        public List<ExtraViewModel> GetAllExtraItems()
        {
            List<ExtraViewModel> extraItems = _extraRepository.GetAll().Select(extraItem => extraItem.ToViewModel()).ToList();
            if (extraItems.Count != 0)
            {
                return extraItems;
            }
            else
            {
                throw new Exception("There aren't any extra items");
            }
        }

        public ExtraViewModel GetExtraItem(int? id)
        {
            Extra? extraItem = _extraRepository.GetEntity(id);
            if (extraItem == null)
            {
                throw new Exception("Item doesn't exist");
            }
            else
            {
                return extraItem.ToViewModel();
            }
        }
    }
}
