using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternWorks.CityDecorators
{
    class Hamlet : City
    {
        private int p_Wealth;

        private string description =
            "This is a small hamlet, with a handful of cottages and strawthatched huts, scattered around. ";
       

        public override int GetWealth()
        {
            return p_Wealth;
        }

        public override string GetDescription()
        {
            return description;
        }
    }
}
