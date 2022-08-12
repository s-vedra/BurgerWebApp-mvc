namespace BurgerWebApp.ViewModels
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public List<BurgerOrderViewModel> BurgerOrders { get; set; }
        public List<BurgerOrderViewModelCheckbox> BurgerOrderCheckbox { get; set; }
        public List<ExtrasOrderViewModel> Extras { get; set; }
        public decimal FullPrice { get; set; }
    }
}
