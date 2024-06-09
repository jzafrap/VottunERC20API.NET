using System.Numerics;

namespace VottunERC20API.NET
{

    public class TransferRequest : BaseRequest
    {
        public string contractAddress { get; set; }
        public string recipient { get; set; }
        public BigInteger amount { get; set; }

    }
}
