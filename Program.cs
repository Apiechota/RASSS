using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            RASSSSimulationBoard board = new RASSSSimulationBoard();
            board.startSimulation();
        }
    }
}
