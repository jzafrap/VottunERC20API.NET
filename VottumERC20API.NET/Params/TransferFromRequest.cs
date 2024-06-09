using System.Numerics;

namespace VottunERC20API.NET
{
    public class TransferFromRequest : BaseRequest
    {
        public string contractAddress { get; set; }
        public string sender { get; set; }
        public string recipient { get; set; }
        public BigInteger amount { get; set; }
    }
}
