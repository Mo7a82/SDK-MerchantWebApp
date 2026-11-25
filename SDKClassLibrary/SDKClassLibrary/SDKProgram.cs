using System;
using System.Collections.Generic;
using System.Text;
using SDKClassLibrary.CreditCardPmtMngRef;
using SDKClassLibrary.SADADPmtMngRef;
using SDKClassLibrary.PayPalPmtMngRef;
using Microsoft.Web.Services2;
using Microsoft.Web.Services2.Security.Tokens;

namespace SDKClassLibrary
{
    public class SDKProgram
    {
        #region Credit Card Payment Management
        public CCDigOrderRs submitDigitalOrder(CCDigOrderRq ccDigOrderRq)
        {
            CCDigOrderRs ccDigOrderRs = new CCDigOrderRs();

            try
            {
                CreditCardPmtMng service = new CreditCardPmtMng();
                string userName = "user";
                //string userName = System.Configuration.ConfigurationManager.AppSettings["userName"].ToString();
                string password = "21bd12dc183f740ee76f27b78eb39c8ad972a757";
                //string password = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
                UsernameToken token = new UsernameToken(userName, password, PasswordOption.SendPlainText);
                service.RequestSoapContext.Security.MustUnderstand = false;
                service.RequestSoapContext.Security.Tokens.Add(token);

                bool DueAmountSpecified = false;
                if (ccDigOrderRq.DueAmount == 0)
                    DueAmountSpecified = false;
                else
                    DueAmountSpecified = true;
                ccDigOrderPmtInfo ccdigorderinfo = service.submitDigitalOrder(ccDigOrderRq.RqUID, ccDigOrderRq.ProfileCD, ccDigOrderRq.CustomerName, ccDigOrderRq.MerchTrnsRef, ccDigOrderRq.MerchOrderInfo, ccDigOrderRq.InvoiceNo, ccDigOrderRq.LangCD, ccDigOrderRq.DueAmount, DueAmountSpecified, ccDigOrderRq.ReturnURL, ccDigOrderRq.billingInfo);
                System.Console.WriteLine("Call Service: Credit Card Submit Digital Order > Successfully");
                ccDigOrderRs.ccdigorderpmtinfo = ccdigorderinfo;
                return ccDigOrderRs;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Call Service: Credit Card Submit Digital Order > Exception:" + ex.Message.ToString());
                return null;
            }
        }
        public CCCaptureRs capture(CCCaptureRq ccCaptureRq)
        {
            CCCaptureRs ccCaptureRs = new CCCaptureRs();

            try
            {
                CreditCardPmtMng service = new CreditCardPmtMng();
                string userName = "user";
                //string userName = System.Configuration.ConfigurationManager.AppSettings["userName"].ToString();
                string password = "21bd12dc183f740ee76f27b78eb39c8ad972a757";
                //string password = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
                UsernameToken token = new UsernameToken(userName, password, PasswordOption.SendPlainText);
                service.RequestSoapContext.Security.MustUnderstand = false;
                service.RequestSoapContext.Security.Tokens.Add(token);

                
                ccCaptureRs.cccapturePmtInfo = service.capture(ccCaptureRq.RqUID, ccCaptureRq.ProfileCD, ccCaptureRq.AcquireTrnsRef, ccCaptureRq.MerchTrnsRef,ccCaptureRq.InvoiceNo);
                System.Console.WriteLine("Call Service: Credit Card Capture > Successfully");
                return ccCaptureRs;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Call Service: Credit Card Capture > Exception:" + ex.Message.ToString());
                return null;
            }
        }
        public CCValidDigReceiptRs validateReceipt(CCValidDigReceiptRq ccValidDigReceiptRq)
        {
            CCValidDigReceiptRs ccvalidDigReceiptRs = new CCValidDigReceiptRs();

            try
            {
                CreditCardPmtMng service = new CreditCardPmtMng();
                string userName = "user";
                //string userName = System.Configuration.ConfigurationManager.AppSettings["userName"].ToString();
                string password = "21bd12dc183f740ee76f27b78eb39c8ad972a757";
                //string password = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
                UsernameToken token = new UsernameToken(userName, password, PasswordOption.SendPlainText);
                service.RequestSoapContext.Security.MustUnderstand = false;
                service.RequestSoapContext.Security.Tokens.Add(token);


                ccvalidDigReceiptRs.ccvaliddigpmtinfo = service.validateReceipt(ccValidDigReceiptRq.RqUID, ccValidDigReceiptRq.ProfileCD, ccValidDigReceiptRq.BankRsQuery);
                System.Console.WriteLine("Call Service: Credit Card validate Receipt > Successfully");
                return ccvalidDigReceiptRs;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Call Service: Credit Card validate Receipt > Exception:" + ex.Message.ToString());
                return null;
            }
        }
        #endregion

