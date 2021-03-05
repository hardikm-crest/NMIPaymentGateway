using NMiPaymentGateway.Helpers;
using static NMiPaymentGateway.Models.Enums;

namespace NMiPaymentGateway.Models
{
    public class DeleteCustomerVaultServiceModel : SecurityKeyServiceModel
    {
        public string customer_vault { get; private set; } = CustomerVaultType.DeleteCustomer.ToDescription();
        public string customer_vault_id { get; set; }
    }
}