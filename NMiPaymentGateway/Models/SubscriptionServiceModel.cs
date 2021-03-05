namespace NMiPaymentGateway.Models
{
    public class SubscriptionServiceModel : SecurityKeyServiceModel
    {
        public string recurring { get; set; };
        public string plan_id { get; set; }
        public string start_date { get; set; }
        public string payment_token { get; set; }
        public string googlepay_payment_data { get; set; }
        public string ccnumber { get; set; }
        public string ccexp { get; set; }
        public string payment { get; set; }
        public string checkname { get; set; }
        public string checkaccount { get; set; }
        public string checkaba { get; set; }
        public string account_type { get; set; }
        public string currency { get; set; }
        public string account_holder_type { get; set; }
        public string sec_code { get; set; }
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
        public string orderid { get; set; }
        public string order_description { get; set; }
        public string merchant_defined_field { get; set; }
        public string ponumber { get; set; }
        public string processor_id { get; set; }
        public string customer_receipt { get; set; }
        public string source_transaction_id { get; set; }

        #region For Delete
        public string subscription_id { get; set; }
        #endregion
    }
}