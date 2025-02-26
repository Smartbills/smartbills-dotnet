using System.Collections.Generic;

namespace Smartbills.NET.Infrastructure
{
    public class SBClientCredentials: SBCredentials
    {
        public const string Path = "Smartbills";
        public string Authority { get; set; } = "https://api.smartbills.io/auth";
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public List<string> Scopes { get; set; } = new();
        public List<string> Claims { get; set; } = new();
    }

}
