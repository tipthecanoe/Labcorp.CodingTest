using System;

namespace Labcorp.CodingTest.Contract {

    public class TakeVacationDaysException : Exception {

        #region Constructor
        public TakeVacationDaysException(string message) : base(message) {
        }
        #endregion
    }
}