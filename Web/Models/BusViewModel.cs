using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class BusViewModel : CarViewModel
    {
        public int Salon { get; set; }
        public int Rails { get; set; }

        public BusViewModel() { }
        public BusViewModel(CarViewModel model) : base(model)
        {
        }
    }
}
