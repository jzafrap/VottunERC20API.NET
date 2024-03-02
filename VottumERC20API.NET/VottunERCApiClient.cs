using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VottumERC20API.NET
{
    public class VottunERCApiClient:IVottumERCApiClient
    {
        private readonly HttpClient _httpClient;
        public VottunERCApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        #region Deploy
        public async Task<DeployResponse> DeployAsync(DeployRequest request, CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();
            var response = await _httpClient.PostAsJsonAsync(ApiUrlConstants.Deploy, request, options,cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<DeployResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion

        #region transfer
        public async Task<TransferResponse> TransferAsync(TransferRequest request, CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();
            var response = await _httpClient.PostAsJsonAsync(ApiUrlConstants.Transfer, request, options,cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TransferResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion

        #region TransferFrom
        public async Task<TransferFromResponse> TransferFromAsync(TransferFromRequest request, CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();
            var response = await _httpClient.PostAsJsonAsync(ApiUrlConstants.TransferFrom, request, options,cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TransferFromResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion


        #region IncreaseAllowance
        public async Task<IncreaseAllowanceResponse> IncreaseAllowanceAsync(IncreaseAllowanceRequest request, CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();
            var response = await _httpClient.PostAsJsonAsync(ApiUrlConstants.IncreaseAllowance, request, options,cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IncreaseAllowanceResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion

        #region DecreaseAllowance
        public async Task<DecreaseAllowanceResponse> DecreaseAllowanceAsync(DecreaseAllowanceRequest request, CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();
            var response = await _httpClient.PostAsJsonAsync(ApiUrlConstants.DecreaseAllowance, request, options, cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<DecreaseAllowanceResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion

        #region Allowance
        public async Task<AllowanceResponse> AllowanceAsync(AllowanceRequest request, CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();

            var json = JsonSerializer.Serialize<AllowanceRequest>(request,options);
            var req = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_httpClient.BaseAddress, ApiUrlConstants.Allowance),
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
            var response = await _httpClient.SendAsync(req,cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<AllowanceResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion

        #region Name
        public async Task<NameResponse> NameAsync(NameRequest request, CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();

            var json = JsonSerializer.Serialize<NameRequest>(request, options);
            var req = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_httpClient.BaseAddress, ApiUrlConstants.Name),
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
            var response = await _httpClient.SendAsync(req).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<NameResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion

        #region Symbol
        public async Task<SymbolResponse> SymbolAsync(SymbolRequest request, CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();
            var json = JsonSerializer.Serialize<SymbolRequest>(request, options);
            var req = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_httpClient.BaseAddress, ApiUrlConstants.Symbol),
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
            var response = await _httpClient.SendAsync(req).ConfigureAwait(false); response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<SymbolResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion

        #region TotalSupply
        public async Task<TotalSupplyResponse> TotalSupplyAsync(TotalSupplyRequest request, CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();

            var json = JsonSerializer.Serialize<TotalSupplyRequest>(request, options);
            var req = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_httpClient.BaseAddress, ApiUrlConstants.TotalSupply),
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
            var response = await _httpClient.SendAsync(req).ConfigureAwait(false); response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TotalSupplyResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion

        #region Decimals
        public async Task<DecimalsResponse> DecimalsAsync(DecimalsRequest request, CancellationToken cancellationToken)
        {

            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();
            var json = JsonSerializer.Serialize<DecimalsRequest>(request, options);
            var req = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_httpClient.BaseAddress, ApiUrlConstants.Decimals),
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
            var response = await _httpClient.SendAsync(req).ConfigureAwait(false); response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<DecimalsResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion

        #region BalanceOf
        public async Task<BalanceOfResponse> BalanceOfAsync(BalanceOfRequest request, CancellationToken cancellationToken)
        {

            var options = new JsonSerializerOptions();
            options.TypeInfoResolver = new AppJsonSerializerContext();
            var json = JsonSerializer.Serialize<BalanceOfRequest>(request, options);
            var req = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_httpClient.BaseAddress, ApiUrlConstants.BalanceOf),
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
            var response = await _httpClient.SendAsync(req).ConfigureAwait(false); response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<BalanceOfResponse>(options,cancellationToken: cancellationToken);
        }
        #endregion
    }

    [JsonSerializable(typeof(DeployRequest))]
    [JsonSerializable(typeof(DeployResponse))]
    [JsonSerializable(typeof(TransferRequest))]
    [JsonSerializable(typeof(TransferResponse))]
    [JsonSerializable(typeof(TransferFromRequest))]
    [JsonSerializable(typeof(TransferFromResponse))]
    [JsonSerializable(typeof(IncreaseAllowanceRequest))]
    [JsonSerializable(typeof(IncreaseAllowanceResponse))]
    [JsonSerializable(typeof(DecreaseAllowanceRequest))]
    [JsonSerializable(typeof(DecreaseAllowanceResponse))]
    [JsonSerializable(typeof(AllowanceRequest))]
    [JsonSerializable(typeof(AllowanceResponse))]
    [JsonSerializable(typeof(NameRequest))]
    [JsonSerializable(typeof(NameResponse))]
    [JsonSerializable(typeof(SymbolRequest))]
    [JsonSerializable(typeof(SymbolResponse))]
    [JsonSerializable(typeof(TotalSupplyRequest))]
    [JsonSerializable(typeof(TotalSupplyResponse))]
    [JsonSerializable(typeof(DecimalsRequest))]
    [JsonSerializable(typeof(DecimalsResponse))]
    [JsonSerializable(typeof(BalanceOfRequest))]
    [JsonSerializable(typeof(BalanceOfResponse))]
    internal partial class AppJsonSerializerContext: JsonSerializerContext
    {
     
    }
}
