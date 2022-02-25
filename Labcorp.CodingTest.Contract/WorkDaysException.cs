using System;

namespace Labcorp.CodingTest.Contract {

    public class WorkDaysException : Exception {

        #region Constructor
        public WorkDaysException(string message) : base(message) {
        }
        #endregion
    }
}