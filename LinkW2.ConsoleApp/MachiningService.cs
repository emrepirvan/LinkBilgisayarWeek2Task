using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkW2.ConsoleApp
{
    internal class MachiningService 
    {
        private readonly IMachiningRepository _repository;

        public MachiningService(IMachiningRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetProductNames()
        {
            return _repository.GetList();
        }
    }
}
