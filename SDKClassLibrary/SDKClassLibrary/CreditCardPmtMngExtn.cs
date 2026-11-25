using SDKClassLibrary.CreditCardPmtMngRef;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDKClassLibrary
{
    public class CCDigOrderRq
    {
        public string RqUID { get; set; }
        public string ProfileCD { get; set; }
        public string CustomerName { get; set; }
        public string MerchTrnsRef { get; set; }
        public string MerchOrderInfo { get; set; }
        public string LangCD { get; set; }
        public string InvoiceNo { get; set; }
        public decimal DueAmount { get; set; }
        public string ReturnURL { get; set; }
        public billingRqInfo billingInfo { get; set; }
    }
    public class CCDigOrderRs
    {
        public ccDigOrderPmtInfo ccdigorderpmtinfo { get; set; }
    }
    public class CCCaptureRq
    {
        public string RqUID { get; set; }
        public string ProfileCD { get; set; }
        public string AcquireTrnsRef { get; set; }
        public string MerchTrnsRef { get; set; }
        public string InvoiceNo { get; set; }
    }
    public class CCCaptureRs
    {
        public ccCapturePmtInfo cccapturePmtInfo { get; set; }
    }
    public class CCValidDigReceiptRq
    {
        public string RqUID { get; set; }
        public string ProfileCD { get; set; }
        public string BankRsQuery { get; set; }
    }
    public class CCValidDigReceiptRs
    {
        public ccValidDigReceiptPmtInfo ccvaliddigpmtinfo { get; set; }
    }
}
