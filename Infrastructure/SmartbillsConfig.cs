using Smartbills.Infrastructure;
using System.Collections.Generic;

namespace Smartbills.Client
{
    public class SmartbillsConfiguration
    {
        public const string Path = "Smartbills";
        public SmartbillsAuthConfig Authentication { get; set; } = new SmartbillsAuthConfig();
        public SmartbillsServicesConfig Services { get; set; } = new SmartbillsServicesConfig();

        public string Url { get; set; } = "https://api.smartbills.io/";
        public string Authority { get; set; } = "https://auth.smartbills.io/";
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public List<string> Scopes { get; set; } = new List<string>();
        public List<string> Ressources { get; set; } = new List<string>();
    }
}