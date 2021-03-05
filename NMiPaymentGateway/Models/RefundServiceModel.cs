using NMiPaymentGateway.Helpers;
using static NMiPaymentGateway.Models.Enums;

namespace NMiPaymentGateway.Models
{
    public class RefundServiceModel
    {
        public string type { get; set; } = TransactionType.Refund.ToDescription();
        public string transactionid { get; set; }
        public string amount { get; set; }
        public string payment { get; set; }
    }
}