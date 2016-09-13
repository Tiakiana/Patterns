using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza tempPizza;
        public ToppingDecorator(IPizza ipizza) {
            tempPizza = ipizza;
        }

        public double getCost()
        {
            return tempPizza.getCost();
        }

        public string getDescription()
        {
           return tempPizza.getDescription();
        }
    }
}
