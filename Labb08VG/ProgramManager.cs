using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb08VG
{
    class ProgramManager
    {
        public string FormatProductNames(StringConcatenator InforString)
        {
            return InforString(productList);
        }

        public double PriceCalculation(NumberOperator AddAll)
        {
            return AddAll(productList);
        }

        public List<Product> productList = new List<Product>
        {
            new Product { ID = 100001, Name = "radio", Price = 1000 },
            new Product { ID = 100002, Name = "microwave", Price = 1500 },
            new Product { ID = 100003, Name = "TV", Price = 1900 },
            new Product { ID = 100004, Name = "fridge", Price = 2400 },
            new Product { ID = 100005, Name = "laptop", Price = 4800 },
            new Product { ID = 100006, Name = "smartphone", Price = 6000 }
        };
    }
}
