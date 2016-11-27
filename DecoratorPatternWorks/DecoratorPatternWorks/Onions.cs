using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternWorks
{
    class Onions : Decorator
    {
        public Onions(Pizza objPizza) : base(objPizza)
        {
            this.p_Price  = 100;
        }
    }
}
