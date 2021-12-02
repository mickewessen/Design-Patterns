using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataRepositoryA : IDataRepository
    {
        public string DatabaseType()
        {
            return "Dataset A";
        }

        public string GetCustomer()
        {
            return "From Table Customer Where Name == Steve";
        }

        public string GetAnimal()
        {
            return "From Table Animal Where Owner==Steve";
        }
    }
}
