using Smartbills.NET.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
