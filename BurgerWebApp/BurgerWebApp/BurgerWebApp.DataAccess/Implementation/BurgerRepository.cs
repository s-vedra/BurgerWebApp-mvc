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
        public void Add(Burger entity)
        {
            StorageDb.Burgers.Add(entity);
        }

        public void Delete(Burger entity)
        {
            StorageDb.Burgers.Remove(entity);
        }

        public List<Burger> GetAll()
        {
            return StorageDb.Burgers;
        }

        public Burger GetEntity(int? id)
        {
            return StorageDb.Burgers.SingleOrDefault(order => order.Id == id);
        }

        public int RandomId()
        {
            return IdGenerator.GenerateId();
        }

        public void Update(Burger entity)
        {
            var item = GetEntity(entity.Id);
            if (item != null)
            {
                int index = StorageDb.Burgers.IndexOf(item);
                StorageDb.Burgers[index] = entity;
            }
        }
    }
}
