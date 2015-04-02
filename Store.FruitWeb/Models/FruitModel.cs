using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.FruitWeb.Models
{
    public class FruitModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public DateTime SalesDate { get; set; }

        public double Total
        {
            get
            {
                return Price * Quantity;
            }
        }

        public List<SelectListItem> FruitList { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}