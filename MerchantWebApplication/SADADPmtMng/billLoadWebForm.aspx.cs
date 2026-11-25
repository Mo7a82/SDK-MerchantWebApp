using SDKClassLibrary;
using SDKClassLibrary.SADADPmtMngRef;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerchantWebApplication.SADADPmtMng
{
    public partial class billLoadWebForm : GatewayPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InvokeRequest_Button_Click (object sender, EventArgs e)
        {
            
            // When the button is clicked,
            SDKProgram program = CreateSdk();

            SADADBillLoadRq sadadBillLoadRq = new SADADBillLoadRq();
            sadadBillLoadRq.RqUID = Input_RqUID.Text;
            sadadBillLoadRq.ProfileCD = Input_ProfileCD.Text;
            sadadBillLoadRq.CustomerName = Input_CustomerName.Text;
            sadadBillLoadRq.MerchTrnsRef = Input_MerchTrnsRef.Text;
            sadadBillLoadRq.MerchOrderInfo = Input_MerchOrderInfo.Text;
            sadadBillLoadRq.MerchOrderAlias = Input_MerchOrderAlias.Text;
            sadadBillLoadRq.IsPartialPayment = Input_IsPartialPayment.Text;
            sadadBillLoadRq.LangCD = Input_LangCD.Text;
            sadadBillLoadRq.DueAmount = (Input_DueAmount.Text.Trim()=="")? 0 : Convert.ToDecimal(Input_DueAmount.Text);
            sadadBillLoadRq.MaxAmount = (Input_MaxAmount.Text.Trim() == "") ? 0 : Convert.ToDecimal(Input_MaxAmount.Text);
            sadadBillLoadRq.MinAmount = (Input_MinAmount.Text.Trim() == "") ? 0 : Convert.ToDecimal(Input_MinAmount.Text);
            sadadBillLoadRq.InvoiceNo = Input_InvoiceNo.Text;
            sadadBillLoadRq.InvoiceRefInfo = Input_InvoiceRefInfo.Text;
            if (Input_DueDt.Text.Trim() != "") sadadBillLoadRq.DueDt = Convert.ToDateTime(Input_DueDt.Text);
            if (Input_ExpDt.Text.Trim() != "") sadadBillLoadRq.ExpDt = Convert.ToDateTime(Input_ExpDt.Text);
            if (Input_OpenDt.Text.Trim()!="") sadadBillLoadRq.OpenDt = Convert.ToDateTime(Input_OpenDt.Text);
            if (Input_CloseDt.Text.Trim() != "") sadadBillLoadRq.CloseDt = Convert.ToDateTime(Input_CloseDt.Text);
            sadadBillLoadRq.CustomerIDNo = Input_CustomerIDNo.Text;
            sadadBillLoadRq.CustomerIDTypeCD = Input_CustomerIDTypeCD.Text;
            sadadBillLoadRq.InvoiceSttsCD = Input_InvoiceSttsCD.Text;
            sadadBillLoadRq.BillCategory = Input_BillCategory.Text;

            sadadBillLoadRq.billingInfo = new billingRqInfo();
            sadadBillLoadRq.billingInfo.InvTypCD = Input_InvTypCD.Text;
            sadadBillLoadRq.billingInfo.SrvCD = Input_SrvCD.Text;
            sadadBillLoadRq.billingInfo.CusId = Input_CusId.Text;
            sadadBillLoadRq.billingInfo.PmtRespId = Input_PmtRespId.Text;
            if (Input_StartDate.Text.Trim() != "") sadadBillLoadRq.billingInfo.StartDate = Convert.ToDateTime(Input_StartDate.Text);
            if (Input_EndDate.Text.Trim() != "") sadadBillLoadRq.billingInfo.EndDate = Convert.ToDateTime(Input_EndDate.Text);
            sadadBillLoadRq.billingInfo.Discount = (Input_Discount.Text.Trim() == "") ? 0 : Convert.ToInt32(Input_Discount.Text);
            sadadBillLoadRq.billingInfo.IsLumpSum = Input_IsLumpSum.Text;
            sadadBillLoadRq.billingInfo.PmtInitiator = Input_PmtInitiator.Text;
            sadadBillLoadRq.billingInfo.Notes = Input_Notes.Text;

            invoiceLineItemInfo invoiceLineItem = new invoiceLineItemInfo();
            sadadBillLoadRq.billingInfo.InvoiceLineItemsList = new invoiceLineItemInfo[1];
            invoiceLineItem.Rate = (Input_LineRate1.Text.Trim()=="") ? 0 : Convert.ToDecimal(Input_LineRate1.Text);
            invoiceLineItem.Quantity = (Input_LineQuantity1.Text.Trim() == "") ? 0 : Convert.ToInt32(Input_LineQuantity1.Text);
            sadadBillLoadRq.billingInfo.InvoiceLineItemsList[0] = invoiceLineItem;

            SADADBillLoadRs sadadBillLoadRs = program.billLoad(sadadBillLoadRq);
            if (sadadBillLoadRs == null) { ShowError(program); return; }
            Label1.Text = sadadBillLoadRs.sadadbillLoadinfo.RqUID;
            Label2.Text = sadadBillLoadRs.sadadbillLoadinfo.StatusCD;
            Label3.Text = sadadBillLoadRs.sadadbillLoadinfo.TrnsID;
            Label4.Text = sadadBillLoadRs.sadadbillLoadinfo.IsBillUploaded;
            Label5.Text = sadadBillLoadRs.sadadbillLoadinfo.IsBillCancelled;
            div1.Visible = true;
            
        }

        protected void AddInvoiceLine_Button_Click(object sender, EventArgs e)
        {

        }
    }
}