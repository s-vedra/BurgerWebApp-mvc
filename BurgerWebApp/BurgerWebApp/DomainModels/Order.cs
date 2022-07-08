namespace BurgerWebApp.DomainModels
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool IsDelivered { get; set; }
        public int CartId { get; set; }
        public int Location { get; set; }
        public decimal TotalPrice { get; set; }

        public Order()
        {

        }


        public Order(int id, string name, string lastName, string address, bool isDelivered, int location, int cartId, decimal totalPrice)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Address = address;
            IsDelivered = isDelivered;
            Location = location;
            CartId = cartId;
            TotalPrice = totalPrice;
        }

    }
}
