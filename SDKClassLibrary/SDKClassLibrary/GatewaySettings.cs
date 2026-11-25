using System;
using System.Configuration;
using Microsoft.Web.Services2.Security.Tokens;

namespace SDKClassLibrary
{
    /// <summary>
    /// Connection settings for the payment gateway web services.
    /// Values are read from the appSettings section of the host application's
    /// Web.config or App.config. See MerchantWebApplication/PaymentGateway.secrets.config.example for the keys.
    /// </summary>
    public class GatewaySettings
    {
        public const string UserNameKey = "PaymentGateway.UserName";
        public const string PasswordKey = "PaymentGateway.Password";
        public const string PasswordOptionKey = "PaymentGateway.PasswordOption";
        public const string CreditCardUrlKey = "PaymentGateway.CreditCardUrl";
        public const string SadadUrlKey = "PaymentGateway.SadadUrl";
        public const string PayPalUrlKey = "PaymentGateway.PayPalUrl";

        public string UserName { get; set; }
        public string Password { get; set; }
        public PasswordOption PasswordOption { get; set; }
        public string CreditCardUrl { get; set; }
        public string SadadUrl { get; set; }
        public string PayPalUrl { get; set; }

        public GatewaySettings()
        {
            PasswordOption = PasswordOption.SendPlainText;
        }

        /// <summary>
        /// Builds the settings from appSettings. Missing endpoint keys fall back to
        /// the URLs stored in Properties/Settings.settings.
        /// </summary>
        public static GatewaySettings FromConfig()
        {
            GatewaySettings settings = new GatewaySettings();
            settings.UserName = Read(UserNameKey);
            settings.Password = Read(PasswordKey);
            settings.CreditCardUrl = Read(CreditCardUrlKey);
            settings.SadadUrl = Read(SadadUrlKey);
            settings.PayPalUrl = Read(PayPalUrlKey);

            string option = Read(PasswordOptionKey);
            if (!IsBlank(option))
            {
                settings.PasswordOption = (PasswordOption)Enum.Parse(typeof(PasswordOption), option, true);
            }
            return settings;
        }

        /// <summary>
        /// Throws a clear error when the credentials have not been configured,
        /// instead of letting the service reject an empty token.
        /// </summary>
        public void Validate()
        {
            if (IsBlank(UserName) || IsBlank(Password))
            {
                throw new ConfigurationErrorsException(
                    "Payment gateway credentials are missing. Set " + UserNameKey + " and " + PasswordKey +
                    " in appSettings (see MerchantWebApplication/PaymentGateway.secrets.config.example).");
            }
        }

        internal static bool IsBlank(string value)
        {
            return value == null || value.Trim().Length == 0;
        }

        private static string Read(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            return IsBlank(value) ? null : value.Trim();
        }
    }
}
