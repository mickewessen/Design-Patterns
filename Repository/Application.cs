using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Application : IApplication
    {
        public IDataRepository DataRepository { get; set; }

        public Application(IDataRepository dataRepository)
        {
            DataRepository = dataRepository;
        }

        public void Run()
        {
            Console.WriteLine("Repository");
            var data = SimulatedDatabase.Load(DataRepository.DatabaseType());
            var customer = SimulatedDatabase.Load(DataRepository.GetCustomer()); // this is a search
            var animal = SimulatedDatabase.Load(DataRepository.GetAnimal()); // this is a search
            SimulatedDatabase.Save(data);
            SimulatedDatabase.Save(customer);
            SimulatedDatabase.Save(animal);
            Console.WriteLine();
        }
    }
}
