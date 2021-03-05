namespace NMiPaymentGateway.Models
{
    public class CustomerVaultServiceModel : SecurityKeyServiceModel
    {
        public string customer_vault { get; set; }
        public string customer_vault_id { get; set; }
        public string billing_id { get; set; }
        //public string security_key { get; set; }
        public string payment_token { get; set; }
        public string googlepay_payment_data { get; set; }
        public string ccnumber { get; set; }
        public string ccexp { get; set; }
        public string checkname { get; set; }
        public string checkaba { get; set; }
        public string checkaccount { get; set; }
        public string account_holder_type { get; set; }
        public string account_type { get; set; }
        public string sec_code { get; set; }
        public string currency { get; set; }
        public string payment { get; set; }
        public string orderid { get; set; }
        public string order_description { get; set; }
        public string merchant_defined_field_ { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string company { get; set; }
        public string address2 { get; set; }
        public string fax { get; set; }
        public string shipping_id { get; set; }
        public string shipping_firstname { get; set; }
        public string shipping_lastname { get; set; }
        public string shipping_company { get; set; }
        public string shipping_address1 { get; set; }
        public string shipping_address2 { get; set; }
        public string shipping_city { get; set; }
        public string shipping_state { get; set; }
        public string shipping_zip { get; set; }
        public string shipping_country { get; set; }
        public string shipping_phone { get; set; }
        public string shipping_fax { get; set; }
        public string shipping_email { get; set; }
        public string source_transaction_id { get; set; }
    }
}