namespace Smartbills.NET.Infrastructure
{
    public class SBApiKeyCredentials: SBCredentials
    {
        public SBApiKeyCredentials(string apiKey, string apiSecret)
        {
            ApiKey = apiKey;
            ApiSecret = apiSecret;
        }

        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }

    }
}
