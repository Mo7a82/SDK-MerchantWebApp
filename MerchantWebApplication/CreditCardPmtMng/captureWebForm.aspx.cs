using SDKClassLibrary;
using SDKClassLibrary.CreditCardPmtMngRef;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerchantWebApplication
{
    public partial class captureWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InvokeRequest_Button_Click(object sender, EventArgs e)
        {
            // When the button is clicked,
            SDKProgram program = new SDKProgram();

            CCCaptureRq ccCaptureRq = new CCCaptureRq();
            ccCaptureRq.RqUID = Input_RqUID.Text;
            ccCaptureRq.ProfileCD = Input_ProfileCD.Text;
            ccCaptureRq.AcquireTrnsRef = Input_AcquireTrnsRef.Text;
            ccCaptureRq.MerchTrnsRef = Input_MerchTrnsRef.Text;

            CCCaptureRs ccCaptureRs = program.capture(ccCaptureRq);
            if (ccCaptureRs == null) return;
            Label1.Text = ccCaptureRs.cccapturePmtInfo.RqUID;
            Label2.Text = ccCaptureRs.cccapturePmtInfo.StatusCD;
            Label3.Text = ccCaptureRs.cccapturePmtInfo.TrnsID;
            Label4.Text = ccCaptureRs.cccapturePmtInfo.TrnsAmount;
            Label5.Text = ccCaptureRs.cccapturePmtInfo.AcquireTrnsRef;
            Label6.Text = ccCaptureRs.cccapturePmtInfo.AcquireMessage;
            if (ccCaptureRs.cccapturePmtInfo.BillingRsInfo!=null)
            {
                Label7.Text = ccCaptureRs.cccapturePmtInfo.BillingRsInfo.InvoiceNo;
                Label8.Text = ccCaptureRs.cccapturePmtInfo.BillingRsInfo.IsInvoiceFinalized;
            }
            // Display Div1 labels text.
            div1.Visible = true;
        }
    }
}