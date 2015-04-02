using FruitCommon;
using FruitRepository.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitRepository
{
    public class FruitRepository : IFruitRepository
    {

        public void Add(FruitDTO fruit)
        {
            Mapper.
            //InMemoryStorage.FruitList.Add(fruit);
        }

        public IList<FruitDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
