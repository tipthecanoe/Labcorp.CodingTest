using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Labcorp.CodingTest.Web.Domain {
    public class PageBase : Page {

        #region Protected Members
        protected bool IsInitialLoad {
            get {
                return !IsPostBack;
            }
        }

        protected PageProperties Properties {
            get;
            set;
        }
        #endregion

        #region Protected Methods
        protected override void OnPreInit(EventArgs e) {
            base.OnPreInit(e); {
                if (Session != null) {
                    Properties = new PageProperties(Session);
                }
            }
        }
        #endregion
    }
}