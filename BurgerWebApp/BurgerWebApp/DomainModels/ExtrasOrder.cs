namespace BurgerWebApp.DomainModels
{
    public class ExtrasOrder
    {
        public int Id { get; set; }
        public int? ExtraId { get; set; }
        public bool Selected { get; set; }
        public decimal Quantity { get; set; }
        public decimal FullPrice { get; set; }
   
    public ExtrasOrder()
        {

        }
        public ExtrasOrder(int id, int? extraId, decimal quantity, bool selected)
        {
            Id = id;
            ExtraId = extraId;
            Quantity = quantity;
            Selected = selected;
        }
    }
}
