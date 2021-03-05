using NMiPaymentGateway.Helpers;
using static NMiPaymentGateway.Models.Enums;

namespace NMiPaymentGateway.Models
{
    public class UpdateTransactionSerivceModel : SecurityKeyServiceModel
    {
        public string type { get; private set; } = TransactionType.Update.ToDescription();
        public string transactionid { get; set; }
        public string payment { get; set; }
        public string tracking_number { get; set; }
        public string shipping { get; set; }
        public string shipping_postal { get; set; }
        public string ship_from_postal { get; set; }
        public string shipping_country { get; set; }
        public string shipping_carrier { get; set; }
        public string shipping_date { get; set; }
        public string order_description { get; set; }
        public string order_date { get; set; }
        public string customer_receipt { get; set; }
        public string signature_image { get; set; }
        public string ponumber { get; set; }
        public string summary_commodity_code { get; set; }
        public string duty_amount { get; set; }
        public string discount_amount { get; set; }
        public string tax { get; set; }
        public string national_tax_amount { get; set; }
        public string alternate_tax_amount { get; set; }
        public string alternate_tax_id { get; set; }
        public string vat_tax_amount { get; set; }
        public string vat_tax_rate { get; set; }
        public string vat_invoice_reference_number { get; set; }
        public string customer_vat_registration { get; set; }
        public string merchant_vat_registration { get; set; }
        public string merchant_defined_field_ { get; set; }
    }
}