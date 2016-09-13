using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class PlainPizza : IPizza
    {
        public double getCost()
        {
            return 20.00;
        }

        public string getDescription()
        {
            return "Tynd Dej";
        }
    }
}
