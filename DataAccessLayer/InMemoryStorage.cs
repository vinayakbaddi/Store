using DataAccessLayer.Entities.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitDataAccessLayer
{
    /// <summary>
    /// Replicating a Data Context
    /// </summary>
    public static class InMemoryStorage
    {
        public static List<IFruit> FruitList;
        
        static InMemoryStorage()
        {
            FruitList = new List<IFruit>();
        }
    }
}
