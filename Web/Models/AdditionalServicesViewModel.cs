using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class AdditionalServicesViewModel
    {
        public string Title { get; set; }
        public List<ServiceViewModel> Services { get; set; } 
    }
}
