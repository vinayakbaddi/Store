using AutoMapper;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.ServiceContracts;
using FruitCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappers
{
    public static class AutoMapperDomainConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<IFruit, FruitDTO>();

            Mapper.CreateMap<FruitDTO, IFruit>();
        }
    }
}
