using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Web.Models
{
    public  class MainFormViewModel
    {
        public Web.Models.Transport SelectedTransport { get; set; }
        public List<SelectListItem> TransportTypes { get; set; }
        public MainFormViewModel()
        {

        }
        public MainFormViewModel(Web.Models.Transport SelectedTransport)
        {
            this.SelectedTransport = SelectedTransport;
        }
        public MainFormViewModel(Web.Models.Transport SelectedTransport, List<SelectListItem> TransportTypes)
        {
            this.SelectedTransport = SelectedTransport;
            this.TransportTypes = TransportTypes;
        }
    }
}
