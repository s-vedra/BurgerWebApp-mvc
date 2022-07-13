using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool IsDelivered { get; set; }
        public int CartId { get; set; }
        public LocationViewModel Location { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
