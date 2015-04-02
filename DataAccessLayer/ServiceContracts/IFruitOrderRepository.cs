using FruitCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitRepository.ServiceContracts
{
    public interface IFruitOrderRepository
    {
        void Add(FruitDTO fruit);

        IList<FruitDTO> GetAll();
    }
}