        #region SADAD Payment Management
        public SADADBillLoadRs billLoad(SADADBillLoadRq sadadBillLoadRq)
        {
            SADADBillLoadRs sadadBillLoadRs = new SADADBillLoadRs();

            try
            {
                SADADPmtMng service = new SADADPmtMng();
                string userName = "user";
                //string userName = System.Configuration.ConfigurationManager.AppSettings["userName"].ToString();
                string password = "21bd12dc183f740ee76f27b78eb39c8ad972a757";
                //string password = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
                UsernameToken token = new UsernameToken(userName, password, PasswordOption.SendPlainText);
                service.RequestSoapContext.Security.MustUnderstand = false;
                service.RequestSoapContext.Security.Tokens.Add(token);

                bool DueAmountSpecified = false;
                if (sadadBillLoadRq.DueAmount == 0)
                    DueAmountSpecified = false;
                else
                    DueAmountSpecified = true;
                bool MaxAmountSpecified = false;
                if (sadadBillLoadRq.MaxAmount == 0)
                    MaxAmountSpecified = false;
                else
                    MaxAmountSpecified = true;
                bool MinAmountSpecified = false;
                if (sadadBillLoadRq.MinAmount == 0)
                    MinAmountSpecified = false;
                else
                    MinAmountSpecified = true;
                bool DueDtSpecified = false;
                if (sadadBillLoadRq.DueDt == null)
                    DueDtSpecified = false;
                else
                    DueDtSpecified = true;
                bool ExpDtSpecified = false;
                if (sadadBillLoadRq.ExpDt == null)
                    ExpDtSpecified = false;
                else
                    ExpDtSpecified = true;
                bool OpenDtSpecified = false;
                if (sadadBillLoadRq.OpenDt == null)
                    OpenDtSpecified = false;
                else
                    OpenDtSpecified = true;
                bool CloseDtSpecified = false;
                if (sadadBillLoadRq.CloseDt == null)
                    CloseDtSpecified = false;
                else
                    CloseDtSpecified = true;

                sadadBillLoadPmtInfo sadadbillLoadinfo = service.billLoad(sadadBillLoadRq.RqUID, sadadBillLoadRq.ProfileCD, sadadBillLoadRq.CustomerName, sadadBillLoadRq.MerchTrnsRef, sadadBillLoadRq.MerchOrderInfo, sadadBillLoadRq.MerchOrderAlias, sadadBillLoadRq.IsPartialPayment, sadadBillLoadRq.LangCD, sadadBillLoadRq.DueAmount, DueAmountSpecified, sadadBillLoadRq.MaxAmount, MaxAmountSpecified, sadadBillLoadRq.MinAmount, MinAmountSpecified, sadadBillLoadRq.InvoiceNo, sadadBillLoadRq.BillingAcct, sadadBillLoadRq.InvoiceRefInfo, sadadBillLoadRq.DueDt, DueDtSpecified, sadadBillLoadRq.ExpDt, ExpDtSpecified, sadadBillLoadRq.OpenDt, OpenDtSpecified, sadadBillLoadRq.CloseDt, CloseDtSpecified, sadadBillLoadRq.CustomerIDNo, sadadBillLoadRq.CustomerIDTypeCD, sadadBillLoadRq.InvoiceSttsCD, sadadBillLoadRq.BillCategory, sadadBillLoadRq.invoiceAdditionalInfoList, sadadBillLoadRq.billingInfo);
                System.Console.WriteLine("Call Service: SADAD Bill Load > Successfully");
                sadadBillLoadRs.sadadbillLoadinfo = sadadbillLoadinfo;
                return sadadBillLoadRs;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Call Service: SADAD Bill Load > Exception:" + ex.Message.ToString());
                return null;
            }
        }
        public SADADPmtUploadRs pmtUpload(SADADPmtUploadRq sadadPmtUploadRq)
        {
            SADADPmtUploadRs sadadPmtUploadRs = new SADADPmtUploadRs();

            try
            {
                SADADPmtMng service = new SADADPmtMng();
                string userName = "user";
                //string userName = System.Configuration.ConfigurationManager.AppSettings["userName"].ToString();
                string password = "21bd12dc183f740ee76f27b78eb39c8ad972a757";
                //string password = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
                UsernameToken token = new UsernameToken(userName, password, PasswordOption.SendPlainText);
                service.RequestSoapContext.Security.MustUnderstand = false;
                service.RequestSoapContext.Security.Tokens.Add(token);

                bool trnsAmountSpecified = false;
                if (sadadPmtUploadRq.TrnsAmount == 0)
                    trnsAmountSpecified = false;
                else
                    trnsAmountSpecified = true;
                bool prcDtAmountSpecified = false;
                if (sadadPmtUploadRq.PrcDt == null)
                    prcDtAmountSpecified = false;
                else
                    prcDtAmountSpecified = true;
                sadadPmtUploadPmtInfo sadadPmtLoadinfo = service.pmtUpload(sadadPmtUploadRq.RqUID, sadadPmtUploadRq.ProfileCD, sadadPmtUploadRq.InvoiceNo, sadadPmtUploadRq.MerchTrnsRef, sadadPmtUploadRq.AcquireTrnsRef, sadadPmtUploadRq.BillingAcct, sadadPmtUploadRq.TrnsAmount, trnsAmountSpecified, sadadPmtUploadRq.PrcDt, prcDtAmountSpecified, sadadPmtUploadRq.PmtRefInfo, sadadPmtUploadRq.CustomerIDNo, sadadPmtUploadRq.CustomerIDTypeCD, sadadPmtUploadRq.BankCD, sadadPmtUploadRq.BankBranchNo, sadadPmtUploadRq.PmtAccessChannel, sadadPmtUploadRq.District, sadadPmtUploadRq.PmtMthdCD);
                System.Console.WriteLine("Call Service: SADAD Payment Upload > Successfully");
                sadadPmtUploadRs.sadadPmtUploadInfo = sadadPmtLoadinfo;
                return sadadPmtUploadRs;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Call Service: SADAD Payment Upload > Exception:" + ex.Message.ToString());
                return null;
            }
        }
        public string PaymentNotification()
        {
            try
            {
                SADADPmtMng service = new SADADPmtMng();
                string userName = "user";
                //string userName = System.Configuration.ConfigurationManager.AppSettings["userName"].ToString();
                string password = "21bd12dc183f740ee76f27b78eb39c8ad972a757";
                //string password = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
                UsernameToken token = new UsernameToken(userName, password, PasswordOption.SendPlainText);
                service.RequestSoapContext.Security.MustUnderstand = false;
                service.RequestSoapContext.Security.Tokens.Add(token);
                
                //sadadBillLoadPmtInfo sadadbillLoadinfo = service.billLoad("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                System.Console.WriteLine("Call Service: SADAD Payment Notification > Successfully");
                //sadadPmtUploadRs.sadadPmtUploadInfo = sadadPmtLoadinfo;
                return "success";
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Call Service: SADAD Payment Notification > Exception:" + ex.Message.ToString());
                return null;
            }
        }
        #endregion

