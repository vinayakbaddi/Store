using AutoMapper;
using FruitCommon;
using FruitRepository.ServiceContracts;
using FruitService.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitService
{
    public class FruitOrderService : IFruitOrderService
    {
        private readonly IFruitOrderRepository fruitRepository;

        //Constructor Injection using Unity
        public FruitOrderService(IFruitOrderRepository fruitRepository)
        {
            this.fruitRepository = fruitRepository;
        }

        public void Add(FruitDTO fruit)
        {
            fruitRepository.Add(fruit);
        }

        public IList<FruitDTO> GetAll()
        {
            return fruitRepository.GetAll();
        }

    }
}
