using System;

using Labcorp.CodingTest.Contract;

namespace Labcorp.CodingTest.Domain {

    public class HourlyEmployee : Employee {

        #region Constructor
        public HourlyEmployee(int number) : base(number.ToString("00"), EmployeeType.Hourly) {
        }
        #endregion

        #region Public Methods
        public override void Work(int days) {
            if (ValidateWorkDays(days)) {
                WorkDays += days;
                AccruedVacationDays += (days * (int)AccrualVacationRate.Hourly) / (float)365;
            }
        }
        #endregion
    }
}