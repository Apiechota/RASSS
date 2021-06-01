using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
    class RASSSGotJobEventHandler
    {
        public readonly Action<RASSSPerson> defaultGotJobEventHandler =
            delegate(RASSSPerson person)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Month #" + RASSSSimulationBoard.simulationMonthNumber +
                    " Person: " + person.personName + "got a job.");
                Console.ForegroundColor = ConsoleColor.White;
            };
    }
}
