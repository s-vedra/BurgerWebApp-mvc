using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;

namespace BurgerWebApp.DataAccess.Implementation
{
    public class OrderRepository : IRepository<Order>
    {
        public void Add(Order entity)
        {
            StorageDb.Order.Add(entity);
        }

        public void Delete(Order entity)
        {
            StorageDb.Order.Remove(entity);
        }

        public List<Order> GetAll()
        {
            return StorageDb.Order;
        }

        public Order GetEntity(int? id)
        {
            return StorageDb.Order.SingleOrDefault(order => order.Id == id);
        }
        public int RandomId()
        {
            return IdGenerator.GenerateId();
        }
        public void Update(Order entity)
        {
            var item = GetEntity(entity.Id);
            if (item != null)
            {
                int index = StorageDb.Order.IndexOf(item);
                StorageDb.Order[index] = entity;
            }
        }
    }
}
