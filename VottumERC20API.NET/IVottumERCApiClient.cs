using System.Net.NetworkInformation;
using System.Text.Json.Serialization;

namespace VottumERC20API.NET
{

    public interface IVottumERCApiClient
    {


        Task<DeployResponse> DeployAsync(DeployRequest request, CancellationToken cancellationToken);

        Task<TransferResponse> TransferAsync(TransferRequest request, CancellationToken cancellationToken);

        Task<TransferFromResponse> TransferFromAsync(TransferFromRequest request, CancellationToken cancellationToken);

        Task<IncreaseAllowanceResponse> IncreaseAllowanceAsync(IncreaseAllowanceRequest request, CancellationToken cancellationToken);

        Task<DecreaseAllowanceResponse> DecreaseAllowanceAsync(DecreaseAllowanceRequest request, CancellationToken cancellationToken);

        Task<AllowanceResponse> AllowanceAsync(AllowanceRequest request, CancellationToken cancellationToken);

        Task<NameResponse> NameAsync(NameRequest request, CancellationToken cancellationToken);

        Task<SymbolResponse> SymbolAsync(SymbolRequest request, CancellationToken cancellationToken);

        Task<TotalSupplyResponse> TotalSupplyAsync(TotalSupplyRequest request, CancellationToken cancellationToken);

        Task<DecimalsResponse> DecimalsAsync(DecimalsRequest request, CancellationToken cancellationToken);

        Task<BalanceOfResponse> BalanceOfAsync(BalanceOfRequest request, CancellationToken cancellationToken);

    }

    public class BaseQuery
    {
        public int network { get; set; } 
        public int? gasLimit { get; set; }
    }

    public class DeployRequest : BaseQuery
    {
        public string name { get; set; } 
        public string symbol { get; set; } 
        public string alias { get; set; } 
        public int initialSupply { get; set; }
    }

    public class DeployResponse 
    {
        public string contractAddress { get; set; }
        public string txnHash { get; set; }
    }

    public class TransferRequest : BaseQuery 
    {
        public string contractAddress { get; set; }
        public string recipient { get; set; }
        public int amount { get; set; }

    }

    public class TransferResponse
    {
        public string txHash { get; set; }
        public int nonce { get; set; }
    }

    public class TransferFromRequest : BaseQuery
    {
        public string contractAddress { get; set; }
        public string sender { get; set; }
        public string recipient { get; set; }
        public int amount { get; set; }
    }

    public class TransferFromResponse
    {
        public string txHash { get; set; }
        public int nonce { get; set; }
    }

    public class IncreaseAllowanceRequest : BaseQuery
    {
        public string contractAddress { get; set; }
        public string spender { get; set; }
        public int addedValue { get; set; }
    }

    public class IncreaseAllowanceResponse
    {
        public string txHash { get; set; }
        public int nonce { get; set; }
    }

    public class DecreaseAllowanceRequest : BaseQuery
    {
        public string contractAddress { get; set; }
        public string spender { get; set; }
        public int substractedValue { get; set; }
    }

    public class DecreaseAllowanceResponse
    {
        public string txHash { get; set; }
        public int nonce { get; set; }
    }

    
    public class AllowanceRequest
    {
        public string contractAddress { get; set; }
        public int network { get; set; }
        public string owner { get; set; }
        public string spender { get; set; }
    }

    public class AllowanceResponse
    {
        public int allowance { get; set; }
    }

    public class NameRequest
    {
        public string contractAddress { get; set; }
        public int network { get; set; }
    }

    public class NameResponse
    {
        public string name { get; set; }
    }

    public class SymbolRequest
    {
        public string contractAddress { get; set; }
        public int network { get; set; }
    }

    public class SymbolResponse
    {
        public string symbol { get; set; }
    }

    public class TotalSupplyRequest
    {
        public string contractAddress { get; set; }
        public int network { get; set; }
    }

    public class TotalSupplyResponse
    {
        public int totalSupply { get; set; }
    }

       public class DecimalsRequest
    {
        public string contractAddress { get; set; }
        public int network { get; set; }
    }

    public class DecimalsResponse
    {
        public int decimals { get; set; }
    }

    public class BalanceOfRequest
    {
        public string contractAddress { get; set; }
        public int network { get; set; }
        public string address { get; set; }
    }

    public class BalanceOfResponse
    {
        public int balance { get; set; }
    }
}
