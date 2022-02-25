using System;

namespace Labcorp.CodingTest.Contract {
    public interface IEmployee {

        #region Members
        string Id { get; }
        EmployeeType Type { get; }
        float AccruedVacationDays { get; }
        int TakenVacationDays { get; }
        int WorkDays { get; }
        void TakeVacation(int days);
        void Work(int days);
        #endregion
    }
}