using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.Business.Mappers;
using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

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
            return _extraRepository.GetAll().Select(extraItem => extraItem.ToViewModel()).ToList();
        }

        public ExtraViewModel GetExtraItem(int? id)
        {
            return _extraRepository.GetEntity(id).ToViewModel();
        }
    }
}
