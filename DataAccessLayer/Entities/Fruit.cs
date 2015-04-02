using DataAccessLayer.Entities.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Fruit : IFruit
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        //This below property should move to Another entity, shortening the code
        public int Quantity { get; set; }

        //This below property should move to Another entity, shortening the code
        public DateTime SalesDate { get; set; }
    }

    
}
