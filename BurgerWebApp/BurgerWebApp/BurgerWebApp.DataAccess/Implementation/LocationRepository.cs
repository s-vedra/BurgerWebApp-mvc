using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.DataAccess.Implementation
{
    public class LocationRepository : IRepository<Location>
    {
        public void Add(Location entity)
        {
            StorageDb.BurgerLocations.Add(entity);
        }

        public void Delete(Location entity)
        {
            StorageDb.BurgerLocations.Remove(entity);
        }

        public List<Location> GetAll()
        {
            return StorageDb.BurgerLocations;
        }

        public Location GetEntity(int? id)
        {
            return StorageDb.BurgerLocations.SingleOrDefault(order => order.Id == id);
        }
        public int RandomId()
        {
            return IdGenerator.GenerateId();
        }
        public void Update(Location entity)
        {
            var item = GetEntity(entity.Id);
            if (item != null)
            {
                int index = StorageDb.BurgerLocations.IndexOf(item);
                StorageDb.BurgerLocations[index] = entity;
            }
        }
    }
}
