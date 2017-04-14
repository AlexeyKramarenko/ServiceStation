using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Web.Models;

namespace Web.Helpers
{
    public class TransportService
    {
        private static List<NameValueCollection> orders = new List<NameValueCollection>();
        public void SaveOrder(NameValueCollection form)
        {
            orders.Add(form);
        }
        public List<NameValueCollection> GetOrders()
        {
            return orders;
        }
        public List<ServiceViewModel> GetAdditionalServicesByTransportType(Transport transport)
        {
            IEnumerable<ServiceViewModel> services = TransportData.AdditionalServices.Where(a => a.Transport == transport);
            if (services != null)
                return services.ToList();
            return null;
        }

        public decimal GetSummaryPrice(decimal repairPrice, decimal servicesPrice)
        {
            return repairPrice + servicesPrice;
        }
         
        public decimal GetAdditionalServicesPrice(List<ServiceViewModel> services)
        {
            decimal price = services.Where(a => a.Selected).Select(a => a.Price).Sum();
            return price;
        }

        public double GetGenaralCondition(NameValueCollection form)
        {
            var partCount = 0;
            var condition = 0;

            foreach (var partName in TransportData.PartNames)
                if (form.AllKeys.Contains(partName))
                {
                    partCount++;
                    condition += Convert.ToInt32(form[partName]);
                }

            if (partCount != 0 && condition != 0)
            {
                float generalCondition = (float)condition / (float)partCount;
                return Math.Round((double)generalCondition,2);
            }
            return 0;
        }

        public decimal GetRepairPrice(double condition, decimal price)
        {
            var p = (decimal)condition * price;
            return Math.Round(p, 2);
        }
    }
}
