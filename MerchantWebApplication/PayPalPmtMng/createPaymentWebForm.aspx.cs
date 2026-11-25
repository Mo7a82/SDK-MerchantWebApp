using SDKClassLibrary;
using SDKClassLibrary.PayPalPmtMngRef;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerchantWebApplication.PayPalPmtMng
{
    public partial class createPaymentWebForm : GatewayPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InvokeRequest_Button_Click(object sender, EventArgs e)
        {
            
            // When the button is clicked,
            SDKProgram program = CreateSdk();

            PPDigOrderRq ppDigOrderRq = new PPDigOrderRq();
            ppDigOrderRq.RqUID = Input_RqUID.Text;
            ppDigOrderRq.ProfileCD = Input_ProfileCD.Text;
            ppDigOrderRq.CustomerName = Input_CustomerName.Text;
            ppDigOrderRq.MerchTrnsRef = Input_MerchTrnsRef.Text;
            ppDigOrderRq.MerchOrderInfo = Input_MerchOrderInfo.Text;
            ppDigOrderRq.LangCD = Input_LangCD.Text;
            ppDigOrderRq.InvoiceNo = Input_InvoiceNo.Text;
            ppDigOrderRq.DueAmount = (Input_DueAmount.Text.Trim()=="")? 0 : Convert.ToDecimal(Input_DueAmount.Text);
            ppDigOrderRq.Tax = (Input_Tax.Text.Trim() == "") ? 0 : Convert.ToDecimal(Input_Tax.Text);
            ppDigOrderRq.ShippingAmount = (Input_ShippingAmount.Text.Trim() == "") ? 0 : Convert.ToDecimal(Input_ShippingAmount.Text);
            ppDigOrderRq.CurrencyCD = Input_CurrencyCD.Text;
            ppDigOrderRq.ApprovalURL = Input_ApprovalURL.Text;
            ppDigOrderRq.CancelURL = Input_CancelURL.Text;

            psItem pitem = new psItem();
            ppDigOrderRq.PPDigOrderItems = new psItem[2];
            pitem.Name = Input_ItemName1.Text;
            pitem.Price = Input_Price1.Text;
            pitem.Quantity = Input_Quantity1.Text;
            ppDigOrderRq.PPDigOrderItems[0] = pitem;
            pitem.Name = Input_ItemName2.Text;
            pitem.Price = Input_Price2.Text;
            pitem.Quantity = Input_Quantity2.Text;
            ppDigOrderRq.PPDigOrderItems[1] = pitem;

            ppDigOrderRq.billingInfo = new billingRqInfo();
            ppDigOrderRq.billingInfo.InvTypCD = Input_InvTypCD.Text;
            ppDigOrderRq.billingInfo.SrvCD = Input_SrvCD.Text;
            ppDigOrderRq.billingInfo.CusId = Input_CusId.Text;
            ppDigOrderRq.billingInfo.PmtRespId = Input_PmtRespId.Text;
            if(Input_StartDate.Text.Trim()!="") ppDigOrderRq.billingInfo.StartDate = Convert.ToDateTime(Input_StartDate.Text);
            if (Input_EndDate.Text.Trim() != "") ppDigOrderRq.billingInfo.EndDate = Convert.ToDateTime(Input_EndDate.Text);
            ppDigOrderRq.billingInfo.Discount = (Input_Discount.Text.Trim()=="")? 0 : Convert.ToInt32(Input_Discount.Text);
            ppDigOrderRq.billingInfo.IsLumpSum = Input_IsLumpSum.Text;
            ppDigOrderRq.billingInfo.PmtInitiator = Input_PmtInitiator.Text;
            ppDigOrderRq.billingInfo.Notes = Input_Notes.Text;

            invoiceLineItemInfo invoiceLineItem = new invoiceLineItemInfo();
            ppDigOrderRq.billingInfo.InvoiceLineItemsList = new invoiceLineItemInfo[2];
            invoiceLineItem.Rate = (Input_LineRate1.Text.Trim() == "") ? 0 : Convert.ToDecimal(Input_LineRate1.Text);
            invoiceLineItem.Quantity = (Input_LineQuantity1.Text.Trim() == "") ? 0 : Convert.ToInt32(Input_LineQuantity1.Text);
            ppDigOrderRq.billingInfo.InvoiceLineItemsList[0] = invoiceLineItem;
            invoiceLineItem.Rate = (Input_LineRate2.Text.Trim() == "") ? 0 : Convert.ToDecimal(Input_LineRate2.Text);
            invoiceLineItem.Quantity = (Input_LineQuantity2.Text.Trim() == "") ? 0 : Convert.ToInt32(Input_LineQuantity2.Text);
            ppDigOrderRq.billingInfo.InvoiceLineItemsList[1] = invoiceLineItem;

            PPDigOrderRs ppDigOrderRs = program.createPayment(ppDigOrderRq);
            if (ppDigOrderRs == null) { ShowError(program); return; }
            Label1.Text = ppDigOrderRs.ppdigOrderPmtInfo.RqUID;
            Label2.Text = ppDigOrderRs.ppdigOrderPmtInfo.StatusCD;
            Label3.Text = ppDigOrderRs.ppdigOrderPmtInfo.TrnsID;
            Label4.Text = ppDigOrderRs.ppdigOrderPmtInfo.FinalURL;
            Label5.Text = ppDigOrderRs.ppdigOrderPmtInfo.TotalAmount;
            Label6.Text = ppDigOrderRs.ppdigOrderPmtInfo.AcquireTrnsRef;
            Label7.Text = ppDigOrderRs.ppdigOrderPmtInfo.AcquireReceiptRef;
            Label8.Text = ppDigOrderRs.ppdigOrderPmtInfo.AcquireMessage;
            // Display Div1 labels text.
            div1.Visible = true;
            
        }

        protected void AddItem_Button_Click(object sender, EventArgs e)
        {
            /*
            Table table = (Table)Page.FindControl("RequestInputTable1");
            TableRow itemdetailsrow = (TableRow)Page.FindControl("ItmDetails");
            TableRow row = new TableRow();
            row = itemdetailsrow;
            if (table != null)
            {
                table.Rows.Add(row);
            }
            */
        }

        protected void AddInvoiceLine_Button_Click (object sender, EventArgs e)
        {

        }
    }
}