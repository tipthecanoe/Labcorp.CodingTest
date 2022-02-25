using System;

namespace Labcorp.CodingTest.Web.Domain {

    public class InvalidInputException : Exception {

        #region Constructor
        public InvalidInputException(string message) : base(message) {
        }
        #endregion
    }
}