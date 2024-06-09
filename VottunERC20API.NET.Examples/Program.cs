using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using System.Text.Json;
using VottunERC20API.NET;


//set your api and authorization key

//set your api and authorization key
var apiKey = "YTVBcIJsRwrJL2UqkuUMHAk6nhPNLVDGQCA8QHHpNtaJ_Sg9yR3qfgoiBv19ZoIf";
var applicationID = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiIyYzhkM01GclFnd2NmdlFreXl5TXpMRGlhdTMiLCJ0eXBlIjoiZXJwIiwiaWQiOiIiLCJ1c2VybmFtZSI6Imp6YWZyYWRlbHBvem9AZ21haWwuY29tIiwiY2lkIjoiMTBkZDExZDctMmMxYi00MTgzLTg0YjgtZjA2ZjNjZjhlMjk0Iiwic2t1IjpbeyJyIjoxMSwicyI6OCwiZSI6MH0seyJyIjoxMSwicyI6ODAwMSwiZSI6MH0seyJyIjoxMSwicyI6ODAwMiwiZSI6MH0seyJyIjoxMSwicyI6ODAwMywiZSI6MH0seyJyIjoxMSwicyI6ODAwNSwiZSI6MH0seyJyIjoxMSwicyI6ODAxMCwiZSI6MH0seyJyIjoxMSwicyI6MywiZSI6MH1dLCJwdWMiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwMDAwMDAwMDAifQ.fKOoXcP4R3Tu3l-zD155jkRBDjysO1ohRjekAq7plpOEXEHmU0O-xCIfQujVaSka8-QA-vMhiT6LC6Lp7BEE3vA4XhPUsoy9ghmRA87nJbJWl6EiUOpAIrYaiPn6LXG3NKWPJq7FR51kVM5oAGi6DQLd3syuLtydixk0lZwYYIMImq1WoYTkkQFehLodVH3_P36mCLBdZvFYir49RR3p-Uc0-U_HIBUcezwapaAiJS-FCPz03beYKs3ij_YoGofnZ40B5kpgOFUihp7D7n58Eb1H-2RtXqVLhnwP1gUvYh7C2fBtGieirvad6NWhzXUSLBoKsHN2et7vLfHS6jNYFKMZJJ_L8r8Si2cLJIo2fXH_51bUBDQtfjI-BPuuUvhOL_bk5J3MTfTJ-MJ9RGDvCCYNAhZ0seLjgmZ4gTNXQ7w9BkRY7St-fgj7G2gWBFIptgcIt3Fjqtf_rybr4HAWQ6aKcnaHx6_d8hZi_DwiTRLdoBEQuIooqPf3Z8Q8dwwiyUSmB-K5efuck8iju_IeMp28c2UEeJgONudGHsGBER8ilpF1WWpQRdPTrf07xMAZT5WrQHo1UhdfIMhx9o0CLQcfn33yLEX5i_JAItEvdO2ba3gBxpAFJ08IvSZJbPeANslTXtesvu2v2k_eTFy0nmfv6INqATNBCaFPFhgme-U";



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



