namespace Smartbills.NET.Infrastructure
{
    public class SBClientCredentials
    {
        public const string Path = "Smartbills";
        public string Authority { get; set; } = "https://api.smartbills.io/auth";
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string[] Scopes { get; set; }
        public string[] Claims { get; set; }
    }

}
