using System;
using System.Collections.Generic;
using System.Web.SessionState;

using Labcorp.CodingTest.Contract;

namespace Labcorp.CodingTest.Web.Domain {

    public class PageProperties {

        #region Constructors
        public PageProperties(HttpSessionState session) {
            Session = session;
        }
        #endregion

        #region Public/Protected Members
        public HttpSessionState Session {
            get;
            protected set;
        }
        #endregion

        #region Public Members
        public IList<IEmployee> Employees {
            get {
                return Session[SessionKey.Employees] as IList<IEmployee> ?? new List<IEmployee>();
            }
            set {
                Session [SessionKey.Employees] = value;
            }
        }

        public IEmployee SelectedEmployee {
            get {
                return Session[SessionKey.SelectedEmployee] as IEmployee;
            }
            set {
                Session [SessionKey.SelectedEmployee] = value;
            }
        }
        #endregion

        private class SessionKey {

            #region Members
            public const string Employees = "Employees";
            public const string SelectedEmployee = "SelectedEmployee";
            #endregion
        }
    }
}