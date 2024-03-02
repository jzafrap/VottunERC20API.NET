using VottumERC20API.NET;

//set your api and authorization key
var apiKey = "<your api key>";
var authorizationKey = "<your auth key>";

//instance a client by calling the provided factory
var client = VottunApiClientFactory.Create( apiKey, authorizationKey);


//examples of SDK usage
//1. Allowance
var allowanceRequest = new AllowanceRequest
{
    contractAddress = "0xBe0CD9c4C636373eB1c5e1d581b1269E9E40c517",
    network = 80001,
    owner = "0x7590a8ff8a4b8e2831db16a02f03c7acd65aca26",
    spender = "0x7590a8fF8A4B8E2831dB16A02f03c7AcD65aca26"
};
var allowance = await client.AllowanceAsync(  allowanceRequest , CancellationToken.None);

Console.WriteLine($"Allowance: {allowance.allowance}");

//2. Name
var nameRequest = new NameRequest
{
   contractAddress= "0xBe0CD9c4C636373eB1c5e1d581b1269E9E40c517",
   network=80001
};
var name = await client.NameAsync(nameRequest, CancellationToken.None);

Console.WriteLine($"Name: {name.name}");

//3. Symbol

var SymbolRequest = new SymbolRequest
{
    contractAddress = "0xBe0CD9c4C636373eB1c5e1d581b1269E9E40c517",
    network = 80001
};

var symbolResponse = await client.SymbolAsync(SymbolRequest, CancellationToken.None);
Console.WriteLine($"Symbol: {symbolResponse.symbol}");


//4. TotalSupply

var totalSupplyRequest = new TotalSupplyRequest
{
    contractAddress = "0xBe0CD9c4C636373eB1c5e1d581b1269E9E40c517",
    network = 80001
};

var totalSupplyResponse = await client.TotalSupplyAsync(totalSupplyRequest, CancellationToken.None);
Console.WriteLine($"TotalSupply: {totalSupplyResponse.totalSupply}");

//5. Decimals

var decimalsRequest = new DecimalsRequest
{
    contractAddress = "0xBe0CD9c4C636373eB1c5e1d581b1269E9E40c517",
    network = 80001
};

var decimalsResponse = await client.DecimalsAsync(decimalsRequest, CancellationToken.None);
Console.WriteLine($"Decimals: {decimalsResponse.decimals}");

//6. BalanceOf

var balanceOfRequest = new BalanceOfRequest
{
    contractAddress = "0xBe0CD9c4C636373eB1c5e1d581b1269E9E40c517",
    network = 80001,
    address = "0x7590a8ff8a4b8e2831db16a02f03c7acd65aca26"
};

var balanceOfResponse = await client.BalanceOfAsync(balanceOfRequest, CancellationToken.None);
Console.WriteLine($"BalanceOf: {balanceOfResponse.balance}");

//7. Deploy
var deployRequest = new DeployRequest
{
    name = "VottunToken",
    symbol = "VOT",
    alias  = "Vottun token ERC20 test",
    initialSupply = 21000000,
    network = 80001
};

var deployResponse = await client.DeployAsync(deployRequest, CancellationToken.None);
Console.WriteLine($"Deployed ContractAddress: {deployResponse.contractAddress}");


//8. Transfer
var transferRequest = new TransferRequest
{
    contractAddress = "0x5FbE0944D3d2df2C7D2B55c0ED2C9085bcD8971A",
    recipient = "0x7590a8ff8a4b8e2831db16a02f03c7acd65aca26",
    amount = 100,
    network = 80001
};

var transferResponse = await client.TransferAsync(transferRequest, CancellationToken.None);
Console.WriteLine($"Transfer TxnHash: {transferResponse.txHash}");


//9. TransferFrom
var transferFromRequest = new TransferFromRequest
{
    contractAddress = "0x5FbE0944D3d2df2C7D2B55c0ED2C9085bcD8971A",
    sender = "0x7590a8ff8a4b8e2831db16a02f03c7acd65aca26",
    recipient = "0x5770bf37D6617eec99744DD6Ee03a3DA12b681eE",
    amount = 100,
    network = 80001
};

var transferFromResponse = await client.TransferFromAsync(transferFromRequest, CancellationToken.None);
Console.WriteLine($"TransferFrom TxnHash: {transferFromResponse.txHash}");

//10. IncreaseAllowance
var increaseAllowanceRequest = new IncreaseAllowanceRequest
{
    contractAddress = "0x5FbE0944D3d2df2C7D2B55c0ED2C9085bcD8971A",
    spender = "0x5770bf37D6617eec99744DD6Ee03a3DA12b681eE",
    addedValue = 100,
    network = 80001
};

var increaseAllowanceResponse = await client.IncreaseAllowanceAsync(increaseAllowanceRequest, CancellationToken.None);
Console.WriteLine($"IncreaseAllowance TxnHash: {increaseAllowanceResponse.txHash}");


//11. DecreaseAllowance

var decreaseAllowanceRequest = new DecreaseAllowanceRequest
{
    contractAddress = "0x5FbE0944D3d2df2C7D2B55c0ED2C9085bcD8971A",
    spender = "0x5770bf37D6617eec99744DD6Ee03a3DA12b681eE",
    substractedValue = 100,
    network = 80001
};

var decreaseAllowanceResponse = await client.DecreaseAllowanceAsync(decreaseAllowanceRequest, CancellationToken.None);
Console.WriteLine($"DecreaseAllowance TxnHash: {decreaseAllowanceResponse.txHash}");

