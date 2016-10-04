using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoggingSystem
{
    class LoggingLoggington
    {

        public void WriteThisHereThing() {
            Console.WriteLine("I am of writing this here thing");
            LogWriter lw = new LogWriter("LoggingLoggington, Thing");

        }

        public void WriteThisHereThang()
        {
            Console.WriteLine("I am of writing this here thang");
            LogWriter lw = new LogWriter("LoggingLoggington, Thang");
        }

    }
}
