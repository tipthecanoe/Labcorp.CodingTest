using System;

using Labcorp.CodingTest.Contract;

namespace Labcorp.CodingTest.Domain {

    public class Manager : SalariedEmployee {

        #region Constructor
        public Manager(int number) : base(number.ToString("00"), EmployeeType.Manager) {
        }
        #endregion

        #region Public Methods
        public override void Work(int days) {
            if (ValidateWorkDays(days)) {
                WorkDays += days;
                AccruedVacationDays += (days * (int)AccrualVacationRate.Manager) / (float)365;
            }
        }
        #endregion
    }
}