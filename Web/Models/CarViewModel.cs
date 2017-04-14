using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Web.Models
{
    public class CarViewModel
    {
        public string OrderName { get; set; }
        public int Body { get; set; }
        public int Wheels { get; set; }
        public int Engine { get; set; }
        public int Brakes { get; set; }
        public int SelectedTransport { get; set; }
        public CarViewModel() { }
        public CarViewModel(CarViewModel model)
        {
            this.Body = model.Body;
            this.Brakes = model.Brakes;
            this.Engine = model.Engine;
            this.Wheels = model.Wheels;
        }
        public List<ServiceViewModel> Services { get; set; }        
    }

    public class ServiceViewModel
    {
        public string Name { get; set; }
        public bool Selected { get; set; }
        public decimal Price { get; set; }
        public Transport Transport { get; set; }
    }
}
