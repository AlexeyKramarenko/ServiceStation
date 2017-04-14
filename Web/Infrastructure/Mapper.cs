using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Web.Models;

namespace Web.Helpers
{
    public class Mapper
    {
        public void InitViewByTransportType(Transport transport, out string view, out CarViewModel model)
        {
            view = null;
            model = null;

            switch (transport)
            {
                case Transport.Car:
                    view = "_Car";
                    model = new CarViewModel();
                    break;

                case Transport.Bus:
                    view = "_Bus";
                    model = new BusViewModel();
                    break;

                case Transport.Truck:
                    view = "_Truck";
                    model = new TruckViewModel();
                    break;
            }
        }
        public List<ServiceViewModel> GetServiceViewModelList(NameValueCollection form)
        {
            var list = new List<ServiceViewModel>();
            foreach (string key in form.AllKeys)
            {
                if (key.StartsWith("Services"))
                {
                    string value = Convert.ToString(form[key]);
                    int index = Convert.ToInt32(key.Split('[', ']')[1]);

                    if (list.Count < (index + 1))
                        list.Add(new ServiceViewModel());

                    if (key.EndsWith("Name"))
                        list[index].Name = value;

                    if (key.EndsWith("Selected"))
                    {
                        if (value.Contains(","))
                        {
                            int end = value.IndexOf(",");
                            value = value.Substring(0, end);
                        }
                        list[index].Selected = Convert.ToBoolean(value);
                    }

                    if (key.EndsWith("Price"))
                        list[index].Price = Convert.ToDecimal(value);
                }
            }
            return list;
        }

    }

}
