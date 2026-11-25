using SDKClassLibrary;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerchantWebApplication.PayPalPmtMng
{
    public partial class executePaymentWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InvokeRequest_Button_Click(object sender, EventArgs e)
        {
            // When the button is clicked,
            SDKProgram program = new SDKProgram();

            PPCaptureRq ppcaptureRq = new PPCaptureRq();
            ppcaptureRq.RqUID = Input_RqUID.Text;
            ppcaptureRq.ProfileCD = Input_ProfileCD.Text;
            ppcaptureRq.MerchTrnsRef = Input_MerchTrnsRef.Text;
            ppcaptureRq.AcquireTrnsRef = Input_AcquireTrnsRef.Text;
            ppcaptureRq.AcquireReceiptRef = Input_AcquireReceiptRef.Text;
            ppcaptureRq.PayerID = Input_PayerID.Text;
            ppcaptureRq.InvoiceNo = Input_InvoiceNo.Text;

            PPCaptureRs ppcaptureRs = program.executePayment(ppcaptureRq);
            if (ppcaptureRs==null) return;
            Label1.Text = ppcaptureRs.ppcapturePmtInfo.RqUID;
            Label2.Text = ppcaptureRs.ppcapturePmtInfo.StatusCD;
            Label3.Text = ppcaptureRs.ppcapturePmtInfo.TrnsID;
            Label4.Text = ppcaptureRs.ppcapturePmtInfo.TrnsAmount;
            Label5.Text = ppcaptureRs.ppcapturePmtInfo.AcquireTrnsRef;
            Label6.Text = ppcaptureRs.ppcapturePmtInfo.AcquireMessage;
            Label7.Text = ppcaptureRs.ppcapturePmtInfo.AcquireDebugId;
            if (ppcaptureRs.ppcapturePmtInfo.BillingRsInfo!=null)
            {
                Label8.Text = ppcaptureRs.ppcapturePmtInfo.BillingRsInfo.InvoiceNo;
                Label9.Text = ppcaptureRs.ppcapturePmtInfo.BillingRsInfo.IsInvoiceFinalized;
            }
            // Display Div1 labels text.
            div1.Visible = true;
        }
    }
}