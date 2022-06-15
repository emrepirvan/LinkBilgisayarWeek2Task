using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkW2.ConsoleApp
{
    public class CNCMillingRepository : IMachiningRepository 
    {
        public List<string> GetList()
        {
            return new List<string>() { "Machined w/ CNCMilling sheet metal", "Machined w/ CNCMilling metal plate"};
        }
        
    }
}
