namespace BurgerWebApp.ViewModels
{
    public class BurgerOrderViewModel
    {
        public int Id { get; set; }
        public BurgerViewModel? Burger { get; set; }
        public int BurgerId { get; set; }
        public bool Selected { get; set; }
        public decimal Quantity { get; set; }
        public CartViewModel? Cart { get; set; }
        public int CartId { get; set; }
        public decimal Price { get; set; }
    }
}
