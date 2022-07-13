using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BurgerWebApp.DataAccess.Implementation
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly BurgerAppDbContext _dbContext;

        public OrderRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Order entity)
        {
            _dbContext.Orders.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Order entity)
        {
            _dbContext.Orders.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _dbContext.Orders.Include(x => x.Location).ToList();
        }

        public Order GetEntity(int? id)
        {
            return _dbContext.Orders.Include(x => x.Location).SingleOrDefault(order => order.Id == id);
        }
     
        public void Update(Order entity)
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
