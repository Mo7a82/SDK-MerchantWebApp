using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SDKClassLibrary;

namespace MerchantWebApplication
{
    /// <summary>
    /// Base class for the test pages. It builds an SDKProgram from the
    /// connection fields at the top of each page, falling back to Web.config
    /// for anything left empty, and shows SDK errors on the page.
    /// </summary>
    public class GatewayPage : Page
    {
        protected SDKProgram CreateSdk()
        {
            GatewaySettings settings = GatewaySettings.FromConfig();

            string userName = TextOf("Input_userName");
            string password = TextOf("Input_password");
            if (userName != null) settings.UserName = userName;
            if (password != null) settings.Password = password;

            string endpoint = IsProductionMode() ? TextOf("Input_productionURL") : TextOf("Input_testingURL");
            return new SDKProgram(settings, endpoint);
        }

        /// <summary>Shows the last SDK error above the form.</summary>
        protected void ShowError(SDKProgram sdk)
        {
            string message = sdk.LastError != null ? sdk.LastError.Message : "The call returned no data.";
            Literal error = new Literal();
            error.Text = "<p><font class=\"error\">Call failed: " + HttpUtility.HtmlEncode(message) + "</font></p>";
            Form.Controls.AddAt(0, error);
        }

        private bool IsProductionMode()
        {
            DropDownList mode = FindControlRecursive(this, "DropDownList1") as DropDownList;
            return mode != null && mode.SelectedValue == "Production";
        }

        private string TextOf(string id)
        {
            TextBox box = FindControlRecursive(this, id) as TextBox;
            if (box == null || box.Text.Trim().Length == 0) return null;
            return box.Text.Trim();
        }

        private static Control FindControlRecursive(Control root, string id)
        {
            if (root.ID == id) return root;
            foreach (Control child in root.Controls)
            {
                Control found = FindControlRecursive(child, id);
                if (found != null) return found;
            }
            return null;
        }
    }
}
