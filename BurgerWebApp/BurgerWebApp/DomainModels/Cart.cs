namespace BurgerWebApp.DomainModels
{
    public class Cart
    {
        public int Id { get; set; }
        public ICollection<BurgerOrder> BurgerOrders { get; set; }
        public ICollection<ExtrasOrder> Extras { get; set; }
        public decimal FullPrice { get; set; }
        public Cart()
        {

        }
        public Cart(List<BurgerOrder> burgerOrders, List<ExtrasOrder> extras)
        {
          
            BurgerOrders = burgerOrders;
            Extras = extras;
        }
    }
}
