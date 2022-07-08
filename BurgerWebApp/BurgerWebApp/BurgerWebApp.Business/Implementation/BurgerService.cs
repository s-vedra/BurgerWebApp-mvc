using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.Business.Mappers;
using BurgerWebApp.DataAccess;
using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;

namespace BurgerWebApp.Business.Implementation
{
    public class BurgerService : IBurgerService
    {
        private readonly IRepository<Burger> _burgerRepository;
        public BurgerService(IRepository<Burger> burgerRepository)
        {
            _burgerRepository = burgerRepository;
        }

        public void Add(BurgerViewModel viewModel)
        {
            Burger burger = new Burger(_burgerRepository.RandomId(),
                                        viewModel.Name,
                                        viewModel.Price,
                                        viewModel.IsVegetarian,
                                        viewModel.HasFries,
                                        viewModel.Image,
                                        viewModel.IsVegan);
            _burgerRepository.Add(burger);
        }
        public void Delete(int id)
        {
          Burger burger = _burgerRepository.GetEntity(id);
            _burgerRepository.Delete(burger);
        }

        public BurgerViewModel Details(BurgerViewModel burger)
        {
            BurgerViewModel burgerViewModel = GetBurger(burger.Id);
            return burgerViewModel;
        }

        public List<BurgerViewModel> GetAllBurgers()
        {
            List<BurgerViewModel> burgers = _burgerRepository.GetAll().Select(burger => burger.ToViewModel()).ToList();
            if (burgers.Count != 0)
            {
                return burgers;
            }
            else
            {
                throw new Exception("There aren't any burgers");
            }
        }

        public BurgerViewModel GetBurger(int? id)
        {
            BurgerViewModel? burger = _burgerRepository.GetEntity(id).ToViewModel();
            if (burger == null)
            {
                throw new Exception("Item doesn't exist");
            }
            else
            {
                return burger;
            }
        }

        public List<BurgerViewModel> SearchOption(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return GetAllBurgers();
            }
            else
            {
                return GetAllBurgers().Where(burger => burger.Name.ToLower().Contains(name.ToLower())).ToList();
            }
        }

        public void Update(BurgerViewModel viewModel)
        {
            Burger burger = new Burger(viewModel.Id,viewModel.Name,viewModel.Price,viewModel.IsVegetarian,viewModel.HasFries,viewModel.Image,viewModel.IsVegan);
            _burgerRepository.Update(burger);
        }

        public bool ValidateInputs(BurgerViewModel viewModel)
        {
            if (string.IsNullOrEmpty(viewModel.Name) && viewModel.Price == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
