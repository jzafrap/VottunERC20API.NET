using System.Text.Json.Serialization;


namespace VottunERC20API.NET.json
{
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
    public partial class AppJsonSerializerContext : JsonSerializerContext
    {

    }
}
