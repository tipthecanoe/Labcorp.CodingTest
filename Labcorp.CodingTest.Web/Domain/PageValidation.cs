using System;
using System.Web.UI.WebControls;

namespace Labcorp.CodingTest.Web.Domain {

    public static class PageValidation {

        #region Public Static Methods
        public static int ValidateNumericText(TextBox textBox) {
            int result = default(int); {
                if (!int.TryParse(textBox.Text.Trim(), out result)) {
                    throw new InvalidInputException(
                        $"Numeric input expected. (Value='{textBox.Text.Trim()}')"
                    );
                }
            }
            return result;
        }
        #endregion
    }
}