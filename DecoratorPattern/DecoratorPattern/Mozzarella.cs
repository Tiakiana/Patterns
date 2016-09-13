using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza ipizza) : base(ipizza)
        {
            Console.WriteLine("Adding Mozarella");
        }

        public string getDescription() {
            return tempPizza.getDescription() + ", Mozarella";

        }
        public double getCost()
        {
            return tempPizza.getCost() + 5.00;
        }

    }
}
