using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class CatFactory :IFactory
    {
        public ICat CreateAnimal()
        {
            return new Cat("Pelle");
        }
    }
}
