namespace BurgerWebApp.DomainModels
{
    public class Size
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public Size()
        {

        }

        public Size(int id, string description, decimal price)
        {
            Id = id;
            Description = description;
            Price = price;
        }
    }
}
