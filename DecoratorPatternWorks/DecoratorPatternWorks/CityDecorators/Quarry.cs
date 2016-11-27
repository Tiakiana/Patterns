using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DecoratorPatternWorks.CityDecorators
{
    class Quarry : CityDecorator
    {
        public Quarry(City objCity) : base(objCity)
        {
            this.p_description =
                "\n There is a certain rythm to the clanking sounds of men and women \n hard at work in the quarry. \n Around the quarry a thriving small community of houses has sprung up, \n and in the evening the noise of steel on stone is replaced with the \n lighthearted if tired clamour of workers resting after a hard days work.";
            this.p_wealth = 160;
        }
    }
}
