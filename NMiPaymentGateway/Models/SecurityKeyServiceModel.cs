using System.Web.Configuration;

namespace NMiPaymentGateway.Models
{
    public class SecurityKeyServiceModel
    {
        public string security_key { get; private set; } = WebConfigurationManager.AppSettings["security_key"];
    }
}