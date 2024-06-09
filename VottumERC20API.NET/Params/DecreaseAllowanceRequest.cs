using System.Numerics;

namespace VottunERC20API.NET
{

    public class DecreaseAllowanceRequest : BaseRequest
    {
        public string contractAddress { get; set; }
        public string spender { get; set; }
        public BigInteger substractedValue { get; set; }
    }
}
