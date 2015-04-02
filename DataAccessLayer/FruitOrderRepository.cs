using AutoMapper;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.ServiceContracts;
using FruitCommon;
using FruitDataAccessLayer;
using FruitRepository.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitRepository
{
    public class FruitOrderRepository : IFruitOrderRepository
    {

        public void Add(FruitDTO fruitDTO)
        {
            var fruit = Mapper.Map<FruitDTO, IFruit>(fruitDTO);

            InMemoryStorage.FruitList.Add(fruit);
        }

        public IList<FruitDTO> GetAll()
        {
            var fruitList = InMemoryStorage.FruitList;

            return Mapper.Map<List<IFruit>, List<FruitDTO>>(fruitList).ToList();
        }
    }
}
