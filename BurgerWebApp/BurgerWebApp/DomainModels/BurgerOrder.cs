

namespace BurgerWebApp.DomainModels
{
    public class BurgerOrder
    {

        public int Id { get; set; }
        public int? BurgerId { get; set; }
        public bool Selected { get; set; }
        public decimal Quantity { get; set; }
        public decimal FullPrice { get; set; }
        

        public BurgerOrder()
        {

        }
        public BurgerOrder(int id, int? burgersId, decimal quantity, bool selected)
        {
            Id = id;
            BurgerId = burgersId;
            Quantity = quantity;
            Selected = selected;
        }
    }
}
