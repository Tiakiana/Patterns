using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class Observer2 : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Og Hjulet varer lige til påske");
        }
    }
}
