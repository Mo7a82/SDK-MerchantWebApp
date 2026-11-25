using SDKClassLibrary.SADADPmtMngRef;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDKClassLibrary
{
    public class SADADBillLoadRq
    {
        public string RqUID { get; set; }
        public string ProfileCD { get; set; }
        public string CustomerName { get; set; }
        public string MerchTrnsRef { get; set; }
        public string MerchOrderInfo { get; set; }
        public string MerchOrderAlias { get; set; }
        public string IsPartialPayment { get; set; }
        public string LangCD { get; set; }
        public decimal DueAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public decimal MinAmount { get; set; }
        public DateTime DueDt { get; set; }
        public DateTime ExpDt { get; set; }
        public DateTime OpenDt { get; set; }
        public DateTime CloseDt { get; set; }
        public string InvoiceNo { get; set; }
        public string BillingAcct { get; set; }
        public string InvoiceRefInfo { get; set; }
        public string CustomerIDNo { get; set; }
        public string CustomerIDTypeCD { get; set; }
        public string InvoiceSttsCD { get; set; }
        public string BillCategory { get; set; }
        public invoiceAdditionalInfo[] invoiceAdditionalInfoList { get; set; }
        public billingRqInfo billingInfo { get; set; }
    }
    public class SADADBillLoadRs
    {
        public sadadBillLoadPmtInfo sadadbillLoadinfo { get; set; }
    }
    public class SADADPmtUploadRq
    {
        public string RqUID { get; set; }
        public string ProfileCD { get; set; }
        public string InvoiceNo { get; set; }
        public string MerchTrnsRef { get; set; }
        public string AcquireTrnsRef { get; set; }
        public string InvoiceCycle { get; set; }
        public string BillingAcct { get; set; }
        public decimal TrnsAmount { get; set; }
        public DateTime PrcDt { get; set; }
        public string PmtRefInfo { get; set; }
        public string CustomerIDNo { get; set; }
        public string CustomerIDTypeCD { get; set; }
        public string BankCD { get; set; }
        public string BankBranchNo { get; set; }
        public string PmtAccessChannel { get; set; }
        public string District { get; set; }
        public string PmtMthdCD { get; set; }
    }
    public class SADADPmtUploadRs
    {
        public sadadPmtUploadPmtInfo sadadPmtUploadInfo { get; set; }
    }
}
