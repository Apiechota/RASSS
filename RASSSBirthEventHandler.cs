using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
     class RASSSBirthEventHandler
    {
         public readonly Action<RASSSPerson> defaultBirthEventHandler = 
             delegate(RASSSPerson person) 
             {
                 Console.ForegroundColor = ConsoleColor.Yellow;
                 Console.WriteLine("Month #" + RASSSSimulationBoard.simulationMonthNumber + 
                     " A new person was born: " + person.personName);
                 Console.ForegroundColor = ConsoleColor.White;
             };
    }
}
