using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.Business.Mappers;
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
            Burger burger = new Burger(
                                        viewModel.Name,
                                        viewModel.Price,
                                        viewModel.IsVegetarian,
                                        viewModel.HasFries,
                                        viewModel.Image,
                                        viewModel.IsVegan,
                                        viewModel.Ingredients == null ? "" : viewModel.Ingredients,
                                        viewModel.Description == null ? "" : viewModel.Description);
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
            return _burgerRepository.GetAll().Select(burger => burger.ToViewModel()).ToList();
        }

        public BurgerViewModel GetBurger(int? id)
        {
            BurgerViewModel? burger = _burgerRepository.GetEntity(id).ToViewModel();
            return burger;
        }

        public void Update(BurgerViewModel viewModel)
        {
            Burger burger = new Burger(viewModel.Name,
                                       viewModel.Price,
                                       viewModel.IsVegetarian,
                                       viewModel.HasFries,
                                       viewModel.Image,
                                       viewModel.IsVegan,
                                       viewModel.Ingredients == null ? "" : viewModel.Ingredients,
                                       viewModel.Description == null ? "" : viewModel.Description)
            {
                Id = viewModel.Id
            };
            _burgerRepository.Update(burger);
        }
        public List<BurgerViewModel> RandomBurgers()
        {
            Random rndm = new Random();
            List<BurgerViewModel> burgerViewModels = GetAllBurgers();
            List<BurgerViewModel> burgersToSend = new List<BurgerViewModel>();
            for (int i = 0; i<3;i++)
            {
                int rnd = rndm.Next(1, burgerViewModels.Count);
                BurgerViewModel burger = burgerViewModels[rnd];
                if (burgersToSend.Contains(burger))
                {
                    burgersToSend.Remove(burger);
                }
                else
                {
                    burgersToSend.Add(burger);
                }
            }
            return burgersToSend;
        }

    }
}
