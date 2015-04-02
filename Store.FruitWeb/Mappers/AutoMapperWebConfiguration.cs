using AutoMapper;
using FruitCommon;
using Store.FruitWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.FruitWeb.Mappers
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<FruitDTO, FruitModel>();

            Mapper.CreateMap<FruitModel, FruitDTO>();
        }
    }
}