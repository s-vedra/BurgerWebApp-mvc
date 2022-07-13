using System.ComponentModel.DataAnnotations;

namespace BurgerWebApp.DomainModels
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public DateTime OpensAt { get; set; }
        public DateTime ClosesAt { get; set; }

        public Location()
        {

        }

        public Location(string name, string address, DateTime opensAt, DateTime closesAt)
        {
            
            Name = name;
            Address = address;
            OpensAt = opensAt;
            ClosesAt = closesAt;
            Image = "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80";
        }
    }
}
