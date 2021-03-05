using System.ComponentModel;

namespace NMiPaymentGateway.Models
{
    public class Enums
    {
        public enum CustomerVaultType
        {
            [Description("add_customer")]
            AddCustomer,
            [Description("update_customer")]
            UpdateCustomer,
            [Description("delete_customer")]
            DeleteCustomer
        }

        public enum PaymentType
        {
            [Description("creditcard")]
            CreditCard,
            [Description("check")]
            Check,
        }

        public enum TransactionType
        {
            [Description("sale")]
            Sale,
            [Description("auth")]
            Authorization,
            [Description("capture")]
            Capture,
            [Description("void")]
            Void,
            [Description("refund")]
            Refund,
            [Description("credit")]
            Credit,
            [Description("validate")]
            Validate,
            [Description("update")]
            Update
        }

        public enum PlanOperationType
        {
            [Description("add_plan")]
            AddPlan,
            [Description("edit_plan")]
            EditPlan
        }

        public enum SubscriptionOperationType
        {
            [Description("add_subscription")]
            AddSubscription,
            [Description("update_subscription")]
            UpdateSubscription,
            [Description("delete_subscription")]
            DeleteSbscription
        }



    }
}