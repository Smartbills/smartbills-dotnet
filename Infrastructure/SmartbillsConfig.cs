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
    }
}