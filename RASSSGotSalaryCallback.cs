using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
    class RASSSGotSalaryCallback
    {
        public readonly Action<RASSSPerson> defaultGotSalaryEventHandler =
            delegate(RASSSPerson person)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Month #" + RASSSSimulationBoard.simulationMonthNumber +
                    " Person: " + person.personName + " got a salary.");
                Console.ForegroundColor = ConsoleColor.White;
            };
    }
}
