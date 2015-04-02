using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCommon
{
    public class FruitDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public DateTime SalesDate { get; set; }
                
    }

    //HardCoding this for Quick Run
    public enum EnumFruitNames
    {
        Apples,
        Bananas,
        Oranges,
        Pears,
        Watermelons
    }
}
