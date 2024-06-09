namespace VottunERC20API.NET
{

    public class BalanceOfRequest
    {
        public string contractAddress { get; set; }
        public int network { get; set; }
        public string address { get; set; }
    }
}
