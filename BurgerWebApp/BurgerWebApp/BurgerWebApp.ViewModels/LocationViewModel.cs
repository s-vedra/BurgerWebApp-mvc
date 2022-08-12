namespace BurgerWebApp.ViewModels
{
    public class LocationViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Image { get; set; }
        public DateTime OpensAt { get; set; }
        public DateTime ClosesAt { get; set; }

    }
}
