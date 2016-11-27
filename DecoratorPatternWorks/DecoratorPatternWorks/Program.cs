using DecoratorPatternWorks.CityDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Town Wishmerhill = new Town();

            Sawmill sawmill = new Sawmill(Wishmerhill);
            Quarry quarry = new Quarry(sawmill);

            CityInfo(quarry);

        }

        static void CityInfo(City objCity)
        {
            Console.WriteLine();
           // Console.WriteLine("Pizza is " + objCity.ToString());
            Console.WriteLine("City Wealth: {0}", objCity.GetWealth());
            Console.WriteLine("Description: {0}", objCity.GetDescription());

            Console.ReadKey();
        }


        static void PizzaPriceInfo(Pizza objPizza)
        {
            Console.WriteLine();
            Console.WriteLine("Pizza is " + objPizza.ToString());
            Console.WriteLine("Pizza costs: {0}", objPizza.GetPrice());
            Console.ReadKey();
        }

    }
}
