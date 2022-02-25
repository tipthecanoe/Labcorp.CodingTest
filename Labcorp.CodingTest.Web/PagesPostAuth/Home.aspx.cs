using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Labcorp.CodingTest.Contract;
using Labcorp.CodingTest.Domain;
using Labcorp.CodingTest.Web.Domain;

namespace Labcorp.CodingTest.Web.PagesPostAuth {

    public partial class Home : PageBase {

        #region Protected Methods
        protected void Page_Load(object sender, EventArgs e) {
            //if (IsInitialLoad) {
            //    initializeEmployees();
            //}
            loadPage();
        }

        protected void gridEmployees_RowCommand(object sender, GridViewCommandEventArgs e) {
            if (e.CommandName == "Edit") {
                int index = Convert.ToInt32(e.CommandArgument);
                Properties.SelectedEmployee = Properties.Employees[index];
                Response.Redirect("Edit.aspx");
            }
        }
        #endregion

        #region Private Methods
        private void loadPage() {
            gridEmployees.DataSource = Properties.Employees;
            gridEmployees.DataBind();
        }
        #endregion
    }
}