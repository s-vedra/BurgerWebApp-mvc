using BurgerWebApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.ViewModels
{
    public class ExtrasOrderViewModel
    {
        public int Id { get; set; }
        public int? ExtraId { get; set; }
        public bool Selected { get; set; }
        public decimal Quantity { get; set; }
        public decimal FullPrice { get; set; }
    }
}
