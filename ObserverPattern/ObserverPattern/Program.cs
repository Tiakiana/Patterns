using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject s = new Subject();
            Observer1 o1 = new Observer1();
            Observer2 o2 = new Observer2();
            s.Register(o1);
            s.Register(o2);
            s.NotifyObserver();
            s.Unregister(o2);
            s.NotifyObserver();

            Console.WriteLine("End of Excersize! GG WP EZ");

            Console.ReadKey();
        }
    }
}
