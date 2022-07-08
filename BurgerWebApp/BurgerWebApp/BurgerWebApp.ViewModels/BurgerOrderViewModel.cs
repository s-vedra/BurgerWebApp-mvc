using BurgerWebApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.ViewModels
{
    public class BurgerOrderViewModel
    {
        public int Id { get; set; }
        public int? BurgerId { get; set; }
        public bool Selected { get; set; }
        public decimal Quantity { get; set; }
        public decimal FullPrice { get; set; }
    }
}
