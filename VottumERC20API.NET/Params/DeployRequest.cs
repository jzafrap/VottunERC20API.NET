using System.Numerics;


namespace VottunERC20API.NET
{
    public class DeployRequest : BaseRequest
    {
       
        public string name { get; set; }
        public string symbol { get; set; }
        public string alias { get; set; }
        public BigInteger initialSupply { get; set; }
    }
}
