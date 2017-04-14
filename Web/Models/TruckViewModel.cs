using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class TruckViewModel : CarViewModel
    {
        public int Hydraulics { get; set; }
        public TruckViewModel() { }
        public TruckViewModel(CarViewModel model) : base(model)
        {
        }
    }
}
