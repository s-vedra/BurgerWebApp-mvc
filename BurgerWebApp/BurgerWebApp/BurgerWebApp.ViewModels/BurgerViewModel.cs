using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BurgerWebApp.ViewModels
{
    public class BurgerViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [DisplayName("Vegetarian")]
        public bool IsVegetarian { get; set; }
        [DisplayName("Vegan")]
        public bool IsVegan { get; set; }
        [DisplayName("Comes with Fries")]
        public bool HasFries { get; set; }
        [Required(ErrorMessage = "Image is required")]
        public string Image { get; set; }
        public string? Ingredients { get; set; }
        public string? Description { get; set; }
    }
}
