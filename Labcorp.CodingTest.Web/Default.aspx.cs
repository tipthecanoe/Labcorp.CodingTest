using System;
using System.Web.UI;

namespace Labcorp.CodingTest.Web {

    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {
            Response.Redirect("/PagesPostAuth/Home.aspx");
        }
    }
}