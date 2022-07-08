using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.DataAccess.Implementation
{
    public class ExtraItemsRepository : IRepository<Extra>
    {
        public void Add(Extra entity)
        {
            StorageDb.ExtraItems.Add(entity);
        }

        public void Delete(Extra entity)
        {
            StorageDb.ExtraItems.Remove(entity);
        }

        public List<Extra> GetAll()
        {
            return StorageDb.ExtraItems;
        }

        public Extra GetEntity(int? id)
        {
            return StorageDb.ExtraItems.SingleOrDefault(order => order.Id == id);
        }
        public int RandomId()
        {
            return IdGenerator.GenerateId();
        }
        public void Update(Extra entity)
        {
            var item = GetEntity(entity.Id);
            if (item != null)
            {
                int index = StorageDb.ExtraItems.IndexOf(item);
                StorageDb.ExtraItems[index] = entity;
            }
        }
    }
}
