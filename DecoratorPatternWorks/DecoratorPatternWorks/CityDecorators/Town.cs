using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DecoratorPatternWorks.CityDecorators
{
    class Town : City
    {
        private int p_wealth = 10000;
        private string p_descrition = "\n This is a buzzling town with cobbled roads and the noices of \n people working, cursing and laughing everywhere. ";

    

        public override int GetWealth()
        {
        return p_wealth;
            
        }

        public override string GetDescription()
        {
            return  p_descrition;
        }
    }
}
