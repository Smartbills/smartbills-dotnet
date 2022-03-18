using Smartbills.Infrastructure;
using System.Collections.Generic;

namespace Smartbills.Client
{
    public class SmartbillsConfiguration
    {
        public const string Path = "Smartbills";
        public string Url { get; set; } = "https://api.smartbills.io/";
    }
}