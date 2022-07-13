using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.DataAccess.Implementation
{
    public class BurgerRepository : IRepository<Burger>
    {
        private readonly BurgerAppDbContext _dbContext;

        public BurgerRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Burger entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Burger entity)
        {
            _dbContext.Burgers.Remove(entity);
            _dbContext.SaveChanges();
        }
            
    

    public List<Burger> GetAll()
        {
            return _dbContext.Burgers.ToList();
        }

        public Burger GetEntity(int? id)
        {
            return _dbContext.Burgers.SingleOrDefault(order => order.Id == id);
        }

     

        public void Update(Burger entity)
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
