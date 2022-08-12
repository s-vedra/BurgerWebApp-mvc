namespace BurgerWebApp.ViewModels
{
    public class ExtrasOrderViewModel
    {
        public int Id { get; set; }
        public int ExtraId { get; set; }
        public ExtraViewModel Extra { get; set; }
        public bool Selected { get; set; }
        public decimal Quantity { get; set; }
        public int CartId { get; set; }
        public decimal Price { get; set; }
    }
}
