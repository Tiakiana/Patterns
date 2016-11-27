using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternWorks
{
    class ThinCrust : Pizza
    {
        private double p_Price = 200;

        public override double GetPrice()
        {
            return p_Price;
           
        }
    }
}
