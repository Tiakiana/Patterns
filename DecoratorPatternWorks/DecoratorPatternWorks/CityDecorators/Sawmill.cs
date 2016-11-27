using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPatternWorks.CityDecorators;


namespace DecoratorPatternWorks
{
    class Sawmill : CityDecorator
    {


        public Sawmill(City objCity) : base(objCity)
        {
            this.p_wealth = 100;
            this.p_description =
                "\n On the far side of Town by a lake, there is a sawmill.\n This creaky old geezer of a building, has seen it's fair share \n of stories take place on the grounds before it. ";
        }


    }
}

