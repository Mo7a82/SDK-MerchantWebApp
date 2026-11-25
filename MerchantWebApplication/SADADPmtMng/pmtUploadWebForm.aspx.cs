using SDKClassLibrary;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerchantWebApplication.SADADPmtMng
{
    public partial class pmtUploadWebForm : GatewayPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InvokeRequest_Button_Click(object sender, EventArgs e)
        {
            // When the button is clicked,
            SDKProgram program = CreateSdk();

            SADADPmtUploadRq sadadBillLoadRq = new SADADPmtUploadRq();
            sadadBillLoadRq.RqUID = Input_RqUID.Text;
            sadadBillLoadRq.ProfileCD = Input_ProfileCD.Text;
            sadadBillLoadRq.InvoiceNo = Input_InvoiceNo.Text;
            sadadBillLoadRq.MerchTrnsRef = Input_MerchTrnsRef.Text;
            sadadBillLoadRq.AcquireTrnsRef = Input_AcquireTrnsRef.Text;
            sadadBillLoadRq.InvoiceCycle = Input_InvoiceCycle.Text;
            sadadBillLoadRq.BillingAcct = Input_BillingAcct.Text;
            sadadBillLoadRq.TrnsAmount = (Input_TrnsAmount.Text.Trim()=="") ? 0 : Convert.ToDecimal(Input_TrnsAmount.Text);
            if(Input_PrcDt.Text.Trim()!="") sadadBillLoadRq.PrcDt = Convert.ToDateTime(Input_PrcDt.Text);
            sadadBillLoadRq.PmtRefInfo = Input_PmtRefInfo.Text;
            sadadBillLoadRq.CustomerIDNo = Input_CustomerIDNo.Text;
            sadadBillLoadRq.CustomerIDTypeCD = Input_CustomerIDTypeCD.Text;
            sadadBillLoadRq.BankCD = Input_BankCD.Text;
            sadadBillLoadRq.BankBranchNo = Input_BankBranchNo.Text;
            sadadBillLoadRq.PmtAccessChannel = Input_PmtAccessChannel.Text;
            sadadBillLoadRq.District = Input_District.Text;
            sadadBillLoadRq.PmtMthdCD = Input_PmtMthdCD.Text;

            SADADPmtUploadRs sadadpmtUploadRs = program.pmtUpload(sadadBillLoadRq);
            if (sadadpmtUploadRs == null) { ShowError(program); return; }
            Label1.Text = sadadpmtUploadRs.sadadPmtUploadInfo.RqUID;
            Label2.Text = sadadpmtUploadRs.sadadPmtUploadInfo.StatusCD;
            Label3.Text = sadadpmtUploadRs.sadadPmtUploadInfo.TrnsID;
            Label4.Text = sadadpmtUploadRs.sadadPmtUploadInfo.IsPmtUploaded;
            if (sadadpmtUploadRs.sadadPmtUploadInfo.BillingRsInfo!=null)
            {
                Label5.Text = sadadpmtUploadRs.sadadPmtUploadInfo.BillingRsInfo.InvoiceNo;
                Label6.Text = sadadpmtUploadRs.sadadPmtUploadInfo.BillingRsInfo.IsInvoiceFinalized;
            }
            // Display Div1 labels text.
            div1.Visible = true;
        }
    }
}