using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.ServiceContracts
{
    public interface IFruit
    {
        int Id { get; set; }

        string Name { get; set; }

        double Price { get; set; }

        int Quantity { get; set; }

        DateTime SalesDate { get; set; }
    }
}
