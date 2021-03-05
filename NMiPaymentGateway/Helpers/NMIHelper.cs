using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMiPaymentGateway.Helpers
{
    public static class NMIHelper
    {
        public static string GenerateURL<T>(T model)
        {
            return string.Join("&", model.GetType().GetProperties().
                Where(pi => pi.PropertyType == typeof(string))
                .Select(pi => new { Key = pi.Name, Value = (string)pi.GetValue(model) })
                .Where(keyValue => !string.IsNullOrWhiteSpace(keyValue.Value))
                .Select(keyValue => $"{keyValue.Key}={keyValue.Value}").ToArray());
        }

        public static string NMIServiceResponse(string value)
        {
            var urlResponse = HttpUtility.ParseQueryString(value);
            return JsonConvert.SerializeObject(urlResponse.AllKeys.ToDictionary(k => k, k => urlResponse[k]));
        }
    }
}