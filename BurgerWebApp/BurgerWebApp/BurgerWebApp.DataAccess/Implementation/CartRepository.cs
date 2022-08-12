using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BurgerWebApp.DataAccess.Implementation
{
    public class CartRepository : IRepository<Cart>
    {
        private readonly BurgerAppDbContext _dbContext;

        public CartRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Cart entity)
        {
            _dbContext.Carts.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Cart entity)
        {
            _dbContext.Carts.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Cart> GetAll()
        {
            return _dbContext.Carts.
                Include(x => x.BurgerOrders).
                ThenInclude(x => x.Burger).
                Include(x => x.Extras).
                ThenInclude(x => x.Extra).
                ThenInclude(x => x.Size).ToList();
        }

        public Cart GetEntity(int? id)
        {
            return _dbContext.Carts.
                Include(x => x.BurgerOrders).
                ThenInclude(x => x.Burger).
                Include(x => x.Extras).
                ThenInclude(x => x.Extra).
                ThenInclude(x => x.Size).
                SingleOrDefault(order => order.Id == id);
        }

        public void Update(Cart entity)
        {
            var item = GetEntity(entity.Id);
            if (item != null)
            {
                _dbContext.Entry(item).CurrentValues.SetValues(entity);
                _dbContext.SaveChanges();
            }
        }
    }
}
