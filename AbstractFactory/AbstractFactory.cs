using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AbstractFactory
    {
        public AbstractFactory()
        {

        }

        public IFactory GetFactory(string typeOfFactory)
        {
            if (typeOfFactory=="Dog")
            {
                return new DogFactory();
            }
            else if (typeOfFactory == "Cat")
            {
                return new CatFactory();
            }

            return null;

        }
    }
}
