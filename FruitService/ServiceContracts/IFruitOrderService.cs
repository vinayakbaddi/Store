using FruitCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitService.ServiceContracts
{
    public interface IFruitOrderService
    {
        void Add(FruitDTO fruit);

        IList<FruitDTO> GetAll();

        IList<FruitDTO> GetByDate(DateTime startDate, DateTime endDate);
    }
}
