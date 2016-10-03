using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza basicPizza = new Mozzarella(new TomatoSauce( new PlainPizza()));
            Console.WriteLine("Ingredienser: " + basicPizza.getDescription());
            Console.WriteLine(basicPizza.GetType().IsNestedFamily);
            Console.WriteLine("Pris: " + basicPizza.getCost());
            Console.ReadLine();

        }
    }
}
