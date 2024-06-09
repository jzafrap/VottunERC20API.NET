using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using System.Text.Json;
using VottunERC20API.NET;


//set your api and authorization key

//set your api and authorization key
var apiKey = "<your api key>";
var authorizationKey = "<your auth key>";


//instance a client by calling the provided factory
var client = VottunApiClientFactory.Create( apiKey, applicationID);

//7. Deploy
var deployRequest = new DeployRequest
{
    name = "VottunToken",
    symbol = "VOT",
    alias = "Vottun token ERC20 test",
    initialSupply = 2100000000000,
    network = 80002
};

/*
var options = new JsonSerializerOptions();
options.Converters.Add(new BigIntegerConverter());
options.TypeInfoResolver = new AppJsonSerializerContext();
JsonContent content = JsonContent.Create(deployRequest,typeof(DeployRequest),mediaType:null,  options);
string json = content.ToString();

string jsonString = JsonSerializer.Serialize(deployRequest, typeof(DeployRequest), options);
Console.WriteLine($"{jsonString}");
*/

var deployResponse = await client.DeployAsync(deployRequest, CancellationToken.None);
Console.WriteLine($"Deployed ContractAddress: {deployResponse.contractAddress}");

var totalSupplyResponse = await client.TotalSupplyAsync(new TotalSupplyRequest()
{
    contractAddress = deployResponse.contractAddress,
    network = 80002
}, CancellationToken.None);

Console.WriteLine($"Total Supply: {totalSupplyResponse.totalSupply}");



