using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
    static class RASSSBankAccount
    {
        static public int moneyAmount = 0;

        static public void AddMoney(int amount)
        {
            moneyAmount += amount;
        }
        static public void RemoveMoney(int amount)
        {
            moneyAmount -= amount;
        }

        static public void publishFinancialReport()
        {
            Console.WriteLine("RASSS has " + moneyAmount +
                " money units in the bank account for month # " + RASSSSimulationBoard.simulationMonthNumber );
        }
    }
}
