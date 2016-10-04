using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface ElectronicDevice
    {
        void On();
        void Off();
        void VolUp();
        void VolDown();

    }
}
