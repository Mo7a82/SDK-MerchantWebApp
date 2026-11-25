using SDKClassLibrary;
using SDKClassLibrary.CreditCardPmtMngRef;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerchantWebApplication
{
    public partial class validateReceiptWebForm : GatewayPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InvokeRequest_Button_Click(object sender, EventArgs e)
        {
            // When the button is clicked,
            SDKProgram program = CreateSdk();

            CCValidDigReceiptRq ccValidDigReceiptRq = new CCValidDigReceiptRq();
            ccValidDigReceiptRq.RqUID = Input_RqUID.Text;
            ccValidDigReceiptRq.ProfileCD = Input_ProfileCD.Text;
            ccValidDigReceiptRq.BankRsQuery = Input_BankRsQuery.Text;

            CCValidDigReceiptRs ccValidDigReceiptRs = program.validateReceipt(ccValidDigReceiptRq);
            if (ccValidDigReceiptRs == null) { ShowError(program); return; }
            Label1.Text = ccValidDigReceiptRs.ccvaliddigpmtinfo.RqUID;
            Label2.Text = ccValidDigReceiptRs.ccvaliddigpmtinfo.StatusCD;
            Label3.Text = ccValidDigReceiptRs.ccvaliddigpmtinfo.IsDigReceiptValid;
            Label4.Text = ccValidDigReceiptRs.ccvaliddigpmtinfo.TrnsID;
            Label5.Text = ccValidDigReceiptRs.ccvaliddigpmtinfo.AcquireReceiptRef;
            Label6.Text = ccValidDigReceiptRs.ccvaliddigpmtinfo.AcquireMessage;
            Label7.Text = ccValidDigReceiptRs.ccvaliddigpmtinfo.AcquireTrnsRef;
            // Display Div1 labels text.
            div1.Visible = true;
        }
    }
}