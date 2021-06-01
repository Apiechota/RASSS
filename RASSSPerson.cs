using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceAndSalarySimulationSystem
{
    class RASSSPerson
    {
        public String personName;
        public readonly int birthDate;
        public readonly int lifeDuration;
        public readonly int salary;
        public readonly int jobGetDate;
        public readonly Boolean isHappy;
        public readonly int returnSalary;

        public static int lastestPersonID = 0;

        public readonly Action<RASSSPerson> birthCallback;
        public readonly Action<RASSSPerson> gotJobCallback;
        public readonly Action<RASSSPerson> gotSalaryCallback;
        public readonly Action<RASSSPerson> deathCallback;

        public RASSSPerson()
        {
            

            this.personName = "Person #" + lastestPersonID;
            lastestPersonID++;
            this.birthDate = RASSSRandomHolder.random.Next(0, RASSSDefinitions.simulationDuration );
            this.isHappy = true;
            this.jobGetDate = RASSSRandomHolder.random.Next(18, 25) + this.birthDate;
            this.lifeDuration = RASSSRandomHolder.random.Next(76, 100);
            this.salary = RASSSRandomHolder.random.Next(RASSSDefinitions.minimumPension, RASSSDefinitions.maximumPension);
            this.returnSalary = this.salary * (75 - this.jobGetDate) / (this.lifeDuration - 75);

            this.birthCallback = RASSSSimulationBoard.defaultBirthEventHandlerForPeople.defaultBirthEventHandler;
            this.gotJobCallback = RASSSSimulationBoard.defaultGotJobEventHandlerForPeople.defaultGotJobEventHandler;
            this.gotSalaryCallback = RASSSSimulationBoard.defaultGotSalaryEventHandlerForPeople.defaultGotSalaryEventHandler;
            this.deathCallback = RASSSSimulationBoard.defaultDeathEventHandlerForPeople.defaultDeathEventHandler;

            Console.WriteLine("Person with name " + personName + " was created.");

        }

        public void validateCurrentMonth()
        {
            if (RASSSSimulationBoard.simulationMonthNumber == this.birthDate)
                birthCallback(this);

            if (RASSSSimulationBoard.simulationMonthNumber == this.jobGetDate)
                gotJobCallback(this);

            if (RASSSSimulationBoard.simulationMonthNumber == 75 + this.birthDate)
                gotSalaryCallback(this);

            if (RASSSSimulationBoard.simulationMonthNumber == this.birthDate + this.lifeDuration)
                deathCallback(this);

            if (RASSSSimulationBoard.simulationMonthNumber >= this.jobGetDate &&
                RASSSSimulationBoard.simulationMonthNumber <= 75)
                RASSSBankAccount.AddMoney((int) (this.salary * RASSSDefinitions.salaryToPensionRatio));

            if (RASSSSimulationBoard.simulationMonthNumber > 75 &&
                RASSSSimulationBoard.simulationMonthNumber <= this.birthDate + this.lifeDuration)
                RASSSBankAccount.RemoveMoney((int)(this.returnSalary * RASSSDefinitions.salaryToPensionRatio));
        }
    }
}
 