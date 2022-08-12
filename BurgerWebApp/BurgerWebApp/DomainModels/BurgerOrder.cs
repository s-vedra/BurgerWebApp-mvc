
namespace BurgerWebApp.DomainModels
{
    public class BurgerOrder
    {

        public int Id { get; set; }
        public int BurgerId { get; set; }
        public Burger Burger { get; set; }
        public bool Selected { get; set; }
        public decimal Quantity { get; set; }
        public Cart Cart { get; set; }
        public int CartId { get; set; }
        public decimal Price { get; set; }


        public BurgerOrder()
        {

        }
        public BurgerOrder(int burgersId, decimal quantity)
        {
            BurgerId = burgersId;
            Quantity = quantity;
        }
    }
}
