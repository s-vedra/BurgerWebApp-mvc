namespace BurgerWebApp.DomainModels
{
    public class Cart
    {
        public int Id { get; set; }
        public List<BurgerOrder> BurgerOrders { get; set; }
        public List<ExtrasOrder> Extras { get; set; }
        public Cart()
        {

        }
        public Cart(int id, List<BurgerOrder> burgerOrders, List<ExtrasOrder> extras)
        {
            Id = id;
            BurgerOrders = burgerOrders;
            Extras = extras;
        }
    }
}
