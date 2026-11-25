using SDKClassLibrary;
using SDKClassLibrary.CreditCardPmtMngRef;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerchantWebApplication
{
    public partial class submitDigitalOrderWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InvokeRequest_Button_Click(object sender, EventArgs e)
        {
            // When the button is clicked,
            SDKProgram program = new SDKProgram();

            CCDigOrderRq ccDigOrderRq = new CCDigOrderRq();
            ccDigOrderRq.RqUID = Input_RqUID.Text;
            ccDigOrderRq.ProfileCD = Input_ProfileCD.Text;
            ccDigOrderRq.CustomerName = Input_CustomerName.Text;
            ccDigOrderRq.MerchTrnsRef = Input_MerchTrnsRef.Text;
            ccDigOrderRq.MerchOrderInfo = Input_MerchOrderInfo.Text;
            ccDigOrderRq.LangCD = Input_LangCD.Text;
            ccDigOrderRq.InvoiceNo = Input_InvoiceNo.Text;
            ccDigOrderRq.DueAmount = (Input_DueAmount.Text.Trim()=="")? 0 : Convert.ToDecimal(Input_DueAmount.Text);
            ccDigOrderRq.ReturnURL = Input_ReturnURL.Text;
            ccDigOrderRq.billingInfo = new billingRqInfo();

            CCDigOrderRs ccDigOrderRs = program.submitDigitalOrder(ccDigOrderRq);
            if (ccDigOrderRs==null) return;
            Label1.Text = ccDigOrderRs.ccdigorderpmtinfo.RqUID;
            Label2.Text = ccDigOrderRs.ccdigorderpmtinfo.StatusCD;
            Label3.Text = ccDigOrderRs.ccdigorderpmtinfo.FinalURL;
            Label4.Text = ccDigOrderRs.ccdigorderpmtinfo.TrnsID;
            if(ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo!=null)
            {
                Label5.Text = ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo.InvoiceNo;
                Label6.Text = ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo.PeriodCD;
                Label7.Text = ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo.IssueDate;
                Label8.Text = ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo.DueDate;
                Label9.Text = ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo.IsInvoiceFinalized;
                Label10.Text = ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo.FinalBatchRunId;
                Label11.Text = ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo.PmtInitiator;
                Label12.Text = ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo.NetAmount.ToString();
                Label13.Text = ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo.Discount.ToString();
                Label14.Text = ccDigOrderRs.ccdigorderpmtinfo.BillingRsInfo.AmountBF.ToString();
            }
            // Display Div1 labels text.
            div1.Visible = true;
        }
    }
}