
namespace VottunERC20API.NET
{

    public interface IVottunERCApiClient
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

    

}
