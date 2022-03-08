using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.Infrastructure
{
    public class SmartbillsAuthConfig
    {
        public const string Path = "Smartbills.Authentication";

        public string ApiKey { get; set; }
        public string Authority { get; set; } = "https://api.smartbills.io/auth/";
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Scopes { get; set; }
        public List<string> Ressources { get; set; } = new List<string>();
    }
}
