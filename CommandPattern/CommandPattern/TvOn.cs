using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class TvOn : Command
    {
        private ElectronicDevice electronic;

        public TvOn(ElectronicDevice electronicDevice)
        {
            electronic = electronicDevice;
        }

        public void Execute()
        {
           electronic.On();
         
        }
    }
}
