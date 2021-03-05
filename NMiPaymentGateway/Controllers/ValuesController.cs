using Newtonsoft.Json;
using NMiPaymentGateway.Models;
using NMiPaymentGateway.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;

namespace NMiPaymentGateway.Controllers
{
    public class TransactionModel
    {
        public string security_key { get; set; } = WebConfigurationManager.AppSettings["security_key"];


        #region Transaction
        //public string type { get; set; } = "sale";

        //#region Single Transaction
        //public string orderid { get; set; } = DateTime.UtcNow.Ticks.ToString();
        //public string payment { get; set; } = "creditcard";
        //public string ccnumber { get; set; } = "6011111111111117";
        //public string ccexp { get; set; } = "1025";
        //public string cvv { get; set; } = "601";
        //public string first_name { get; set; } = "Har";
        //public string last_name { get; set; } = "Patel";
        //public string amount { get; set; } = "11.12";
        //#endregion



        //#region Recurring
        //public string recurring { get; set; } = "add_subscription";
        //public string plan_id { get; set; } = "2Treatments";
        //////public string plan_payments { get; set; } = "2";
        //////public string plan_amount { get; set; } = "29.50";
        //////public string day_frequency { get; set; } = "5";
        //////public string month_frequency { get; set; } = "";
        //////public string day_of_month { get; set; } = "";
        //public string start_date { get; set; } = "20210306";
        //#endregion

        #endregion


        #region Refund
        public string type { get; set; } = "refund";
        public string transactionid { get; private set; } = "6062374587";
        public string amount { get; private set; } = "29.75";
        public string payment { get; private set; } = "creditcard";
        #endregion

        //#region Invoice
        //public string invoicing { get; set; } = "add_invoice";
        //public string amount { get; set; } = "39.99";
        //public string email { get; set; } = "harsh.p1147@yopmail.com";
        //public string currency { get; set; }
        //public string order_description { get; set; } = "My Subscription Added";
        //public string orderid { get; set; } = "637505183388696529";
        //public string customer_id { get; set; } = "";
        //public string first_name { get; set; } = "Gary";
        //public string last_name { get; set; } = "Trevino";
        //public string company { get; set; } = "PLUT";
        //public string address1 { get; set; } = "153  Peaceful Lane";
        //public string address2 { get; set; } = "Near XYZ";
        //public string city { get; set; } = "Garfield Heights";
        //public string state { get; set; } = "OH";
        //public string zip { get; set; } = "44125";
        //public string country { get; set; } = "US";
        //public string phone { get; set; } = "123 123 1234";
        //public string shipping_firstname { get; set; } = "Sara";
        //public string shipping_lastname { get; set; } = "Mebane";
        //public string shipping_company { get; set; } = "CRES";
        //public string shipping_address1 { get; set; } = "";
        //public string shipping_address2 { get; set; } = "1999  Rainy Day Drive";
        //public string shipping_city { get; set; } = "Near ABC";
        //public string shipping_state { get; set; } = "MA";
        //public string shipping_zip { get; set; } = "02110";
        //public string shipping_country { get; set; } = "US";
        //public string shipping_email { get; set; } = "harsh.p1147v1@yopmail.com";
        //#endregion
    }

    public class IdNameModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    //return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public string GenerateURL(TransactionModel model)
        {
            return string.Join("&", model.GetType().GetProperties().
                Where(pi => pi.PropertyType == typeof(string))
                .Select(pi => new IdNameModel { Key = pi.Name, Value = (string)pi.GetValue(model) })
                .Where(keyValue => !string.IsNullOrWhiteSpace(keyValue.Value))
                .Select(keyValue => $"{keyValue.Key}={keyValue.Value}").ToArray());
        }

        public IEnumerable<string> Get()
        {

            var nmiService = new NMIService();

            var responseMessage = string.Empty;
            Action<string> success = response =>
            {
                responseMessage = $"Sucess Response : { response }";
            };

            Action<string> failure = response =>
            {
                responseMessage = $"Failure Response : { response }";
            };

            var customer = new CustomerVaultServiceModel()
            {
                customer_vault_id = "123123123",
                ccnumber = "6011111111111117",
                ccexp = "1025",
                //cvv = "601",
                first_name = "Harsh",
                last_name = "Three",
                address1 = "153  Peaceful Lane",
                address2 = "Near XYZ",
                city = "Garfield Heights",
                state = "OH",
                zip = "44125",
                country = "US",
            };

            nmiService.CreateCustomerVault(customer, success, failure);
            return new string[] { responseMessage };
        }       




        //publicphone { get; set; } = "123 123 1234"; IEnumerable<string> Get()
        //{
        //    string nmiPostUrl = WebConfigurationManager.AppSettings["nmiPostUrl"];
        //    string security_key = WebConfigurationManager.AppSettings["security_key"];

        //    //setup some variables end

        //    String result = "";

        //    #region Transaction

        //    var transactionDetails = new TransactionModel();

        //    string strPost = GenerateURL(transactionDetails);

        //    #endregion

        //    StreamWriter myWriter = null;

        //    HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(nmiPostUrl);
        //    objRequest.Method = "POST";
        //    objRequest.ContentLength = strPost.Length;
        //    objRequest.ContentType = "application/x-www-form-urlencoded";

        //    try
        //    {
        //        myWriter = new StreamWriter(objRequest.GetRequestStream());
        //        myWriter.Write(strPost);

        //    }
        //    catch (Exception e)
        //    {
        //        //return e.Message.ToString();
        //    }
        //    finally
        //    {
        //        myWriter.Close();
        //    }

        //    HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
        //    using (StreamReader sr =
        //       new StreamReader(objResponse.GetResponseStream()))
        //    {
        //        result = sr.ReadToEnd();

        //        // Close and clean up the StreamReader
        //        sr.Close();
        //    }

        //    var urlResponse =  HttpUtility.ParseQueryString(result);
        //    var response = JsonConvert.SerializeObject(urlResponse.AllKeys.ToDictionary(k => k, k => urlResponse[k]));
        //    return new string[] { response };
        //}
    }
}
