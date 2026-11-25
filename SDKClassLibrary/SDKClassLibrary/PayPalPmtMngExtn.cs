using SDKClassLibrary.PayPalPmtMngRef;
using System;
using System.Collections.Generic;
using System.Web;

namespace SDKClassLibrary
{
    public class PPDigOrderRq
    {
        public string RqUID { get; set; }
        public string ProfileCD { get; set; }
        public string CustomerName { get; set; }
        public string MerchTrnsRef { get; set; }
        public string MerchOrderInfo { get; set; }
        public string InvoiceNo { get; set; }
        public string LangCD { get; set; }
        public decimal DueAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal Tax { get; set; }
        public string CurrencyCD { get; set; }
        public string ApprovalURL { get; set; }
        public string CancelURL { get; set; }
        public psItem[] PPDigOrderItems { get; set; }
        public billingRqInfo billingInfo { get; set; }
    }
    public class PPDigOrderRs
    {
        public ppDigOrderPmtInfo ppdigOrderPmtInfo { get; set; }
    }
    public class PPCaptureRq
    {
        public string RqUID { get; set; }
        public string ProfileCD { get; set; }
        public string MerchTrnsRef { get; set; }
        public string AcquireTrnsRef { get; set; }
        public string AcquireReceiptRef { get; set; }
        public string PayerID { get; set; }
        public string InvoiceNo { get; set; }
    }
    public class PPCaptureRs
    {
        public ppCapturePmtInfo ppcapturePmtInfo { get; set; }
    }
}