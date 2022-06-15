using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkW2.ConsoleApp.Dependecy
{
    internal class Product2SqlRepository : IProduct2Repository
    {
        public List<string> GetAllProducts2()
        {
            return new List<string>() { "Ahmet", "Mehmet", "Ayse" };
        }
    }
}