        #region PayPal Payment Management
        public PPDigOrderRs createPayment(PPDigOrderRq ppdigOrderRq)
        {
            PPDigOrderRs ppdigOrderRs = new PPDigOrderRs();

            try
            {
                PayPalPmtMng service = new PayPalPmtMng();
                string userName = "user";
                //string userName = System.Configuration.ConfigurationManager.AppSettings["userName"].ToString();
                string password = "21bd12dc183f740ee76f27b78eb39c8ad972a757";
                //string password = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
                UsernameToken token = new UsernameToken(userName, password, PasswordOption.SendPlainText);
                service.RequestSoapContext.Security.MustUnderstand = false;
                service.RequestSoapContext.Security.Tokens.Add(token);

                bool DueAmountSpecified = false;
                if (ppdigOrderRq.DueAmount == 0)
                    DueAmountSpecified = false;
                else
                    DueAmountSpecified = true;
                bool ShippingAmountSpecified = false;
                if (ppdigOrderRq.ShippingAmount == 0)
                    ShippingAmountSpecified = false;
                else
                    ShippingAmountSpecified = true;
                bool TaxAmountSpecified = false;
                if (ppdigOrderRq.Tax == 0)
                    TaxAmountSpecified = false;
                else
                    TaxAmountSpecified = true;
                ppDigOrderPmtInfo ppdigOrderinfo = service.createPayment(ppdigOrderRq.RqUID, ppdigOrderRq.ProfileCD, ppdigOrderRq.CustomerName, ppdigOrderRq.MerchTrnsRef, ppdigOrderRq.MerchOrderInfo, ppdigOrderRq.InvoiceNo, ppdigOrderRq.LangCD, ppdigOrderRq.DueAmount, DueAmountSpecified, ppdigOrderRq.ShippingAmount, ShippingAmountSpecified, ppdigOrderRq.Tax, TaxAmountSpecified, ppdigOrderRq.CurrencyCD, ppdigOrderRq.ApprovalURL, ppdigOrderRq.CancelURL, ppdigOrderRq.PPDigOrderItems, ppdigOrderRq.billingInfo);
                System.Console.WriteLine("Call Service: PayPal Create Payment > Successfully");
                ppdigOrderRs.ppdigOrderPmtInfo = ppdigOrderinfo;
                return ppdigOrderRs;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Call Service: PayPal Create Payment > Exception:" + ex.Message.ToString());
                return null;
            }
        }
        public PPCaptureRs executePayment(PPCaptureRq ppcaptureRq)
        {
            PPCaptureRs ppcaptureRs = new PPCaptureRs();

            try
            {
                PayPalPmtMng service = new PayPalPmtMng();
                string userName = "user";
                //string userName = System.Configuration.ConfigurationManager.AppSettings["userName"].ToString();
                string password = "21bd12dc183f740ee76f27b78eb39c8ad972a757";
                //string password = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
                UsernameToken token = new UsernameToken(userName, password, PasswordOption.SendPlainText);
                service.RequestSoapContext.Security.MustUnderstand = false;
                service.RequestSoapContext.Security.Tokens.Add(token);

                ppCapturePmtInfo ppcaptureInfo = service.executePayment(ppcaptureRq.RqUID, ppcaptureRq.ProfileCD, ppcaptureRq.MerchTrnsRef, ppcaptureRq.AcquireTrnsRef, ppcaptureRq.AcquireReceiptRef, ppcaptureRq.PayerID, ppcaptureRq.InvoiceNo);
                System.Console.WriteLine("Call Service: PayPal Execute Payment > Successfully");
                ppcaptureRs.ppcapturePmtInfo = ppcaptureInfo;
                return ppcaptureRs;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Call Service: PayPal Execute Payment > Exception:" + ex.Message.ToString());
                return null;
            }
        }
        #endregion
    }
}
