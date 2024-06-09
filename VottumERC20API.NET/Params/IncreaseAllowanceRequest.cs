using System.Numerics;

namespace VottunERC20API.NET
{
    public class IncreaseAllowanceRequest : BaseRequest
    {
        public string contractAddress { get; set; }
        public string spender { get; set; }
        public BigInteger addedValue { get; set; }
    }
}
