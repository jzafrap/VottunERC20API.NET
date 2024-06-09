namespace VottunERC20API.NET
{
    public abstract class BaseRequest
    {
            public int network { get; set; }
            public int? gasLimit { get; set; }
    }
}
