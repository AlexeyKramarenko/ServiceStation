using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ResultViewModel
    {
        public double GeneralCondition { get; set; }
        public decimal RepairPrice { get; set; }
        public decimal AdditionalServicesPrice { get; set; }
        public decimal SummaryPrice { get; set; }
    }
}
