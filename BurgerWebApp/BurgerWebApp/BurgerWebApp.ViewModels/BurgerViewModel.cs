using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.ViewModels
{
    public class BurgerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        [DisplayName("Vegetarian")]
        public bool IsVegetarian { get; set; }
        [DisplayName("Vegan")]
        public bool IsVegan { get; set; }
        [DisplayName("Comes with Fries")]
        public bool HasFries { get; set; }
        public string Image { get; set; }
    }
}
