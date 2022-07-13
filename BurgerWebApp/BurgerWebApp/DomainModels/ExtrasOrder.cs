namespace BurgerWebApp.DomainModels
{
    public class ExtrasOrder
    {
        public int Id { get; set; }
        public int ExtraId { get; set; }
        public Extra Extra { get; set; }
        public bool Selected { get; set; }
        public decimal Quantity { get; set; }
        public Cart Cart { get; set; }
        public int CartId { get; set; }

        public ExtrasOrder()
        {

        }
        public ExtrasOrder( int extraId, decimal quantity, bool selected)
        {
          
            ExtraId = extraId;
            Quantity = quantity;
            Selected = selected;
        }
    }
}
