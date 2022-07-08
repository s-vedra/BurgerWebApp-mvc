using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.DataAccess.Implementation
{
    public class CartRepository : IRepository<Cart>
    {
        public void Add(Cart entity)
        {
            StorageDb.Cart.Add(entity);
        }

        public void Delete(Cart entity)
        {
            StorageDb.Cart.Remove(entity);
        }

        public List<Cart> GetAll()
        {
            return StorageDb.Cart;
        }

        public Cart GetEntity(int? id)
        {
            return StorageDb.Cart.SingleOrDefault(order => order.Id == id);
        }
        public int RandomId()
        {
            return IdGenerator.GenerateId();
        }
        public void Update(Cart entity)
        {
            var item = GetEntity(entity.Id);
            if (item != null)
            {
                int index = StorageDb.Cart.IndexOf(item);
                StorageDb.Cart[index] = entity;
            }
        }
    }
}
