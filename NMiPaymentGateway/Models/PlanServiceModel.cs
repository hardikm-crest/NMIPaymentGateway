namespace NMiPaymentGateway.Models
{
    public class PlanServiceModel : SecurityKeyServiceModel
    {
        public string recurring { get; set; }
        public string plan_payments { get; set; }
        public string plan_amount { get; set; }
        public string plan_name { get; set; }
        public string plan_id { get; set; }
        public string day_frequency { get; set; }
        public string month_frequency { get; set; }
        public string day_of_month { get; set; }
        public string current_plan_id { get; set; }

    }
}