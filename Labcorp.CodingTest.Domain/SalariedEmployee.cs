using System;

using Labcorp.CodingTest.Contract;

namespace Labcorp.CodingTest.Domain {

    public class SalariedEmployee : Employee {

        #region Constructor
        public SalariedEmployee(string id, EmployeeType type) : base(id, type) {
        }

        public SalariedEmployee(int number) : this(number.ToString("00"), EmployeeType.Salaried) {
        }
        #endregion

        #region Public Methods
        public override void Work(int days) {
            if (ValidateWorkDays(days)) {
                WorkDays += days;
                AccruedVacationDays += (days * (int)AccrualVacationRate.Salaried) / (float)365;
            }
        }
        #endregion
    }
}