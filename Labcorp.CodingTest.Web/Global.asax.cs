using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

using Labcorp.CodingTest.Contract;
using Labcorp.CodingTest.Domain;
using Labcorp.CodingTest.Web.Domain;

namespace Labcorp.CodingTest.Web {

    public class Global : HttpApplication {

        #region Protected Methods
        protected void Application_Start(object sender, EventArgs e) {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e) {
            PageProperties properties = new PageProperties(Session);
            properties.Employees = initializeEmployees();
        }
        #endregion

        #region Private Methods
        private IList<IEmployee> initializeEmployees() {
            IList<IEmployee> result = new List<IEmployee>(); {
                int number = 0;
                for (int index = 0; index <= 9; index ++) {
                    result.Add(new HourlyEmployee(number++));
                    result.Add(new SalariedEmployee(number++));
                    result.Add(new Manager(number++));
                }
            }
            return result;
        }
        #endregion
    }
}