namespace VottunERC20API.NET
{
    public static class HttpClientExtensions
    {
        public static HttpClient AddVottunHeaders(this HttpClient client,  string apiKey, string authorizationKey )
        {
            client.DefaultRequestHeaders.Add("x-application-vkn", apiKey);
            client.DefaultRequestHeaders.Add("Authorization",$"Bearer {authorizationKey}");
            return client;
        }
    }
}
