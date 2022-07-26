using Smartbills.NET.Services;

namespace Smartbills.NET.Infrastructure
{
    public class SBClientConfiguration : ISmartbillsClientBaseConfiguration
    {
        public const string Path = "Smartbills";
        public string Url { get; set; } = "https://api.smartbills.io/";

    }
}
