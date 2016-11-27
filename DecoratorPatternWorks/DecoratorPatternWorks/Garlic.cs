using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternWorks
{
    class Garlic : Decorator
    {
        public Garlic(Pizza objPizza) : base(objPizza)
        {
            this.p_Price  = 120;
        }
    }
}
