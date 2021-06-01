using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
    class RASSSSimulationBoardMonth
    {
        public void buildMonth()
        {
            RASSSSimulationBoard.simulationMonthNumber++;

            Console.WriteLine("");
            Console.WriteLine("Month# " + RASSSSimulationBoard.simulationMonthNumber);
            Console.Write("Before Simulation: ");
            RASSSBankAccount.publishFinancialReport();

            int n = 0;
            while (n < RASSSSimulationBoard.people.Count)
            {
                RASSSSimulationBoard.people[n].validateCurrentMonth();
                n++;
            }

            Console.Write("After Simulation: ");
            RASSSBankAccount.publishFinancialReport();
            Console.WriteLine("");

            System.Threading.Thread.Sleep(500);
            
        }
    }
}
