using Smartbills.NET.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Infrastructure
{
    public class SBClientConfiguration : ISBClientBaseConfiguration
    {
        public const string Path = "Smartbills";
        public string Url { get; set; } = "https://api.smartbills.io/";

    }
}
