using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza ipizza) : base(ipizza)
        {
            Console.WriteLine("Adding sauce");
        }

        public string getDescription()
        {
            
            return tempPizza.getDescription() + ", Sauce";
        }
        public double getCost()
        {
            return tempPizza.getCost() + 2.50;
        }

    }
}
