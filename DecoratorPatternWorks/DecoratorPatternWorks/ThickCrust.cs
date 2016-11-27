using System;

namespace DecoratorPatternWorks
{
    class ThickCrust : Pizza
    {
        private double p_Price = 250.0;

        public override double GetPrice()
        {
            return p_Price;
        }
    }
}
