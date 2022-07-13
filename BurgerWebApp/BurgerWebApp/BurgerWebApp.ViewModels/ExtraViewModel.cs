using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.ViewModels
{
    public class ExtraViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public decimal Price { get; set; }
        public string Image { get; set; }
        public SizeViewModel Size { get; set; }
    }
}
