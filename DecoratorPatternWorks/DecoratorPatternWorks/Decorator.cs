using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternWorks
{
    public class Decorator : Pizza
    {
        Pizza basePizza = null;

        protected double p_Price = 0.0;

        protected Decorator(Pizza objPizza)
        {
            basePizza = objPizza;
        }
        public override double GetPrice()
        {
            return p_Price + basePizza.GetPrice();
        }
    }
}
