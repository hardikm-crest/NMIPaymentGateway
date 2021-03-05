using Newtonsoft.Json;
using NMiPaymentGateway.Helpers;
using NMiPaymentGateway.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using static NMiPaymentGateway.Models.Enums;

namespace NMiPaymentGateway.Services
{
    public class NMIService
    {
        #region Public Methods


        #region Customer Vault

        public void CreateCustomerVault(CustomerVaultServiceModel customer, Action<string> success, Action<string> failure)
        {
            customer.customer_vault = CustomerVaultType.AddCustomer.ToDescription();
            ExecuteAction(customer, success, failure);
        }

        public void UpdateCustomerVault(CustomerVaultServiceModel customer, Action<string> success, Action<string> failure)
        {
            customer.customer_vault = CustomerVaultType.UpdateCustomer.ToDescription();
            ExecuteAction(customer, success, failure);
        }

        public void DeleteCustomerVault(DeleteCustomerVaultServiceModel customer, Action<string> success, Action<string> failure)
        {
            ExecuteAction(customer, success, failure);
        }

        #endregion

        #region Transaction

        public void MakePayment(TransactionServiceModel data, Action<string> success, Action<string> failure)
        {
            data.type = TransactionType.Sale.ToDescription();
            ExecuteAction(data, success, failure);
        }

        public void UpdatePayment(UpdateTransactionSerivceModel data, Action<string> success, Action<string> failure)
        {
            ExecuteAction(data, success, failure);
        }

        public void RefundPayment(RefundServiceModel data, Action<string> success, Action<string> failure)
        {
            ExecuteAction(data, success, failure);
        }

        #endregion

        #region Plan

        public void AddPlan(PlanServiceModel data, Action<string> success, Action<string> failure)
        {
            data.recurring = PlanOperationType.AddPlan.ToDescription();
            ExecuteAction(data, success, failure);
        }

        public void UpdatePlan(PlanServiceModel data, Action<string> success, Action<string> failure)
        {
            data.recurring = PlanOperationType.EditPlan.ToDescription();
            ExecuteAction(data, success, failure);
        }

        #endregion

        #region Subscription

        public void AddSubscription(SubscriptionServiceModel data, Action<string> success, Action<string> failure)
        {
            data.recurring = SubscriptionOperationType.AddSubscription.ToDescription();
            ExecuteAction(data, success, failure);
        }

        public void UpdateSubscription(SubscriptionServiceModel data, Action<string> success, Action<string> failure)
        {
            data.recurring = SubscriptionOperationType.UpdateSubscription.ToDescription();
            ExecuteAction(data, success, failure);
        }

        public void DeleteSubscription(SubscriptionServiceModel data, Action<string> success, Action<string> failure)
        {
            data.recurring = SubscriptionOperationType.DeleteSbscription.ToDescription();
            ExecuteAction(data, success, failure);
        }

        #endregion

        #endregion

        #region Private Methods

        private (bool isSuccess, string response) PostRequest(string url)
        {
            StreamWriter myWriter = null;
            string nmiPostUrl = WebConfigurationManager.AppSettings["nmiPostUrl"];
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(nmiPostUrl);
            objRequest.Method = "POST";
            objRequest.ContentLength = url.Length;
            objRequest.ContentType = "application/x-www-form-urlencoded";

            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(url);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                myWriter.Close();
            }

            var result = string.Empty;

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr =
               new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();

                // Close and clean up the StreamReader
                sr.Close();
            }
            var jsonResponse = NMIHelper.NMIServiceResponse(result);

            var responseModel = JsonConvert.DeserializeObject<ResponseServiceModel>(jsonResponse);

            return (responseModel.response_code == "100", jsonResponse);
        }

        private void ExecuteAction<T>(T requestModel, Action<string> success, Action<string> failure)
        {
            var result = PostRequest(NMIHelper.GenerateURL(requestModel));

            if (result.isSuccess)
            {
                success.Invoke(result.response);
            }
            else
            {
                failure.Invoke(result.response);
            }
        }

        #endregion
    }
}