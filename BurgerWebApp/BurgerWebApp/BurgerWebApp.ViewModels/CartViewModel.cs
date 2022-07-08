using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.ViewModels
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public List<BurgerOrderViewModel> BurgerOrders { get; set; }
        public List<ExtrasOrderViewModel> Extras { get; set; }
    }
}
