using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Television : ElectronicDevice
    {
        //Er recieveren
        public void Off()
        {
            Console.WriteLine( "off");
        }

        public void On()
        {
            Console.WriteLine("on");
        }

        public void VolDown()
        {
            Console.WriteLine( "up");
        }

        public void VolUp()
        {
            Console.WriteLine("down");
        }
    }
}
