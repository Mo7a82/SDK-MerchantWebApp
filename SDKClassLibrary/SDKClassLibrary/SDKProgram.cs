using System;
using SDKClassLibrary.CreditCardPmtMngRef;
using SDKClassLibrary.SADADPmtMngRef;
using SDKClassLibrary.PayPalPmtMngRef;
using Microsoft.Web.Services2;
using Microsoft.Web.Services2.Security.Tokens;

namespace SDKClassLibrary
{
    /// <summary>
    /// Entry point of the merchant payment SDK. Each public method wraps one
    /// payment gateway web service operation.
    /// </summary>
    /// <remarks>
    /// Methods return null when a call fails. The reason is kept in LastError,
    /// so callers can show or log it.
    /// </remarks>
    public class SDKProgram
    {
        private readonly GatewaySettings settings;
        private readonly string endpointOverride;

        /// <summary>Reads credentials and endpoints from appSettings.</summary>
        public SDKProgram() : this(GatewaySettings.FromConfig(), null)
        {
        }

        /// <summary>Uses the given settings for every call.</summary>
        public SDKProgram(GatewaySettings settings) : this(settings, null)
        {
        }

        /// <summary>
        /// Uses the given settings, and sends every call to endpointOverride when it
        /// is not empty. The test harness uses this to point at a test or production URL.
        /// </summary>
        public SDKProgram(GatewaySettings settings, string endpointOverride)
        {
            if (settings == null) throw new ArgumentNullException("settings");
            this.settings = settings;
            this.endpointOverride = GatewaySettings.IsBlank(endpointOverride) ? null : endpointOverride.Trim();
        }

        /// <summary>The error from the last failed call, or null after a successful one.</summary>
        public Exception LastError { get; private set; }

        #region Credit Card Payment Management

        public CCDigOrderRs submitDigitalOrder(CCDigOrderRq rq)
        {
            return Call<CCDigOrderRs>("Credit Card Submit Digital Order", delegate
            {
                CreditCardPmtMng service = Prepare(new CreditCardPmtMng(), settings.CreditCardUrl);
                CCDigOrderRs rs = new CCDigOrderRs();
                rs.ccdigorderpmtinfo = service.submitDigitalOrder(rq.RqUID, rq.ProfileCD, rq.CustomerName,
                    rq.MerchTrnsRef, rq.MerchOrderInfo, rq.InvoiceNo, rq.LangCD,
                    rq.DueAmount, IsSet(rq.DueAmount), rq.ReturnURL, rq.billingInfo);
                return rs;
            });
        }

        public CCCaptureRs capture(CCCaptureRq rq)
        {
            return Call<CCCaptureRs>("Credit Card Capture", delegate
            {
                CreditCardPmtMng service = Prepare(new CreditCardPmtMng(), settings.CreditCardUrl);
                CCCaptureRs rs = new CCCaptureRs();
                rs.cccapturePmtInfo = service.capture(rq.RqUID, rq.ProfileCD, rq.AcquireTrnsRef,
                    rq.MerchTrnsRef, rq.InvoiceNo);
                return rs;
            });
        }

        public CCValidDigReceiptRs validateReceipt(CCValidDigReceiptRq rq)
        {
            return Call<CCValidDigReceiptRs>("Credit Card Validate Receipt", delegate
            {
                CreditCardPmtMng service = Prepare(new CreditCardPmtMng(), settings.CreditCardUrl);
                CCValidDigReceiptRs rs = new CCValidDigReceiptRs();
                rs.ccvaliddigpmtinfo = service.validateReceipt(rq.RqUID, rq.ProfileCD, rq.BankRsQuery);
                return rs;
            });
        }

        #endregion

        #region SADAD Payment Management

        /// <summary>Loads a bill into SADAD so the customer can pay it from any SADAD channel.</summary>
        public SADADBillLoadRs billLoad(SADADBillLoadRq rq)
        {
            return Call<SADADBillLoadRs>("SADAD Bill Load", delegate
            {
                SADADPmtMng service = Prepare(new SADADPmtMng(), settings.SadadUrl);
                SADADBillLoadRs rs = new SADADBillLoadRs();
                rs.sadadbillLoadinfo = service.billLoad(rq.RqUID, rq.ProfileCD, rq.CustomerName,
                    rq.MerchTrnsRef, rq.MerchOrderInfo, rq.MerchOrderAlias, rq.IsPartialPayment, rq.LangCD,
                    rq.DueAmount, IsSet(rq.DueAmount), rq.MaxAmount, IsSet(rq.MaxAmount),
                    rq.MinAmount, IsSet(rq.MinAmount), rq.InvoiceNo, rq.BillingAcct, rq.InvoiceRefInfo,
                    rq.DueDt, IsSet(rq.DueDt), rq.ExpDt, IsSet(rq.ExpDt),
                    rq.OpenDt, IsSet(rq.OpenDt), rq.CloseDt, IsSet(rq.CloseDt),
                    rq.CustomerIDNo, rq.CustomerIDTypeCD, rq.InvoiceSttsCD, rq.BillCategory,
                    rq.invoiceAdditionalInfoList, rq.billingInfo);
                return rs;
            });
        }

