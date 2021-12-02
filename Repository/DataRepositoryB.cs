using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class DataRepositoryB:IDataRepository
    {
        public string DatabaseType()
        {
            return "Dataset B";
        }

        public string GetCustomer()
        {
            return "From Table Customer Where Name == Micke";
        }

        public string GetAnimal()
        {
            return "From Table Animal Where Owner==Micke";
        }
    }
}
