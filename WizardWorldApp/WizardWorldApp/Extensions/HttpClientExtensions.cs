using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;

namespace WizardWorldApp.Extensions {
    public static class HttpClientExtensions {
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, string url,
            IDictionary<string, string> queryParams) {
            var queryString = QueryHelpers.AddQueryString(url, queryParams);
            return client.GetAsync(queryString);
        }
    }
}