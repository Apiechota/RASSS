using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
    static class RASSSDefinitions
    {
        static readonly  public int simulationDuration;
        static readonly public int populationFactor;
        static readonly public float salaryToPensionRatio;
        static readonly public int minimumPension;
        static readonly public int maximumPension;


        static   RASSSDefinitions()
        {
            simulationDuration = 500;
            populationFactor = 300;
            salaryToPensionRatio = 0.25F;
            minimumPension = 1500;
            maximumPension = 100000;
        }
    }
}
