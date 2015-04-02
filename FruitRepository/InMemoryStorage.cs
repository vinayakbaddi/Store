using DataAccessLayer.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitRepository
{
    /// <summary>
    /// Replicating a Data Context
    /// </summary>
    public static class InMemoryStorage
    {
        public static List<IFruit> FruitList;
    }
}
