namespace VottunERC20API.NET
{

    public class AllowanceRequest
    {
        public string contractAddress { get; set; }
        public int network { get; set; }
        public string owner { get; set; }
        public string spender { get; set; }
    }
}
