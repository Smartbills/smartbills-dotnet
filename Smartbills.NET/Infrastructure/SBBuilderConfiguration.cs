using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Infrastructure
{
    public class SBBuilderConfiguration
    {
        public string Url { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public string OAuthToken { get; set; }
    }
}
