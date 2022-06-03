using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{
    public interface ISBClientBaseConfiguration
    {
        public const string Path = "Smartbills";
        public string Url { get; set; }

    }
}
