using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DecoratorPatternWorks.CityDecorators
{
    class CityDecorator : City
    {
        City baseCity = null;
        protected int p_wealth = 0;
        protected string p_description;

        protected CityDecorator(City objCity)
        {
            baseCity = objCity;
        }
        public override int GetWealth()
        {
            return p_wealth + baseCity.GetWealth();
        }

        public override string GetDescription()
        {
            return p_description + baseCity.GetDescription();
        }

      
      

    }
}
