using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
    class RASSSSimulationBoard
    {
        public static int simulationMonthNumber = 0;
        public static List<RASSSPerson> people;

        public static RASSSBirthEventHandler defaultBirthEventHandlerForPeople;
        public static RASSSGotJobEventHandler defaultGotJobEventHandlerForPeople;
        public static RASSSGotSalaryCallback defaultGotSalaryEventHandlerForPeople;
        public static RASSSDeathEventHandler defaultDeathEventHandlerForPeople;

        public static RASSSSimulationBoardMonth monthBuilder = new RASSSSimulationBoardMonth();

        public void startSimulation()
        {
            while(true)
            monthBuilder.buildMonth();
        }

        public RASSSSimulationBoard()
        {
            defaultBirthEventHandlerForPeople = new RASSSBirthEventHandler();
            defaultGotJobEventHandlerForPeople = new RASSSGotJobEventHandler();
            defaultGotSalaryEventHandlerForPeople = new RASSSGotSalaryCallback();
            defaultDeathEventHandlerForPeople = new RASSSDeathEventHandler();


            people = new List<RASSSPerson>();

            int n = 0;
            while (n < RASSSDefinitions.populationFactor)
            {
                people.Add(new RASSSPerson());
                n++;
            }
        }


    }

}

