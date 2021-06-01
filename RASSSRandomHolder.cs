using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
    static class RASSSRandomHolder
    {
        static public readonly Random random;

        static  RASSSRandomHolder()
        {
            random = new Random();
        }
    }
}
