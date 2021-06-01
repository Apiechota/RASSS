using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
    class RASSSDeathEventHandler
    {
        public readonly Action<RASSSPerson> defaultDeathEventHandler =
            delegate(RASSSPerson person)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Month #" + RASSSSimulationBoard.simulationMonthNumber +
                    " Person: " + person.personName + " died.");
                Console.ForegroundColor = ConsoleColor.White;
            };
    }
}
