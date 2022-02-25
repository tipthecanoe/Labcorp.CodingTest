using System;

using Labcorp.CodingTest.Contract;

namespace Labcorp.CodingTest.Domain {

    public class Employee : IEmployee {

        #region Constructor
        public Employee(string id, EmployeeType type) {
            Id = id;
            Type = type;
            AccruedVacationDays = 0;
        }
        #endregion

        #region IEmployee Members
        public string Id {
            get;
            protected set;
        }

        public EmployeeType Type {
            get;
            protected set;
        }

        public float AccruedVacationDays {
            get;
            protected set;
        }

        public int TakenVacationDays {
            get;
            protected set;
        }

        public int WorkDays {
            get;
            protected set;
        }

        public void TakeVacation(int days) {
            if (days > 0) {
                if (days <= AccruedVacationDays) {
                    TakenVacationDays += days;
                    AccruedVacationDays -= days;
                }
                else {
                    throw new TakeVacationDaysException(
                        $"Number of vacation days requested exceeeds accrued vacation days. (RequestedDays={days}, AccruedVacationDays={AccruedVacationDays})"
                    );
                }
            }
            else {
                throw new TakeVacationDaysException(
                    $"Number of vacation days requested must be greater than 0. (RequestedDays={days})"
                );
            }
        }

        public virtual void Work(int days) {
            throw new NotImplementedException();
        }
        #endregion

        #region Protected Methods
        protected bool ValidateWorkDays(int days) {
            bool result = false; {
                if (days >= 0 && days <= 260) {
                    result = true;
                }
                else {
                    throw new WorkDaysException(
                        $"Number of work days must be between 0 and 260. (Value={days})"
                    );
                }
            }
            return result;
        }
        #endregion
    }
}