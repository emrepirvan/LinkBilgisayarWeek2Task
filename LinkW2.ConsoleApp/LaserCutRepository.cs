using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkW2.ConsoleApp
{
    public class LaserCutRepository : IMachiningRepository 
    {
        
        public List<string> GetList()
        {
            return new List<string>() { "Machined w/Laser sheet metal", "Machined w/Laser 	metal plate"};
        }
    }
}
