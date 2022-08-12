using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BurgerWebApp.DataAccess.Implementation
{
    public class ExtraItemsRepository : IRepository<Extra>
    {
        private readonly BurgerAppDbContext _dbContext;

        public ExtraItemsRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Extra entity)
        {
            _dbContext.Extras.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Extra entity)
        {
            _dbContext.Extras.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Extra> GetAll()
        {
            return _dbContext.Extras.Include(x => x.Size).ToList();
        }

        public Extra GetEntity(int? id)
        {
            return _dbContext.Extras.Include(x => x.Size).SingleOrDefault(order => order.Id == id);
        }

        public void Update(Extra entity)
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
