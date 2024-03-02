namespace VottumERC20API.NET
{
    public static class HttpClientExtensions
    {
        public static HttpClient AddVottumHeaders(this HttpClient client,  string apiKey, string authorizationKey )
        {
            client.DefaultRequestHeaders.Add("x-application-vkn", apiKey);
            client.DefaultRequestHeaders.Add("Authorization",$"Bearer {authorizationKey}");
            return client;
        }
    }
}
