using System.Net.Http.Headers;

namespace VottumERC20API.NET
{
    
    public static class VottunApiClientFactory
    {
        

        public static IVottumERCApiClient Create(string apiKey, string authorizationKey)
        {
            var httpClient = new HttpClient { BaseAddress = new Uri(ApiUrlConstants.API_HOST) };
            httpClient.AddVottumHeaders( apiKey, authorizationKey);
            return new VottunERCApiClient(httpClient);
        }

        internal static void ConfigureHttpClient(HttpClient httpClient, string apiKey, string authorizationKey)
        {
            ConfigureHttpClientCore(httpClient);
            httpClient.AddVottumHeaders(apiKey, authorizationKey);
        }

        internal static void ConfigureHttpClientCore(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
