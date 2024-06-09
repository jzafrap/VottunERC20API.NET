using System.Net.Http.Headers;

namespace VottunERC20API.NET
{
    
    public static class VottunApiClientFactory
    {
        

        public static IVottunERCApiClient Create(string apiKey, string authorizationKey)
        {
            var httpClient = new HttpClient { BaseAddress = new Uri(ApiUrlConstants.API_HOST) };
            httpClient.AddVottunHeaders( apiKey, authorizationKey);
            return new VottunERCApiClient(httpClient);
        }

        internal static void ConfigureHttpClient(HttpClient httpClient, string apiKey, string authorizationKey)
        {
            ConfigureHttpClientCore(httpClient);
            httpClient.AddVottunHeaders(apiKey, authorizationKey);
        }

        internal static void ConfigureHttpClientCore(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
