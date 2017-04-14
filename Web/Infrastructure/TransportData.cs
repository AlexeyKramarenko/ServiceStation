using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Models;

namespace Web.Helpers
{
    public static class TransportData
    {
        public const int PricePerRepairItem = 10;
        public static string[] PartNames
        {
            get
            {
                return new string[] { "Body", "Brakes", "Engine", "Wheels", "Salon", "Rails", "Hydraulics" };
            }
        }        
        public static List<SelectListItem> TransportTypes
        {
            get
            {
                var types = new List<SelectListItem>
                {
                     new SelectListItem { Text = Transport.Car.ToString(), Value = ((int)Transport.Car).ToString() },
                     new SelectListItem { Text = Transport.Bus.ToString(), Value = ((int)Transport.Bus).ToString() },
                     new SelectListItem { Text = Transport.Truck.ToString(), Value = ((int)Transport.Truck).ToString() }
                };
                return types;
            }
        }

        public static List<ServiceViewModel> AdditionalServices = new List<ServiceViewModel>
        {
            new ServiceViewModel
            {
                Transport = Transport.Bus,
                Name = "Смена обивки сидений",
                Selected = false,
                Price = 300
            },
            new ServiceViewModel
            {
                Transport = Transport.Bus,
                Name = "Ремонт коробки передач",
                Selected = false,
                Price = 150
            },
            new ServiceViewModel
            {
                Transport = Transport.Car,
                Name = "Балансировка колёс",
                Selected = false,
                Price = 100,
            },
            new ServiceViewModel
            {
                Transport = Transport.Truck,
                Name = "Проверка топливной системы",
                Selected = false,
                Price = 450,
            },
            new ServiceViewModel
            {
                Transport = Transport.Truck,
                Name = "Компьютерная диагностика",
                Selected = false,
                Price = 350,
            },
            new ServiceViewModel
            {
                Transport = Transport.Truck,
                Name = "Замена фильтров и технологических жидкостей ",
                Selected = false,
                Price = 700,
            }            
        };
    }
}
