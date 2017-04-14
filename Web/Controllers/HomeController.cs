using System.Web.Mvc;
using Web.Helpers;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private TransportService service = null;
        private Mapper mapper = null;
        public HomeController()
        {
            this.service = new TransportService();
            this.mapper = new Mapper();
        }

        [HttpGet]
        public ActionResult Index(Transport transport = Transport.Car)
        {
            var model = new MainFormViewModel(transport, TransportData.TransportTypes);
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(MainFormViewModel model)
        {
            model.TransportTypes = TransportData.TransportTypes;
            return View(model);
        }
        
        [HttpGet]
        public ActionResult AdditionalServices(Transport transport)
        {
            var model = new AdditionalServicesViewModel
            {
                Services = service.GetAdditionalServicesByTransportType(transport)
            };
            return PartialView("_AdditionalServices", model);
        }

        [HttpGet]
        public ActionResult Diagnostic(Transport transport)
        {
            string view = null;
            CarViewModel model = null;
            mapper.InitViewByTransportType(transport, out view, out model);
            model.SelectedTransport = (int)transport;

            return PartialView(view, model);
        }

        [HttpPost]
        public ActionResult Diagnostic(FormCollection form)
        {
            if (form["save"] != null)
                service.SaveOrder(form);

            var servicesVM = mapper.GetServiceViewModelList(form);
            var servicesPrice = service.GetAdditionalServicesPrice(servicesVM);
            var condition = service.GetGenaralCondition(form);
            var repairPrice = service.GetRepairPrice(condition, TransportData.PricePerRepairItem);
            var summaryPrice = service.GetSummaryPrice(repairPrice, servicesPrice);

            var model = new ResultViewModel
            {
                GeneralCondition = condition,
                RepairPrice = repairPrice,
                AdditionalServicesPrice = servicesPrice,
                SummaryPrice = summaryPrice
            };

            return PartialView("_Result", model);
        }
    }


}