        /// <summary>
        /// Uploads a billing invoice. It takes the same fields as billLoad and is used
        /// by merchants whose invoices come from a billing system.
        /// </summary>
        public SADADBillLoadRs billingInvUpload(SADADBillLoadRq rq)
        {
            return Call<SADADBillLoadRs>("SADAD Billing Invoice Upload", delegate
            {
                SADADPmtMng service = Prepare(new SADADPmtMng(), settings.SadadUrl);
                SADADBillLoadRs rs = new SADADBillLoadRs();
                rs.sadadbillLoadinfo = service.billingInvUpload(rq.RqUID, rq.ProfileCD, rq.CustomerName,
                    rq.MerchTrnsRef, rq.MerchOrderInfo, rq.MerchOrderAlias, rq.IsPartialPayment, rq.LangCD,
                    rq.DueAmount, IsSet(rq.DueAmount), rq.MaxAmount, IsSet(rq.MaxAmount),
                    rq.MinAmount, IsSet(rq.MinAmount), rq.InvoiceNo, rq.BillingAcct, rq.InvoiceRefInfo,
                    rq.DueDt, IsSet(rq.DueDt), rq.ExpDt, IsSet(rq.ExpDt),
                    rq.OpenDt, IsSet(rq.OpenDt), rq.CloseDt, IsSet(rq.CloseDt),
                    rq.CustomerIDNo, rq.CustomerIDTypeCD, rq.InvoiceSttsCD, rq.BillCategory,
                    rq.invoiceAdditionalInfoList, rq.billingInfo);
                return rs;
            });
        }

        /// <summary>Uploads a payment record against a SADAD bill.</summary>
        public SADADPmtUploadRs pmtUpload(SADADPmtUploadRq rq)
        {
            return Call<SADADPmtUploadRs>("SADAD Payment Upload", delegate
            {
                SADADPmtMng service = Prepare(new SADADPmtMng(), settings.SadadUrl);
                SADADPmtUploadRs rs = new SADADPmtUploadRs();
                rs.sadadPmtUploadInfo = service.pmtUpload(rq.RqUID, rq.ProfileCD, rq.InvoiceNo,
                    rq.MerchTrnsRef, rq.AcquireTrnsRef, rq.BillingAcct,
                    rq.TrnsAmount, IsSet(rq.TrnsAmount), rq.PrcDt, IsSet(rq.PrcDt),
                    rq.PmtRefInfo, rq.CustomerIDNo, rq.CustomerIDTypeCD, rq.BankCD, rq.BankBranchNo,
                    rq.PmtAccessChannel, rq.District, rq.PmtMthdCD);
                return rs;
            });
        }

        #endregion

        #region PayPal Payment Management

        public PPDigOrderRs createPayment(PPDigOrderRq rq)
        {
            return Call<PPDigOrderRs>("PayPal Create Payment", delegate
            {
                PayPalPmtMng service = Prepare(new PayPalPmtMng(), settings.PayPalUrl);
                PPDigOrderRs rs = new PPDigOrderRs();
                rs.ppdigOrderPmtInfo = service.createPayment(rq.RqUID, rq.ProfileCD, rq.CustomerName,
                    rq.MerchTrnsRef, rq.MerchOrderInfo, rq.InvoiceNo, rq.LangCD,
                    rq.DueAmount, IsSet(rq.DueAmount), rq.ShippingAmount, IsSet(rq.ShippingAmount),
                    rq.Tax, IsSet(rq.Tax), rq.CurrencyCD, rq.ApprovalURL, rq.CancelURL,
                    rq.PPDigOrderItems, rq.billingInfo);
                return rs;
            });
        }

        public PPCaptureRs executePayment(PPCaptureRq rq)
        {
            return Call<PPCaptureRs>("PayPal Execute Payment", delegate
            {
                PayPalPmtMng service = Prepare(new PayPalPmtMng(), settings.PayPalUrl);
                PPCaptureRs rs = new PPCaptureRs();
                rs.ppcapturePmtInfo = service.executePayment(rq.RqUID, rq.ProfileCD, rq.MerchTrnsRef,
                    rq.AcquireTrnsRef, rq.AcquireReceiptRef, rq.PayerID, rq.InvoiceNo);
                return rs;
            });
        }

        #endregion

        #region Helpers

        private delegate T ServiceCall<T>();

        private T Call<T>(string operation, ServiceCall<T> call) where T : class
        {
            LastError = null;
            try
            {
                settings.Validate();
                T result = call();
                Console.WriteLine("Call Service: " + operation + " > Successfully");
                return result;
            }
            catch (Exception ex)
            {
                LastError = ex;
                Console.WriteLine("Call Service: " + operation + " > Exception: " + ex.Message);
                return null;
            }
        }

        /// <summary>Sets the endpoint and adds the WS-Security username token.</summary>
        private T Prepare<T>(T service, string configuredUrl) where T : WebServicesClientProtocol
        {
            if (endpointOverride != null)
            {
                service.Url = endpointOverride;
            }
            else if (!GatewaySettings.IsBlank(configuredUrl))
            {
                service.Url = configuredUrl;
            }
            // Otherwise keep the default URL from Properties/Settings.settings.

            UsernameToken token = new UsernameToken(settings.UserName, settings.Password, settings.PasswordOption);
            service.RequestSoapContext.Security.MustUnderstand = false;
            service.RequestSoapContext.Security.Tokens.Add(token);
            return service;
        }

        // Optional numeric fields are sent only when they have a value.
        private static bool IsSet(decimal value)
        {
            return value != 0;
        }

        // DateTime is a value type, so an unset field holds DateTime.MinValue, not null.
        private static bool IsSet(DateTime value)
        {
            return value != DateTime.MinValue;
        }

        #endregion
    }
}
