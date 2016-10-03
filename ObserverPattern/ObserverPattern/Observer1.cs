using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class Observer1 : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Nu det hjul igen");
        
        }
    }
}
