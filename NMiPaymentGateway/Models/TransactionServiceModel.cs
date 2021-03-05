namespace NMiPaymentGateway.Models
{
    public class TransactionServiceModel : SecurityKeyServiceModel
    {
        public string type { get; set; }
        public string payment_token { get; set; }
        public string googlepay_payment_data { get; set; }
        public string ccnumber { get; set; }
        public string ccexp { get; set; }
        public string cvv { get; set; }
        public string checkname { get; set; }
        public string checkaba { get; set; }
        public string checkaccount { get; set; }
        public string account_holder_type { get; set; }
        public string account_type { get; set; }
        public string sec_code { get; set; }
        public string amount { get; set; }
        public string surcharge { get; set; }
        public string cash_discount { get; set; }
        public string currency { get; set; }
        public string payment { get; set; }
        public string processor_id { get; set; }
        public string authorization_code { get; set; }
        public string dup_seconds { get; set; }
        public string descriptor { get; set; }
        public string descriptor_phone { get; set; }
        public string descriptor_address { get; set; }
        public string descriptor_city { get; set; }
        public string descriptor_state { get; set; }
        public string descriptor_postal { get; set; }
        public string descriptor_country { get; set; }
        public string descriptor_mcc { get; set; }
        public string descriptor_merchant_id { get; set; }
        public string descriptor_url { get; set; }
        public string billing_method { get; set; }
        public string billing_number { get; set; }
        public string billing_total { get; set; }
        public string order_template { get; set; }
        public string order_description { get; set; }
        public string orderid { get; set; }
        public string ipaddress { get; set; }
        public string tax { get; set; }
        public string shipping { get; set; }
        public string ponumber { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string company { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string social_security_number { get; set; }
        public string drivers_license_number { get; set; }
        public string drivers_license_dob { get; set; }
        public string drivers_license_state { get; set; }
        public string shipping_firstname { get; set; }
        public string shipping_lastname { get; set; }
        public string shipping_company { get; set; }
        public string shipping_address1 { get; set; }
        public string shipping_address2 { get; set; }
        public string shipping_city { get; set; }
        public string shipping_state { get; set; }
        public string shipping_zip { get; set; }
        public string shipping_country { get; set; }
        public string shipping_email { get; set; }
        public string merchant_defined_field_ { get; set; }
        public string customer_receipt { get; set; }
        public string signature_image { get; set; }
        public string cardholder_auth { get; set; }
        public string cavv { get; set; }
        public string xid { get; set; }
        public string three_ds_version { get; set; }
        public string directory_server_id { get; set; }
        public string source_transaction_id { get; set; }


        #region Recurring Plan
        public string recurring { get; set; }
        public string plan_id { get; set; }
        public string plan_payments { get; set; }
        public string plan_amount { get; set; }
        public string day_frequency { get; set; }
        public string month_frequency { get; set; }
        public string day_of_month { get; set; }
        public string start_date { get; set; }
        #endregion
    }
}