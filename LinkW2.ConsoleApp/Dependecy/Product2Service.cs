using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkW2.ConsoleApp.Dependecy
{
    internal class Product2Service
    {
        private readonly IProduct2Repository _product2Repository2;

        public Product2Service(IProduct2Repository product2Repository2)
        {
            _product2Repository2 = product2Repository2;
        }

        public List<string> GetList()
        {
            return _product2Repository2.GetAllProducts2();
        }
    }
}
