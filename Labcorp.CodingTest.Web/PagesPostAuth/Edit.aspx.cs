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
    public partial class Edit : PageBase {
        
        #region Protected Methods
        protected void Page_Load(object sender, EventArgs e) {
            if (IsInitialLoad) {
                populateEmployee(Properties.SelectedEmployee);
            }
        }

        protected void buttonApply_Click(object sender, EventArgs e) {
            applyHours();
        }

        protected void buttonCancel_Click(object sender, EventArgs e) {
            Response.Redirect("Home.aspx");
        }

        protected void buttonOK_Click(object sender, EventArgs e) {
            if (applyHours()) {
                Response.Redirect("Home.aspx");
            }
        }
        #endregion

        #region Private Methods
        private void populateEmployee(IEmployee employee) {
            if (employee != null) {
                labelEmployeeID.Text = employee.Id;
                labelEmployeeType.Text = employee.Type.ToString();
                labelDaysWorked.Text = employee.WorkDays.ToString();
                labelVacationDaysAccrued.Text = employee.AccruedVacationDays.ToString("0.00");
                labelVacationDaysTaken.Text = employee.TakenVacationDays.ToString();
            }
            else {
                labelMessage.Text = "An employee has not been selected.";
            }
        }

        private bool applyHours() {
            bool result = false; {
                labelMessage.Text = string.Empty;
                try {
                    int daysWorked = PageValidation.ValidateNumericText(textDaysWorked);
                    int vacationDaysTaken = PageValidation.ValidateNumericText(textVacationDaysTaken);

                    if (daysWorked > 0 || vacationDaysTaken > 0) {
                        IEmployee employee = Properties.SelectedEmployee;
                        if (daysWorked > 0) {
                            employee.Work(daysWorked);
                            Properties.SelectedEmployee = employee;
                        }
                        if (vacationDaysTaken > 0) {
                            employee.TakeVacation(vacationDaysTaken);
                            Properties.SelectedEmployee = employee;
                        }
                        result = true;
                    }
                }
                catch (InvalidInputException ex) {
                    labelMessage.Text = ex.Message;
                }
                catch (WorkDaysException ex) {
                    labelMessage.Text = ex.Message;
                }
                catch (TakeVacationDaysException ex) {
                    labelMessage.Text = ex.Message;
                }
                finally {
                    populateEmployee(Properties.SelectedEmployee);
                    textDaysWorked.Text = "0";
                    textVacationDaysTaken.Text = "0";
                }
            }
            return result;
        }
        #endregion
    }
}